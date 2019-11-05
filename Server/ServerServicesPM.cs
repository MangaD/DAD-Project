using System;

using API;

namespace Server
{
    partial class ServerServices : MarshalByRefObject, IServerPM
    {
        public void AddRoom(string location, uint capacity, string roomName)
        {
            throw new NotImplementedException();
        }

        public string SystemStatus()
        {
            throw new NotImplementedException();
        }

        public void Crash()
        {
            throw new NotImplementedException();
        }

        public void Freeze()
        {
            throw new NotImplementedException();
        }

        public void Unfreeze()
        {
            throw new NotImplementedException();
        }
    }
}
