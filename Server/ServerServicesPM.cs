using System;

using API;

namespace Server
{
    partial class ServerServices : MarshalByRefObject, IServerPM
    {
        public void AddRoom(string location, uint capacity, string roomName)
        {
            Server.AddRoom(location, capacity, roomName);
        }

        public string SystemStatus()
        {
            throw new NotImplementedException();
        }

        public void Crash()
        {
            Environment.Exit(0);
        }

        public void Freeze()
        {
            Server.freezeHandle.Reset();
        }

        public void Unfreeze()
        {
            Server.freezeHandle.Set();
        }
    }
}
