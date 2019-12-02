namespace API
{
    //Servers must invoke methods to ohter Servers here
    public interface IServerS
    {
        void InformNewMeeting(MeetingProposal mp);
        void InformNewClient(IClient newClientChannel, string newClientUsername, RemotingAddress newCLientRA);
        void InformClientJoinedMeeting(MeetingProposal mp, string username);
        void InformStateMeeting(MeetingProposal mp, MeetingProposal.StatusEnum status);
    }
}
