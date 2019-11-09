using System;

namespace API
{    
    public interface IClient
    {
        void InformNewMeeting(string topic);
        void InformNewClient(string username);
    }
}
