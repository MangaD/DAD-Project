using System;
using System.Collections.Generic;
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
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServerServicesC),
                serverRA.channel, WellKnownObjectMode.Singleton);
        }
    }
}
