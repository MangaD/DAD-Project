using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace API
{
    //Servers must invoke methods to ohter Servers here
    public interface IServerS
    {
        void InformNewMeeting(MeetingProposal mp);
        void InformNewClient(string newClientUsername, RemotingAddress newClientRA);
        void InformClientJoinedMeeting(MeetingProposal mp, string clientName,
            RemotingAddress clientRA, List<Slot> slots);
        void InformStateMeeting(MeetingProposal mp);

        ConcurrentBag<MeetingProposal> GetMeetingPropList();
        ConcurrentBag<Tuple<string, RemotingAddress>> GetClientsList();
    }
}
