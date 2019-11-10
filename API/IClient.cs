using System;

namespace API
{    
    public interface IClient
    {
        void InformNewMeeting(MeetingProposal mp);
        void InformNewClient(string username);
        void InformJoinedMeeting(MeetingProposal mp, string username);
        void InformClosedMeeting(MeetingProposal mp);
    }
}
