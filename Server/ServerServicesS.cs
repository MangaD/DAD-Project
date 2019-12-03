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

        public void InformNewClient(string newClientUsername, RemotingAddress newClientRA)
        {
            //TODO: Check if this client is already in this server
            IClient cliChannel = (IClient)Activator.GetObject(typeof(IClient), newClientRA.ToString());
            Client newClient = new Client(cliChannel, newClientUsername, newClientRA);
            Server.clients.Add(newClient);
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
