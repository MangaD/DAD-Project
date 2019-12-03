using System;
using System.Collections.Generic;

namespace API
{
    //PuppetMaster must invoke methods to Servers here
    public interface IServerPM
    {
        void AddRoom(string location, uint capacity, string roomName);
        void SystemStatus();
        void Crash();
        void Freeze();
        void Unfreeze();
        void Ping();

        List<string> GetLocationsPM();


        //Replication methods
        //Imform new server of all existing servers
        void SendExistingServersList(List<Tuple<string, RemotingAddress>> serverList);
        void BroadcastNewServer(Tuple<string, RemotingAddress> newServer);
    }
}
