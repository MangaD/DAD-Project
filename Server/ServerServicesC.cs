using System;
using System.Collections.Generic;
using System.Linq;

using API;

namespace Server
{
    partial class ServerServices : MarshalByRefObject, IServerC
    {
        public bool CloseMeeting(string topic, string coordinatorURL)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command

            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                //Closing wanted meeting and client closing is coordinator and meeting is not yet closed
                if (mp.Topic == topic && mp.CoodinatorURL == coordinatorURL && mp.State == 0)
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
                        if (mp.State == 1) break;
                        if (Server.locationRooms[slot.location].Count() > 0)
                        {
                            foreach (Room room in Server.locationRooms[slot.location])
                            {
                                if (room.Capacity >= maxSizeRoom.Capacity) maxSizeRoom = room;
                                if (room.Available && room.Capacity >= maxClients)
                                {
                                    selectedSlot = slot;
                                    room.Available = false;
                                    mp.State = 1;
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

        public void CreateMeeting(string coordinatorUser, string coordinatorURL, string topic, uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command

            Server.meetingPropList.Add(new MeetingProposal(coordinatorUser, coordinatorURL, topic, minAttendees, slots, invitees));

            Console.WriteLine("[Server] Created meeting: " + topic + " CoordinatorURL: " + coordinatorURL);
        }

        public bool JoinMeeting(string topic, string clientName, string clientRA, int n_slots, List<Slot> locationDates)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command

            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                if (mp.Topic == topic && mp.State == 0 && !mp.ClientsJoined.Keys.Contains(clientName))
                {
                    if (mp.Invitees.Count == 0)
                    {
                        mp.JoinClientToMeeting(clientName, clientRA, n_slots, locationDates);
                        return true;
                    }
                    else
                    {
                        foreach (string inv in mp.Invitees)
                        {
                            if (inv == clientName && mp.State == 0)
                            {
                                mp.JoinClientToMeeting(clientName, clientRA, n_slots, locationDates);
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public List<MeetingProposal> ListMeetings(string clientName)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command

            List<MeetingProposal> meetings = new List<MeetingProposal>();
            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                Console.WriteLine("mp.Invitees.Count = " + mp.Invitees.Count);

                if (mp.Invitees.Count == 0 && mp.State == 0 &&  mp.CoordinatorUsername != clientName)
                {
                    meetings.Add(mp);
                }
                else
                {
                    foreach (string inv in mp.Invitees)
                    {
                        if (inv == clientName && mp.State == 0)
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

        public List<string> RegisterClient(string clientName, string clientRA)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command

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

            List<string> loc = new List<string>();
            foreach(string s in Server.locationRooms.Keys)
            {
                loc.Add(s);
            }
            return loc;
        }

    }
}
