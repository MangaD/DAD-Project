using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using API;
using System.Collections.Concurrent;

namespace Server
{
    static class Server
    {
        public static string serverID;
        public static int maxFaults;
        public static int minDelay;
        public static int maxDelay;

        /*for replication
        public static RemotingAddress serverRAForServers;
        public static int otherServers;
        public static ConcurrentDictionary<RemotingAddress, IServerS> otherServerList = new ConcurrentDictionary<RemotingAddress, IServerS>();
        public static IServerS serversRepl; */

        public static ConcurrentBag<MeetingProposal> meetingPropList = new ConcurrentBag<MeetingProposal>();
        public static ConcurrentBag<Client> clients = new ConcurrentBag<Client>();
        public static ConcurrentDictionary<string, List<Room>> locationRooms = new ConcurrentDictionary<string, List<Room>>();

        public static TcpChannel servChannel;
        public static RemotingAddress serverRAForClients;

        /**
         * https://stackoverflow.com/questions/29089417/c-sharp-wait-until-condition-is-true
         * https://www.c-sharpcorner.com/article/thread-synchronization-signaling-constructs-with-eventwaithandle-in-c-sharp/
         */
        public static readonly EventWaitHandle freezeHandle = new EventWaitHandle(true, EventResetMode.ManualReset);

        static void Main(string[] args)
        {

            if (args.Length != 5)
            {
                string err = "This program must take 6+ arguments. " +
                    "server id, server remoting address, max. faults, " +
                    "min delay, max delay, number of known servers, known servers addresses.";
                Utilities.WriteError(err);
                return;
            }

            serverID = args[0];
            serverRAForClients = RemotingAddress.FromString(args[1]);
            maxFaults = Convert.ToInt32(args[2]);
            minDelay = Convert.ToInt32(args[3]);
            maxDelay = Convert.ToInt32(args[4]);

            /* TODO
            serverRAForServers = RemotingAddress.FromString(args[1]);
            serverRAForServers.channel += "Repl";
            otherServers = Convert.ToInt32(args[5]);

            for (int nOtherServer = 0; nOtherServer < otherServers; nOtherServer++)
            {
                RemotingAddress otherServer = RemotingAddress.FromString(args[6 + nOtherServer]);
                otherServerList.Add(otherServer, (IServerS)Activator.GetObject(typeof(IServerC), otherServer.ToString()));
            }
            */

            string error = "";
            if (maxFaults < 0)
            {
                error = "Max. faults cannot be less than 0.";
            }
            else if (minDelay < 0)
            {
                error = "Min. delay cannot be less than 0.";
            }
            else if (maxDelay < 0)
            {
                error = "Max. delay cannot be less than 0.";
            }
            else if (minDelay > maxDelay)
            {
                error = "Min. delay cannot be bigger than max. delay.";
            }
            if (error != "")
            {
                Utilities.WriteError(error);
                return;
            }

            GenerateLocationRooms();

            ListenServer();

            Console.WriteLine("Press <enter> to terminate server...");
            System.Console.ReadLine();
        }

        public static void ListenServer()
        {
            servChannel = new TcpChannel((int)serverRAForClients.port);
            ChannelServices.RegisterChannel(servChannel, false);
            //ServerServices servObj = new ServerServices(this);
            //RemotingServices.Marshal(servObj, serverRA.channel, typeof(ServerServices));
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServerServices),
                serverRAForClients.channel, WellKnownObjectMode.Singleton);
            
