using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using API;

namespace Server
{
    partial class ServerServices : MarshalByRefObject, IServerS
    {
        public void InformClientJoinedMeeting(MeetingProposal mp, string clientName,
            RemotingAddress clientRA, List<Slot> slots)
        {
            foreach(MeetingProposal meeting in Server.meetingPropList)
            {
                if(meeting.Topic == mp.Topic)
                {
                    if (!meeting.ClientsJoined.ContainsKey(clientName)){
                        Console.WriteLine("Inform replicas that client: " + clientName + " joined meeting: " + mp.Topic);
                        meeting.AddClientToMeeting(clientName, clientRA, slots);
                    }
                }
            }
        }

        public void InformNewClient(string newClientUsername, RemotingAddress newClientRA)
        {
            bool clientExists = false;
            foreach(Client c in Server.clients)
            {
                if(c.Username == newClientUsername)
                {
                    clientExists = true;
                }
            }
            if (!clientExists)
            {
                IClient cliChannel = (IClient)Activator.GetObject(typeof(IClient), newClientRA.ToString());
                Client newClient = new Client(cliChannel, newClientUsername, newClientRA);
                Server.clients.Add(newClient);
                cliChannel.RegisterServerReplica(Server.serverID, Server.serverRAForClients);
            }
        }

        public void InformNewMeeting(MeetingProposal mp)
        {
            bool meetExists = false;
            foreach(MeetingProposal m in Server.meetingPropList)
            {
                if(m.Topic == mp.Topic)
                {
                    meetExists = true;
                }
            }
            if (!meetExists)
            {
                Server.meetingPropList.Add(mp);
            }
        }

        public void InformStateMeeting(MeetingProposal mp)
        {
            foreach(MeetingProposal meeting in Server.meetingPropList)
            {
                if(meeting.Topic == mp.Topic)
                {
                    meeting.Status = mp.Status;
                }
            }
        }

        public ConcurrentBag<Tuple<string, RemotingAddress>> GetClientsList()
        {
            ConcurrentBag<Tuple<string, RemotingAddress>> clients = new ConcurrentBag<Tuple<string, RemotingAddress>>();
            foreach(Client c in Server.clients)
            {
                clients.Add(new Tuple<string, RemotingAddress>(c.Username, c.ClientRA));
            }
            return clients;
        }

        public ConcurrentBag<MeetingProposal> GetMeetingPropList()
        {
            return Server.meetingPropList;
        }
    }
}
