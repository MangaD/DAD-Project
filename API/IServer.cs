using System;
using System.Collections.Generic;

namespace API
{
    public interface IServer
    {
        List<string> RegisterClient(string clientName, string clientRA);
        List<string> ListMeetings(string clientName);
        void CreateMeeting(string coordinatorURL, string topic, uint minAttendees,
            List<Slot> slots, List<string> invitees);
        bool JoinMeeting(string topic, string clientName, string clientRA);
        void CloseMeeting(string topic);

        //Metodos de Teste
        void ClientSaysHelloToServer(UInt16 clientPort);

    }
}
