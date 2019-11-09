using System;
using System.Collections.Generic;

namespace API
{
    //Clients must invoke methods to Servers here
    public interface IServerC
    {
        void RegisterClient(string username, string clientRA);
        List<MeetingProposal> ListMeetings(string clientName, bool excludeClosed, bool excludeJoined);
        MeetingProposal GetMeeting(string topic);
        void CreateMeeting(string coordinatorUser, RemotingAddress coordinatorRA, string topic, uint minAttendees,
            List<Slot> slots, List<string> invitees);
        void JoinMeeting(string topic, string clientName, RemotingAddress clientRA, List<Slot> locationDates);
        void CloseMeeting(string topic, string coordinatorURL);

        //Used to list Usernames to Invitee
        List<string> GetClientsUsername();
        //Used to client choose a location 
        List<string> GetLocations();

    }
}
