using API;

namespace Server
{
    public class Client
    {
        RemotingAddress clientRA;

        public Client(IClient clientChannel, string clientName, RemotingAddress clientRA)
        {
            this.ClientChannel = clientChannel;
            this.ClientName = clientName;
            this.ClientRA = clientRA;
        }

        public IClient ClientChannel { get; set; }
        public string ClientName { get; set; }
        public RemotingAddress ClientRA { get => clientRA; set => clientRA = value; }
    }
}
