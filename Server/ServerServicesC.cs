using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using API;

namespace Server
{
    partial class ServerServices : MarshalByRefObject, IServerC
    {
        private void Delay()
        {
            int delay = Server.GetRandomDelay();
            //Utilities.WriteDebug($"Delaying for {delay}.");
            Utilities.Wait(delay);
        }

        public bool CloseMeeting(string topic, string coordinatorURL)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                //Closing wanted meeting and client closing is coordinator and meeting is not yet closed
                if (mp.Topic == topic && mp.CoodinatorURL == coordinatorURL && !mp.IsClosed)
                {
                    //Check which date is most wanted
                    List<Slot> maxClientsSlots = new List<Slot>();

                    uint maxClients = mp.MinAttendees;
                    uint nClients;

                    foreach (Slot slot in mp.Slots)
                    {
                        nClients = (uint) mp.ClientPerSlot[slot].Count();
                        if (nClients > maxClients)
                        {
                            maxClientsSlots.Clear();
                            maxClients = nClients;
                        }
                        if (nClients == maxClients)
                        {
                            maxClientsSlots.Add(slot);
                        }
                    }

                    //Check if slot with most clients has available room
                    Slot selectedSlot = Slot.FromString("empty,0000-00-00");

                    Room maxSizeRoom = new Room("empty", 0);
                    maxSizeRoom.Available = false;

                    foreach (Slot slot in maxClientsSlots)
                    {
                        if (mp.IsClosed) break;
                        if (Server.locationRooms[slot.location].Count() > 0)
                        {
                            foreach (Room room in Server.locationRooms[slot.location])
                            {
                                if (room.Capacity >= maxSizeRoom.Capacity) maxSizeRoom = room;
                                if (room.Available && room.Capacity >= maxClients)
                                {
                                    selectedSlot = slot;
                                    room.Available = false;
                                    mp.IsClosed = true;
                                    break;
                                }
                            }
                        }
                    }

                    //Make a list with all the clients that want the slot chosen that has a room
                    if (selectedSlot.location != "empty")
                    {
                        uint del = maxSizeRoom.Capacity;
                        foreach (string clientName in mp.ClientPerSlot[selectedSlot])
                        {
                            //Only add Clients up to max room size
                            if (del-- == 0) break;
                            mp.ClientsAccepted.Add(clientName, mp.ClientsJoined[clientName]);
                        }
                        //slot was available and room is filled with max or less than max capacity
                        return true;
                    }
                    else
                    {
                        //no slot was available for min atendees
                        return false;
                    }
                }
            }
            return false;
        }

        public void CreateMeeting(string coordinatorUser, string coordinatorURL, string topic,
            uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            if (topic == "")
            {
                throw new ApplicationException("Must add a topic!");
            }
            if (slots.Count == 0)
            {
                throw new ApplicationException("Must add slots to the meeting!");
            }

            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                if(mp.Topic == topic)
                {
                    throw new ApplicationException("A meeting with this topic already exists.");
                }
            }

            Server.meetingPropList.Add(new MeetingProposal(coordinatorUser, coordinatorURL, topic, minAttendees, slots, invitees));

            // Run in a separate thread because this client is informed too.
            Thread thread = new Thread(() => Server.InformAllClientsOfNewMeeting(topic));
            thread.Start();

            Console.WriteLine("[Server] Created meeting:" +
                "\n\tTopic: " + topic +
                "\n\tCoordinator: " + coordinatorUser +
                "\n\tCoordinator URL: " + coordinatorURL +
                "\n\tMinimum participants: " + minAttendees);
        }

        public void JoinMeeting(string topic, string clientName, string clientRA, int n_slots, List<Slot> locationDates)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            if (topic == "")
            {
                throw new ApplicationException("Must select a topic!");
            }
            if (locationDates.Count == 0)
            {
                throw new ApplicationException("Must select slots on which you are available.");
            }

            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                if (mp.Topic == topic)
                {
                    if (mp.IsClosed)
                    {
                        throw new ApplicationException($"Meeting '{topic}' is closed.");
                    }
                    else if (mp.ClientsJoined.Keys.Contains(clientName))
                    {
                        throw new ApplicationException($"You have already joined meeting '{topic}'.");
                    }

                    if (mp.Invitees.Count == 0)
                    {
                        mp.JoinClientToMeeting(clientName, clientRA, n_slots, locationDates);
                    }
                    else
                    {
                        foreach (string inv in mp.Invitees)
                        {
                            if (inv == clientName || clientName == mp.CoordinatorUsername)
                            {
                                mp.JoinClientToMeeting(clientName, clientRA, n_slots, locationDates);
                            }
                        }
                    }
                }
            }
        }

        public List<MeetingProposal> ListMeetings(string clientName)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            List<MeetingProposal> meetings = new List<MeetingProposal>();
            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                Console.WriteLine("mp.Invitees.Count = " + mp.Invitees.Count);

                if (mp.Invitees.Count == 0 && !mp.IsClosed &&  mp.CoordinatorUsername != clientName)
                {
                    meetings.Add(mp);
                }
                else
                {
                    foreach (string inv in mp.Invitees)
                    {
                        if (inv == clientName && !mp.IsClosed)
                        {
                            meetings.Add(mp);
                        }
                    }
                }
            }

            foreach(MeetingProposal meeting in meetings)
            {
                Console.WriteLine("Meeting: " + meeting.Topic);
            }

            return meetings;
        }

        public MeetingProposal GetMeeting(string topic)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                if (mp.Invitees.Count == 0 && !mp.IsClosed && mp.Topic == topic)
                {
                    return mp;
                }
                else
                {
                    foreach (string inv in mp.Invitees)
                    {
                        if (!mp.IsClosed && mp.Topic == topic)
                        {
                            return mp;
                        }
                    }
                }
            }
            return null;
        }

        public List<string> RegisterClient(string clientName, string clientRA)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            IClient newClientChannel =
                (IClient)Activator.GetObject(
                    typeof(IClient), clientRA);
            Client newClient = new Client(newClientChannel, clientName, RemotingAddress.FromString(clientRA));
            Server.clients.Add(newClient);
            Console.WriteLine("New client " + clientName + " listenning at " + clientRA);

            //return messages;
            return null;
        }

        public List<string> GetClientsUsername()
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            List<string> usernamesList = new List<string>();
            foreach(Client client in Server.clients)
            {
                usernamesList.Add(client.ClientName);
            }
            return usernamesList;
        }

        public List<string> GetLocations()
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            List<string> loc = new List<string>();
            foreach(string s in Server.locationRooms.Keys)
            {
                loc.Add(s);
            }
            return loc;
        }

    }
}
