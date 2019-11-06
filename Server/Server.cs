using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using API;

namespace Server
{

    static class Server
    {
        public static List<MeetingProposal> meetingPropList = new List<MeetingProposal>();
        public static List<Client> clients = new List<Client>();
        public static Dictionary<string, List<Room>> locationRooms = new Dictionary<string, List<Room>>();

        public static TcpChannel servChannel;
        public static RemotingAddress serverRA;

        public static readonly EventWaitHandle freezeHandle = new EventWaitHandle(true, EventResetMode.ManualReset);

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
            LisboaRooms.Add(new Room("A", 5));
            LisboaRooms.Add(new Room("B", 8));
            LisboaRooms.Add(new Room("C", 3));
            locationRooms.Add("Lisboa", LisboaRooms);

            List<Room> PortoRooms = new List<Room>();
            PortoRooms.Add(new Room("D", 9));
            PortoRooms.Add(new Room("E", 10));
            PortoRooms.Add(new Room("F", 15));
            locationRooms.Add("Porto", PortoRooms);

            List<Room> LeiriaRooms = new List<Room>();
            LeiriaRooms.Add(new Room("G", 20));
            LeiriaRooms.Add(new Room("H", 25));
            LeiriaRooms.Add(new Room("I", 5));
            locationRooms.Add("Leiria", LeiriaRooms);

            List<Room> CoimbraRooms = new List<Room>();
            CoimbraRooms.Add(new Room("J", 12));
            CoimbraRooms.Add(new Room("K", 7));
            CoimbraRooms.Add(new Room("L", 5));
            locationRooms.Add("Coimbra", CoimbraRooms);

            List<Room> AveiroRooms = new List<Room>();
            AveiroRooms.Add(new Room("M", 22));
            AveiroRooms.Add(new Room("N", 17));
            AveiroRooms.Add(new Room("O", 15));
            locationRooms.Add("Aveiro", AveiroRooms);
        }
    }
}
