using System;
using System.Collections.Generic;
using System.Linq;

using API;

namespace Server
{
    class ServerServices : MarshalByRefObject, IServerC
    {
        public bool CloseMeeting(string topic, string coordinatorURL)
        {
            foreach (MeetingProposal mp in Server.getMeetingPropList())
            {
                if (mp.Topic == topic && mp.CoodinatorURL == coordinatorURL && mp.State == 0)
                {
                    mp.State = 1;
                    return true;
                }
            }
            return false;
        }

        public void CreateMeeting(string coordinatorURL, string topic, uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            Server.addMeetingPropToList(new MeetingProposal(coordinatorURL, topic, minAttendees, slots, invitees));

            Console.WriteLine("[Server] Criei a Meeting! CoordinatorURL: " + coordinatorURL);
        }

        public bool JoinMeeting(string topic, string clientName, string clientRA, int n_slots, List<Slot> locationDates)
        {
            foreach (MeetingProposal mp in Server.getMeetingPropList())
            {
                if (mp.Topic == topic && mp.Invitees == null && mp.State == 0)
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

        public List<string> ListMeetings(string clientName)
        {
            List<string> meetingsTopic = new List<string>();
            foreach (MeetingProposal mp in Server.getMeetingPropList())
            {
                if (mp.Invitees == null && mp.State == 0)
                {
                    meetingsTopic.Add(mp.Topic);
                }
                else
                {
                    foreach (string inv in mp.Invitees)
                    {
                        if (inv == clientName && mp.State == 0)
                        {
                            meetingsTopic.Add(mp.Topic);
                        }
                    }
                }
            }
            return meetingsTopic;
        }

        public List<string> RegisterClient(string clientName, string clientRA)
        {
            IClient newClientChannel =
                (IClient)Activator.GetObject(
                    typeof(IClient), clientRA);
            Client newClient = new Client(newClientChannel, clientName, RemotingAddress.FromString(clientRA));
            Server.getClientsList().Add(newClient);
            Console.WriteLine("New client " + clientName + " listenning at " + clientRA);

            //return messages;
            return null;
        }

        public void ClientSaysHelloToServer(UInt16 clientPort)
        {
            //Find client in client list
            Client client = Server.getClientsList().First(item => item.ClientRA.port == clientPort);

            Console.WriteLine("Client: " + client.ClientName + " Port: " + client.ClientRA.port + " Says: Hello");

            //Server responds to that talked to him.
            //client.getClientChannel().serverRespondsHiToClient(server.getServerPort());

            //Server Broadcasts to all clients include client that talked to him.
            foreach (Client c in Server.getClientsList())
            {
                c.ClientChannel.ServerRespondsHiToClient(Server.getServerPort());
            }
        }
    }
}
