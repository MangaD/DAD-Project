using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using API;

namespace Server
{
    public class Client
    {
        private IClient clientChannel;
        private string clientName;
        private int clientPort;
        private string clientURL;

        public Client(IClient clientChannel, string clientName, int clientPort, string clientURL)
        {
            this.ClientChannel = clientChannel;
            this.ClientName = clientName;
            this.ClientPort = clientPort;
            this.ClientURL = clientURL;
        }

        public IClient ClientChannel { get => clientChannel; set => clientChannel = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public int ClientPort { get => clientPort; set => clientPort = value; }
        public string ClientURL { get => clientURL; set => clientURL = value; }
    }
}
