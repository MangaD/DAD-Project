using System;
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
            //TODO: Check if this client is already in this server
            IClient cliChannel = (IClient)Activator.GetObject(typeof(IClient), newClientRA.ToString());
            Client newClient = new Client(cliChannel, newClientUsername, newClientRA);
            Server.clients.Add(newClient);
            
            cliChannel.RegisterServerReplica(Server.serverID, Server.serverRAForClients);
        }

        public void InformNewMeeting(MeetingProposal mp)
        {
            //TODO: Check if this meeting is already in this serverlist
            Server.meetingPropList.Add(mp);
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
    }
}
