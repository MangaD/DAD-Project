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

        public void CreateMeeting(string coordinatorUser, RemotingAddress coordinatorRA, string topic,
            uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            #region Validate arguments (topic exists, locations exist, invitees exist...)

            if (topic == "")
            {
                throw new ApplicationException("Must add a topic!");
            }
            if (coordinatorUser == "")
            {
                throw new ApplicationException("You do not have a username!");
            }
            if (coordinatorRA == null)
            {
                throw new ApplicationException("You did not provide a Remoting Address!");
            }
            if (minAttendees == 0)
            {
                throw new ApplicationException("Minimum attendees must be higher than 0!");
            }
            if (slots.Count == 0)
            {
                throw new ApplicationException("Must add slots to the meeting!");
            }

            // Find repeated slots
            var myListSlots = new List<Slot>();
            var duplicateSlots = new List<Slot>();

            foreach (var s in slots)
            {
                if (!myListSlots.Contains(s))
                {
                    myListSlots.Add(s);
                }
                else
                {
                    duplicateSlots.Add(s);
                }
            }

            if (duplicateSlots.Count > 0)
            {
                throw new ApplicationException("You have repeated slots.");
            }

            // Find repeated invitees
            var myListInvitees = new List<string>();
            var duplicateInvitees = new List<string>();

            foreach (var s in invitees)
            {
                if (!myListInvitees.Contains(s))
                {
                    myListInvitees.Add(s);
                }
                else
                {
                    duplicateInvitees.Add(s);
                }
            }

            if (duplicateInvitees.Count > 0)
            {
                throw new ApplicationException("You have repeated invitees.");
            }

            // Check if all invitees exist
            foreach (string invitee in invitees)
            {
                if (!Server.clients.Exists(i => i.Username == invitee))
                {
                    throw new ApplicationException($"Invitee '{invitee}' does not exist or is not connected.");
                }
            }

            // Check if locations exist
            foreach (Slot s in slots)
            {
                if (!Server.locationRooms.ContainsKey(s.location))
                {
                    throw new ApplicationException($"Location '{s.location}' does not exist in the server.");
                }
            }

            // Check if a meeting with this topic does not exist already
            foreach (MeetingProposal mp2 in Server.meetingPropList)
            {
                if(mp2.Topic == topic)
                {
                    throw new ApplicationException("A meeting with this topic already exists.");
                }
            }

            #endregion

            MeetingProposal mp = new MeetingProposal(coordinatorUser, coordinatorRA, topic, minAttendees, slots, invitees);

            Server.meetingPropList.Add(mp);

            // Run in a separate thread because this client is informed too.
            Thread thread = new Thread(() => Server.InformClientsOfNewMeeting(mp));
            thread.Start();

            Console.WriteLine("[Server] Created meeting:" +
                "\n\tTopic: " + topic +
                "\n\tCoordinator: " + coordinatorUser +
                "\n\tCoordinator URL: " + coordinatorRA +
                "\n\tMinimum attendees: " + minAttendees);
        }

        public void JoinMeeting(string topic, string clientName,
            RemotingAddress clientRA, List<Slot> slots)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

             #region Validate arguments (topic exists, locations exist...)

            if (topic == "")
            {
                throw new ApplicationException("Must select a topic!");
            }
            if (clientName == "")
            {
                throw new ApplicationException("You do not have a username!");
            }
            if (clientRA == null)
            {
                throw new ApplicationException("You did not provide a Remoting Address!");
            }
            if (slots.Count == 0)
            {
                throw new ApplicationException("Must select slots on which you are available.");
            }

            // Check if a meeting with this topic exists
            if (!Server.meetingPropList.Exists(mp => mp.Topic == topic))
            {
                throw new ApplicationException($"There is no meeting with topic '{topic}'.");
            }

            // Find repeated slots
            var myListSlots = new List<Slot>();
            var duplicateSlots = new List<Slot>();

            foreach (var s in slots)
            {
                if (!myListSlots.Contains(s))
                {
                    myListSlots.Add(s);
                }
                else
                {
                    duplicateSlots.Add(s);
                }
            }

            if (duplicateSlots.Count > 0)
            {
                throw new ApplicationException("You have repeated slots.");
            }

            // Check if locations exist
            foreach (Slot s in slots)
            {
                if (!Server.locationRooms.ContainsKey(s.location))
                {
                    throw new ApplicationException($"Location '{s.location}' does not exist in the server.");
                }
            }

            #endregion

            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                if (mp.Topic == topic)
                {
                    if (mp.Status == MeetingProposal.StatusEnum.Closed)
                    {
                        throw new ApplicationException($"Meeting '{topic}' is closed.");
                    }
                    else if (mp.Status == MeetingProposal.StatusEnum.Cancelled)
                    {
                        throw new ApplicationException($"Meeting '{topic}' is cancelled.");
                    }
                    else if (mp.ClientsJoined.Keys.Contains(clientName))
                    {
                        throw new ApplicationException($"You have already joined meeting '{topic}'.");
                    }
                    else if (mp.Invitees.Count > 0 && 
                        mp.CoordinatorUsername != clientName &&
                        !mp.Invitees.Contains(clientName))
                    {
                        throw new ApplicationException($"You have not been invited for meeting '{topic}'!");
                    }

                    foreach(Slot s in slots)
                    {
                        if (!mp.Slots.Contains(s))
                        {
                            throw new ApplicationException($"Slot '{s.ToString()}' does not exist in this meeting.");
                        }
                    }

                    mp.AddClientToMeeting(clientName, clientRA, slots);
                }
            }
        }

        public List<MeetingProposal> ListMeetings(string clientName, 
            bool excludeClosed, bool excludeJoined, bool excludeCancelled)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            if (clientName == "")
            {
                throw new ApplicationException("You do not have a username!");
            }

            List<MeetingProposal> meetings = new List<MeetingProposal>();
            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                if (!excludeClosed || (excludeClosed && mp.Status != MeetingProposal.StatusEnum.Closed))
                {
                    if (!excludeCancelled || (excludeCancelled && mp.Status != MeetingProposal.StatusEnum.Cancelled))
                    {
                        if (!excludeJoined || (excludeJoined && !mp.ClientsJoined.ContainsKey(clientName)))
                        {
                            if (mp.Invitees.Count == 0 ||
                                mp.CoordinatorUsername == clientName ||
                                mp.Invitees.Contains(clientName))
                            {
                                meetings.Add(mp);
                            }
                        }
                    }                    
                }
            }

            return meetings;
        }

        public MeetingProposal GetMeeting(string clientName, string topic)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            if (topic == "")
            {
                throw new ApplicationException("Must select a topic!");
            }
            if (clientName == "")
            {
                throw new ApplicationException("You do not have a username!");
            }

            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                if (mp.Topic == topic)
                {
                    if (mp.Invitees.Count == 0 ||
                        mp.CoordinatorUsername == clientName ||
                        mp.Invitees.Contains(clientName))
                    {
                        return mp;
                    }
                }
            }
            return null;
        }

        public void RegisterClient(string username, RemotingAddress clientRA)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            if (username == null || username == "")
            {
                throw new ApplicationException($"Username cannot be empty!");
            }
            if (clientRA == null || clientRA.address == null || clientRA.address == "")
            {
                throw new ApplicationException($"Your address cannot be empty!");
            }
            if (clientRA.channel == null || clientRA.channel == "")
            {
                throw new ApplicationException($"Your channel cannot be empty!");
            }
            if (Server.clients.Exists(c => c.Username == username))
            {
                throw new ApplicationException($"Someone with username '{username}' is already connected.");
            }

            IClient newClientChannel = (IClient)Activator.GetObject(typeof(IClient), clientRA.ToString());
            Client newClient = new Client(newClientChannel, username, clientRA);
            Server.clients.Add(newClient);

            Thread thread = new Thread(() => Server.InformAllClientsOfNewClient(username));
            thread.Start();

            Console.WriteLine($"New client '{username}' listening at '{clientRA}'");
        }

        public List<string> GetClientUsernames()
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            List<string> usernamesList = new List<string>();
            foreach(Client client in Server.clients)
            {
                usernamesList.Add(client.Username);
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


        public void CloseMeeting(string topic, string coordinatorUsername)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                //Closing wanted meeting and client closing is coordinator and meeting is not yet closed
                if (mp.Topic == topic && mp.CoordinatorUsername == coordinatorUsername &&
                    mp.Status != MeetingProposal.StatusEnum.Closed)
                {
                    // Get most wanted slot by users
                    Slot most = mp.ChosenSlots
                        .GroupBy(i => i)
                        .OrderByDescending(grp => grp.Count())
                        .Select(grp => grp.Key).First();
                    Console.WriteLine("Most: " + most.location + " " + most.date);

                    //Check if there is Room available in location choosed
                    if (Server.locationRooms.ContainsKey(most.location))
                    {
                        List<Room> rooms = Server.locationRooms[most.location];
                        foreach (Room r in rooms)
                        {
                            if (r.Capacity >= mp.ClientsJoined.Keys.Count && r.Available == true)
                            {
                                r.Available = false;
                                mp.BookedSlot = most;
                                mp.BookedRoom = r;
                                mp.Status = MeetingProposal.StatusEnum.Closed;
                                //slot was available and room is filled with max or less than max capacity


                                Console.WriteLine("Meeting Booked with: " + mp.ClientsJoined.Keys.Count +
                                    " Clients, in Slot: " + mp.BookedSlot.location +
                                    " " + mp.BookedSlot.date + " " +
                                    " and in Room: " + mp.BookedRoom.Name);

                                return;
                            }
                        }
                    }

                }
            }

            throw new ApplicationException("Error Closing Meeting! Try again =(");
        }

    }
}