            /*
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServerServicesS),
                serverRAForServers.channel, WellKnownObjectMode.Singleton); */
        }

        public static void PrintStatus()
        {
            Console.WriteLine("BEGIN Server Status");
            
            Console.WriteLine(" Connected Clients:");
            foreach (Client c in clients)
            {
                Console.WriteLine($"    Client '{c.Username}' is connected to this server on '{c.ClientRA.ToString()}'.");
            }

            Console.WriteLine(" Stored Meeting Proposals:");
            foreach (MeetingProposal mp in meetingPropList)
            {
                Console.WriteLine($"    Server has meeting '{mp.Topic}' which is {mp.Status}:");
                switch (mp.Status)
                {
                    case MeetingProposal.StatusEnum.Open:
                        foreach (string c in mp.ClientsJoined.Keys)
                        {
                            Console.WriteLine($"        Client '{c}' is joined.");
                        }
                        break;
                    case MeetingProposal.StatusEnum.Closed:
                        foreach (string c in mp.ClientsAccepted.Keys)
                        {
                            Console.WriteLine($"        Client '{c}' was accepted.");
                        }
                        Console.WriteLine($"        The chosen slot was '{mp.BookedSlot.ToString()}'");
                        Console.WriteLine($"        The chosen room was '{mp.BookedRoom.Name}'");
                        break;
                }
            }
            Console.WriteLine("END Server Status");
        }

        public static void AddRoom(string location, uint capacity, string roomName)
        {
            if (!locationRooms.ContainsKey(location))
            {
                throw new ApplicationException($"Location '{location}' does not exist.");
            }

            locationRooms[location].Add(new Room(roomName, capacity));

            Console.WriteLine($"Room '{roomName}' with capacity of {capacity} added to location '{location}'.");
        }

        public static void GenerateLocationRooms()
        {
            List<Room> LisboaRooms = new List<Room>();
            //LisboaRooms.Add(new Room("A", 5));
            //LisboaRooms.Add(new Room("B", 8));
            //LisboaRooms.Add(new Room("C", 3));

            LisboaRooms.Add(new Room("room1", 2));
            locationRooms.GetOrAdd("Lisboa", LisboaRooms);

            List<Room> PortoRooms = new List<Room>();
            //PortoRooms.Add(new Room("D", 9));
            //PortoRooms.Add(new Room("E", 10));
            //PortoRooms.Add(new Room("F", 15));

            PortoRooms.Add(new Room("room2", 1));
            locationRooms.GetOrAdd("Porto", PortoRooms);

            List<Room> LeiriaRooms = new List<Room>();
            LeiriaRooms.Add(new Room("G", 20));
            LeiriaRooms.Add(new Room("H", 25));
            LeiriaRooms.Add(new Room("I", 5));
            locationRooms.GetOrAdd("Leiria", LeiriaRooms);

            List<Room> CoimbraRooms = new List<Room>();
            CoimbraRooms.Add(new Room("J", 12));
            CoimbraRooms.Add(new Room("K", 7));
            CoimbraRooms.Add(new Room("L", 5));
            locationRooms.GetOrAdd("Coimbra", CoimbraRooms);

            List<Room> AveiroRooms = new List<Room>();
            AveiroRooms.Add(new Room("M", 22));
            AveiroRooms.Add(new Room("N", 17));
            AveiroRooms.Add(new Room("O", 15));
            locationRooms.GetOrAdd("Aveiro", AveiroRooms);
        }

        public static int GetRandomDelay()
        {
            Random rnd = new Random();
            return rnd.Next(minDelay, maxDelay+1);
        }

        public static void InformClientsOfNewMeeting(MeetingProposal mp)
        {
            foreach (var c in clients)
            {
                if (mp.Invitees.Count == 0 ||
                    mp.CoordinatorUsername == c.Username ||
                    mp.Invitees.Contains(c.Username))
                {
                    c.ClientChannel.InformNewMeeting(mp);
                }
            }
        }

        public static void InformAllClientsOfNewClient(string username)
        {
            foreach (var c in clients)
            {
                c.ClientChannel.InformNewClient(username);
            }
        }

        public static void InformAllClientsOfJoinedMeeting(MeetingProposal mp, string username)
        {
            foreach (var c in clients)
            {
                if (mp.Invitees.Count == 0 ||
                    mp.CoordinatorUsername == c.Username ||
                    mp.Invitees.Contains(c.Username))
                {
                    c.ClientChannel.InformClientJoinedMeeting(mp, username);
                }
            }
        }

        public static void InformAllClientsOfMeetingState(MeetingProposal mp)
        {
            foreach (var c in clients)
            {
                if (mp.Invitees.Count == 0 ||
                    mp.CoordinatorUsername == c.Username ||
                    mp.Invitees.Contains(c.Username))
                {
                    c.ClientChannel.InformStateMeeting(mp, mp.Status);
                }
            }
        }
    }
}
