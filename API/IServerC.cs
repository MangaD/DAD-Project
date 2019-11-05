using System;
using System.Collections.Generic;

namespace API
{
    //Clients must invoke methods to Servers here
    public interface IServerC
    {
        List<string> RegisterClient(string clientName, string clientRA);
        List<string> ListMeetings(string clientName);
        void CreateMeeting(string coordinatorURL, string topic, uint minAttendees,
            List<Slot> slots, List<string> invitees);
        bool JoinMeeting(string topic, string clientName, string clientRA, int n_slots, List<Slot> locationDates);
        bool CloseMeeting(string topic, string coordinatorURL);

        //Used to list Usernames to Invitee
        List<string> GetClientsUsername();

        //Metodos de Teste
        void ClientSaysHelloToServer(UInt16 clientPort);

    }
}
