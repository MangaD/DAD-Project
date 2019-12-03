using System;

namespace API
{    
    public interface IClient
    {
        void InformNewMeeting(MeetingProposal mp);
        void InformNewClient(string username);
        void InformClientJoinedMeeting(MeetingProposal mp, string username);
        void InformStateMeeting(MeetingProposal mp, MeetingProposal.StatusEnum status);


        void RegisterServerReplica(string serverID, RemotingAddress serverRA);
    }
}
