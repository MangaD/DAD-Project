using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

using API;

namespace Server
{

    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            TcpChannel servChannel = server.ServerListening();
            System.Console.WriteLine("Press <enter> to terminate server...");
            System.Console.ReadLine();
        }
    }

    public class Server
    {
        public const int SERVER_PORT = 65000;
        TcpChannel servChannel;

        public TcpChannel ServerListening()
        {
            TcpChannel channel = new TcpChannel(SERVER_PORT);
            ChannelServices.RegisterChannel(channel, false);
            //RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServerServices),
            // "MSServer", WellKnownObjectMode.Singleton);
            ServerServices servObj = new ServerServices(this);
            RemotingServices.Marshal(servObj, "MSServer", typeof(ServerServices));
            servChannel = channel;

            return channel;
        }

        public int getServerPort()
        {
            return SERVER_PORT;
        }
    }

    class ServerServices : MarshalByRefObject, IServer
    {
        List<Cli> clients;
        Server server;

        public ServerServices(Server serv)
        {
            this.clients = new List<Cli>();
            this.server = serv;
        }

        public void closeMeeting(string topic)
        {
            throw new NotImplementedException();
        }

        public void createMeeting(string topic, uint minAttendees, List<KeyValuePair<string, DateTime>> slots, List<string> invitees)
        {
            throw new NotImplementedException();
        }

        public void joinMeeting(string topic)
        {
            throw new NotImplementedException();
        }

        public List<string> listMeetings()
        {
            throw new NotImplementedException();
        }

        public List<string> RegisterClient(int clientPort, string clientName)
        {
            IClient newClientChannel =
                (IClient)Activator.GetObject(
                    typeof(IClient), "tcp://localhost:" + clientPort + "/MSClient");
            Cli newClient = new Cli(newClientChannel, clientName, clientPort);
            clients.Add(newClient);
            Console.WriteLine("New client " + clientName + " listenning at " + "tcp://localhost:" + clientPort + "/MSClient");

            //return messages;
            return null;
        }

        public void clientSaysHelloToServer(int clientPort)
        {
            //Find client in client list
            Cli client = clients.First(item => item.getClientPort() == clientPort);

            Console.WriteLine("Client: " + client.getClientName() + " Port: " + client.getClientPort() + " Says: Hello");

            //Server responds to that talked to him.
            //client.getClientChannel().serverRespondsHiToClient(server.getServerPort());

            //Server Broadcasts to all clients include client that talked to him.
            foreach(Cli c in clients)
            {
                c.getClientChannel().serverRespondsHiToClient(server.getServerPort());
            }
        }
    }

    public class Cli
    {
        IClient clientChannel;
        string clientName;
        int clientPort;
        //....

        public Cli(IClient cc, string cn, int cp)
        {
            this.clientChannel = cc;
            this.clientName = cn;
            this.clientPort = cp;
        }

        public IClient getClientChannel()
        {
            return this.clientChannel;
        }

        public string getClientName()
        {
            return this.clientName;
        }

        public int getClientPort()
        {
            return this.clientPort;
        }
    }

}
