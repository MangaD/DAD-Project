using System.Collections.Generic;

namespace API
{
    //PuppetMaster must invoke methods to Servers here
    public interface IServerPM
    {
        void AddRoom(string location, uint capacity, string roomName);
        string SystemStatus();
        void Crash();
        void Freeze();
        void Unfreeze();

        List<string> GetLocationsPM();
    }
}
