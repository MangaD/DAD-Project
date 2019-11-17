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
    }
}
