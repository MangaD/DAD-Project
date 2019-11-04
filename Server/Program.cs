﻿using System;
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
            string serverID = args[0];
            RemotingAddress serverRA = RemotingAddress.FromString(args[1]);
            uint maxFaults = Convert.ToUInt32(args[2]);
            uint minDelay = Convert.ToUInt32(args[3]);
            uint maxDelay = Convert.ToUInt32(args[4]);

            Server server = new Server(serverID, serverRA, maxFaults, minDelay, maxDelay);

            TcpChannel servChannel = server.ServerListening();

            Console.WriteLine("Press <enter> to terminate server...");
            System.Console.ReadLine();
        }
    }

    public class Server
    {
        TcpChannel servChannel;
        List<MeetingProposal> meetingPropList;

        private string serverID;
        private RemotingAddress serverRA;
        private uint maxFaults;
        private uint minDelay;
        private uint maxDelay;

        public Server(string id, RemotingAddress serverRA, uint maxFaults,
            uint minDelay, uint maxDelay)
        {
            this.serverID = id;
            this.serverRA = serverRA;
            this.maxFaults = maxFaults;
            this.minDelay = minDelay;
            this.maxDelay = maxDelay;

            this.meetingPropList = new List<MeetingProposal>();
        }

        public TcpChannel ServerListening()
        {
            TcpChannel channel = new TcpChannel((int)serverRA.port);
            ChannelServices.RegisterChannel(channel, false);
            //RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServerServices),
            // "MSServer", WellKnownObjectMode.Singleton);
            ServerServices servObj = new ServerServices(this);
            RemotingServices.Marshal(servObj, "MSServer", typeof(ServerServices));
            servChannel = channel;

            return channel;
        }

        public UInt16 getServerPort()
        {
            return serverRA.port;
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

        public bool CloseMeeting(string topic, string coordinatorURL)
        {
            foreach (MeetingProposal mp in this.server.getMeetingPropList())
            {
                if(mp.Topic == topic && mp.CoodinatorURL == coordinatorURL && mp.State == 0)
                {
                    mp.State = 1;
                    return true;
                }
            }
            return false;
        }

        public void CreateMeeting(string coordinatorURL, string topic, uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            this.server.addMeetingPropToList(new MeetingProposal(coordinatorURL, topic, minAttendees, slots, invitees));

            Console.WriteLine("[Server] Criei a Meeting! CoordinatorURL: " + coordinatorURL);
        }

        public bool JoinMeeting(string topic, string clientName, string clientRA, int n_slots, List<Slot> locationDates)
        {
            foreach(MeetingProposal mp in this.server.getMeetingPropList())
            {
                if (mp.Topic == topic && mp.Invitees == null && mp.State == 0)
                {
                    mp.joinClientToMeeting(clientName, clientRA, n_slots, locationDates);
                    return true;
                }
                else
                {
                    foreach (string inv in mp.Invitees)
                    {
                        if (inv == clientName && mp.State == 0)
                        {
                            mp.joinClientToMeeting(clientName, clientRA, n_slots, locationDates);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public List<string> ListMeetings(string clientName)
        {
            List<string> meetingsTopic = new List<string>();
            foreach(MeetingProposal mp in this.server.getMeetingPropList())
            {
                if(mp.Invitees == null && mp.State == 0)
                {
                    meetingsTopic.Add(mp.Topic);
                }
                else
                {
                    foreach(string inv in mp.Invitees)
                    {
                        if(inv == clientName && mp.State == 0)
                        {
                            meetingsTopic.Add(mp.Topic);
                        }
                    }
                }
            }
            return meetingsTopic;
        }

        public List<string> RegisterClient(string clientName, string clientRA)
        {
            IClient newClientChannel =
                (IClient)Activator.GetObject(
                    typeof(IClient), clientRA);
            Client newClient = new Client(newClientChannel, clientName, RemotingAddress.FromString(clientRA));
            clients.Add(newClient);
            Console.WriteLine("New client " + clientName + " listenning at " + clientRA);

            //return messages;
            return null;
        }

        public void ClientSaysHelloToServer(UInt16 clientPort)
        {
            //Find client in client list
            Client client = clients.First(item => item.ClientRA.port == clientPort);

            Console.WriteLine("Client: " + client.ClientName + " Port: " + client.ClientRA.port + " Says: Hello");

            //Server responds to that talked to him.
            //client.getClientChannel().serverRespondsHiToClient(server.getServerPort());

            //Server Broadcasts to all clients include client that talked to him.
            foreach(Client c in clients)
            {
                c.ClientChannel.ServerRespondsHiToClient(server.getServerPort());
            }
        }
    }
}
