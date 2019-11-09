﻿using System;
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

        public void CreateMeeting(string coordinatorUser, string coordinatorURL, string topic,
            uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            if (topic == "")
            {
                throw new ApplicationException("Must add a topic!");
            }
            if (coordinatorUser == "")
            {
                throw new ApplicationException("You do not have a username!");
            }
            if (coordinatorURL == "")
            {
                throw new ApplicationException("You do not have a URL!");
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

            MeetingProposal mp = new MeetingProposal(coordinatorUser, coordinatorURL, topic, minAttendees, slots, invitees);

            Server.meetingPropList.Add(mp);

            // Run in a separate thread because this client is informed too.
            Thread thread = new Thread(() => Server.InformClientsOfNewMeeting(mp));
            thread.Start();

            Console.WriteLine("[Server] Created meeting:" +
                "\n\tTopic: " + topic +
                "\n\tCoordinator: " + coordinatorUser +
                "\n\tCoordinator URL: " + coordinatorURL +
                "\n\tMinimum attendees: " + minAttendees);
        }

        public void JoinMeeting(string topic, string clientName, string clientRA, List<Slot> locationDates)
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
                        mp.JoinClientToMeeting(clientName, clientRA, locationDates);
                    }
                    else
                    {
                        foreach (string inv in mp.Invitees)
                        {
                            if (inv == clientName || clientName == mp.CoordinatorUsername)
                            {
                                mp.JoinClientToMeeting(clientName, clientRA, locationDates);
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

                if (mp.Invitees.Count == 0 && !mp.IsClosed)
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

        public void RegisterClient(string username, string clientRA)
        {
            Server.freezeHandle.WaitOne(); // For Freeze command
            this.Delay(); // For induced delay

            IClient newClientChannel =
                (IClient)Activator.GetObject(
                    typeof(IClient), clientRA);
            Client newClient = new Client(newClientChannel, username, RemotingAddress.FromString(clientRA));
            Server.clients.Add(newClient);

            Thread thread = new Thread(() => Server.InformAllClientsOfNewClient(username));
            thread.Start();

            Console.WriteLine("New client " + username + " listenning at " + clientRA);
        }

        public List<string> GetClientsUsername()
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
                if (mp.Topic == topic && mp.CoordinatorUsername == coordinatorUsername && !mp.IsClosed)
                {
                    // Get most wanted slot by users
                    Slot most = mp.ChoosedSlots.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
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
                                mp.IsClosed = true;
                                //slot was available and room is filled with max or less than max capacity


                                Console.WriteLine("Meeting Booked with: " + mp.ClientsJoined.Keys.Count +
                                    " Clients, in Slot: " + mp.BookedSlot.location + " " + mp.BookedSlot.date + " " +
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
