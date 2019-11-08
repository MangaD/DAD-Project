using System;
using System.Collections.Generic;

namespace API
{
    //Clients must invoke methods to Servers here
    public interface IServerC
    {
        List<string> RegisterClient(string clientName, string clientRA);
        List<MeetingProposal> ListMeetings(string clientName);
        MeetingProposal GetMeeting(string topic);
        void CreateMeeting(string coordinatorUser, string coordinatorURL, string topic, uint minAttendees,
            List<Slot> slots, List<string> invitees);
        void JoinMeeting(string topic, string clientName, string clientRA, int n_slots, List<Slot> locationDates);
        bool CloseMeeting(string topic, string coordinatorURL);

        //Used to list Usernames to Invitee
        List<string> GetClientsUsername();
        //Used to client choose a location 
        List<string> GetLocations();

    }
}
