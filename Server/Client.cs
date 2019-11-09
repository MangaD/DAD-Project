using API;

namespace Server
{
    public class Client
    {
        RemotingAddress clientRA;

        public Client(IClient clientChannel, string username, RemotingAddress clientRA)
        {
            this.ClientChannel = clientChannel;
            this.Username = username;
            this.ClientRA = clientRA;
        }

        public IClient ClientChannel { get; set; }
        public string Username { get; set; }
        public RemotingAddress ClientRA { get => clientRA; set => clientRA = value; }
    }
}
