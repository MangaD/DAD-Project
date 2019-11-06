using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using API;

namespace Server
{

    class Room
    {
        public Room(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
    }

    static class Server
    {
        public static List<MeetingProposal> meetingPropList = new List<MeetingProposal>();
        public static List<Client> clients = new List<Client>();
        public static Dictionary<string, List<Room>> locationRooms = new Dictionary<string, List<Room>>();

        public static TcpChannel servChannel;
        public static RemotingAddress serverRA;

        static void Main(string[] args)
        {

            if (args.Length != 5)
            {
                string error = "This program must take 5 arguments. " +
                    "server id, server remoting address, max. faults, " +
                    "min delay, max delay.";
                Utilities.WriteError(error);
                return;
            }

            GenerateLocationRooms();

            string serverID = args[0];
            serverRA = RemotingAddress.FromString(args[1]);
            uint maxFaults = Convert.ToUInt32(args[2]);
            uint minDelay = Convert.ToUInt32(args[3]);
            uint maxDelay = Convert.ToUInt32(args[4]);

            ListenServer();

            Console.WriteLine("Press <enter> to terminate server...");
            System.Console.ReadLine();
        }

        public static void ListenServer()
        {
            servChannel = new TcpChannel((int)serverRA.port);
            ChannelServices.RegisterChannel(servChannel, false);
            //ServerServices servObj = new ServerServices(this);
            //RemotingServices.Marshal(servObj, serverRA.channel, typeof(ServerServices));
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServerServices),
                serverRA.channel, WellKnownObjectMode.Singleton);
        }

        public static void GenerateLocationRooms()
        {
            List<Room> LisboaRooms = new List<Room>();
            LisboaRooms.Add(new Room("A", 5));
            LisboaRooms.Add(new Room("B", 8));
            LisboaRooms.Add(new Room("C", 3));
            locationRooms.Add("Lisboa", LisboaRooms);

            List<Room> PortoRooms = new List<Room>();
            LisboaRooms.Add(new Room("D", 9));
            LisboaRooms.Add(new Room("E", 10));
            LisboaRooms.Add(new Room("F", 15));
            locationRooms.Add("Porto", PortoRooms);

            List<Room> LeiriaRooms = new List<Room>();
            LisboaRooms.Add(new Room("G", 20));
            LisboaRooms.Add(new Room("H", 25));
            LisboaRooms.Add(new Room("I", 5));
            locationRooms.Add("Leiria", LeiriaRooms);

            List<Room> CoimbraRooms = new List<Room>();
            LisboaRooms.Add(new Room("J", 12));
            LisboaRooms.Add(new Room("K", 7));
            LisboaRooms.Add(new Room("L", 5));
            locationRooms.Add("Coimbra", CoimbraRooms);

            List<Room> AveiroRooms = new List<Room>();
            LisboaRooms.Add(new Room("M", 22));
            LisboaRooms.Add(new Room("N", 17));
            LisboaRooms.Add(new Room("O", 15));
            locationRooms.Add("Aveiro", AveiroRooms);
        }
    }
}
