using System;

namespace API
{    
    public interface IClient
    {
        void InformNewMeeting(MeetingProposal mp);
        void InformNewClient(string username);
    }
}
