using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

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
        List<MeetingProposal> meetingPropList;

        public Server()
        {
            this.meetingPropList = new List<MeetingProposal>();
        }

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

        public List<MeetingProposal> getMeetingPropList() { return this.meetingPropList; }
        public void addMeetingPropToList(MeetingProposal mp) { this.meetingPropList.Add(mp); }
    }

    class ServerServices : MarshalByRefObject, IServer
    {
        List<Client> clients;
        Server server;

        public ServerServices(Server serv)
        {
            this.clients = new List<Client>();
            this.server = serv;
        }

        public void closeMeeting(string topic)
        {
            throw new NotImplementedException();
        }

        public void createMeeting(string coordinatorURL, string topic, uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            this.server.addMeetingPropToList(new MeetingProposal(coordinatorURL, topic, minAttendees, slots, invitees));
        }

        public bool joinMeeting(string topic, string clientName, string clientURL)
        {
            foreach(MeetingProposal mp in this.server.getMeetingPropList())
            {
                if (mp.Topic == topic && mp.Invitees == null)
                {
                    mp.joinClientToMeeting(clientName, clientURL);
                    return true;
                }
                else
                {
                    foreach (string inv in mp.Invitees)
                    {
                        if (inv == clientName)
                        {
                            mp.joinClientToMeeting(clientName, clientURL);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public List<string> listMeetings(string clientName)
        {
            List<string> meetingsTopic = new List<string>();
            foreach(MeetingProposal mp in this.server.getMeetingPropList())
            {
                if(mp.Invitees == null)
                {
                    meetingsTopic.Add(mp.Topic);
                }
                else
                {
                    foreach(string inv in mp.Invitees)
                    {
                        if(inv == clientName)
                        {
                            meetingsTopic.Add(mp.Topic);
                        }
                    }
                }
            }
            return meetingsTopic;
        }

        public List<string> RegisterClient(int clientPort, string clientName, string clientURL)
        {
            IClient newClientChannel =
                (IClient)Activator.GetObject(
                    typeof(IClient), "tcp://localhost:" + clientPort + "/MSClient");
            Client newClient = new Client(newClientChannel, clientName, clientPort, clientURL);
            clients.Add(newClient);
            Console.WriteLine("New client " + clientName + " listenning at " + clientURL);

            //return messages;
            return null;
        }

        public void clientSaysHelloToServer(int clientPort)
        {
            //Find client in client list
            Client client = clients.First(item => item.ClientPort == clientPort);

            Console.WriteLine("Client: " + client.ClientName + " Port: " + client.ClientPort + " Says: Hello");

            //Server responds to that talked to him.
            //client.getClientChannel().serverRespondsHiToClient(server.getServerPort());

            //Server Broadcasts to all clients include client that talked to him.
            foreach(Client c in clients)
            {
                c.ClientChannel.serverRespondsHiToClient(server.getServerPort());
            }
        }
    }
}
