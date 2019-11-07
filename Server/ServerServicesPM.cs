using System;
using System.Collections.Generic;
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

        public void Ping()
        {
            // does nothing
        }
        public List<string> GetLocationsPM()
        {
            List<string> loc = new List<string>();
            foreach (string s in Server.locationRooms.Keys)
            {
                loc.Add(s);
            }
            return loc;
        }
    }
}
