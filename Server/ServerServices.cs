﻿using System;
using System.Collections.Generic;
using System.Linq;

using API;

namespace Server
{
    partial class ServerServices : MarshalByRefObject, IServerC
    {
        public bool CloseMeeting(string topic, string coordinatorURL)
        {
            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                if (mp.Topic == topic && mp.CoodinatorURL == coordinatorURL && mp.State == 0)
                {
                    mp.State = 1;
                    return true;
                }
            }
            return false;
        }

        public void CreateMeeting(string coordinatorUser, string coordinatorURL, string topic, uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            Server.meetingPropList.Add(new MeetingProposal(coordinatorUser, coordinatorURL, topic, minAttendees, slots, invitees));

            Console.WriteLine("[Server] Criei a Meeting: " + topic + " CoordinatorURL: " + coordinatorURL);
        }

        public bool JoinMeeting(string topic, string clientName, string clientRA, int n_slots, List<Slot> locationDates)
        {
            foreach (MeetingProposal mp in Server.meetingPropList)
            {
                if (mp.Topic == topic && mp.Invitees.Count == 0 && mp.State == 0)
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
            return false;
        }

        public List<MeetingProposal> ListMeetings(string clientName)
        {
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
            List<string> usernamesList = new List<string>();
            foreach(Client client in Server.clients)
            {
                usernamesList.Add(client.ClientName);
            }
            return usernamesList;
        }

        public List<string> GetLocations()
        {
            List<string> loc = new List<string>();
            foreach(string s in Server.locationRooms.Keys)
            {
                loc.Add(s);
            }
            return loc;
        }

        public void ClientSaysHelloToServer(UInt16 clientPort)
        {
            //Find client in client list
            Client client = Server.clients.First(item => item.ClientRA.port == clientPort);

            Console.WriteLine("Client: " + client.ClientName + " Port: " + client.ClientRA.port + " Says: Hello");

            //Server responds to that talked to him.
            //client.getClientChannel().serverRespondsHiToClient(server.getServerPort());

            //Server Broadcasts to all clients include client that talked to him.
            foreach (Client c in Server.clients)
            {
                c.ClientChannel.ServerRespondsHiToClient(Server.serverRA.port);
            }
        }
    }
}
