using System;

using API;

namespace Server
{
    partial class ServerServices : MarshalByRefObject, IServerS
    {
        public void InformClientJoinedMeeting(MeetingProposal mp, string username)
        {
            //TODO
        }

        public void InformNewClient(IClient newClientChannel, string newClientUsername, RemotingAddress newCLientRA)
        {
            //TODO: Check if this client is already in this server
            Client newClient = new Client(newClientChannel, newClientUsername, newCLientRA);
            Server.clients.Add(newClient);

            //TODO: Connect this server to client
        }

        public void InformNewMeeting(MeetingProposal mp)
        {
            //TODO
        }

        public void InformStateMeeting(MeetingProposal mp, MeetingProposal.StatusEnum status)
        {
            // TODO take out of closed combobox
        }
    }
}
