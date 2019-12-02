using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using API;

namespace Server
{
    class OtherServers
    {
        RemotingAddress serverRA;

        public OtherServers(IServerS serverChannel, string username, RemotingAddress serverRA)
        {
            this.ServerChannel = serverChannel;
            this.Username = username;
            this.ServerRA = serverRA;
        }

        public IServerS ServerChannel { get; set; }
        public string Username { get; set; }
        public RemotingAddress ServerRA { get => serverRA; set => serverRA = value; }
    }
}
