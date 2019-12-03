using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using API;

namespace Server
{
    class OtherServer
    {
        RemotingAddress serverRA;

        public OtherServer(IServerS serverChannel, string serverID, RemotingAddress serverRA)
        {
            this.ServerChannel = serverChannel;
            this.ServerID = serverID;
            this.ServerRA = serverRA;
        }

        public IServerS ServerChannel { get; set; }
        public string ServerID { get; set; }
        public RemotingAddress ServerRA { get => serverRA; set => serverRA = value; }
    }
}
