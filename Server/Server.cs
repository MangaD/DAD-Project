using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using API;

namespace Server
{

    static class Server
    {
        static List<MeetingProposal> meetingPropList = new List<MeetingProposal>();
        static List<Client> clients = new List<Client>();

        static RemotingAddress serverRA;

        static void Main(string[] args)
        {
            string serverID = args[0];
            serverRA = RemotingAddress.FromString(args[1]);
            uint maxFaults = Convert.ToUInt32(args[2]);
            uint minDelay = Convert.ToUInt32(args[3]);
            uint maxDelay = Convert.ToUInt32(args[4]);

            TcpChannel servChannel = new TcpChannel((int)serverRA.port);
            ChannelServices.RegisterChannel(servChannel, false);
            //ServerServices servObj = new ServerServices(this);
            //RemotingServices.Marshal(servObj, "MSServer", typeof(ServerServices));
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServerServices),
             "MSServer", WellKnownObjectMode.Singleton);

            Console.WriteLine("Press <enter> to terminate server...");
            System.Console.ReadLine();
        }

        static public List<MeetingProposal> getMeetingPropList() { return meetingPropList; }
        static public void addMeetingPropToList(MeetingProposal mp) { meetingPropList.Add(mp); }
        static public List<Client> getClientsList() { return clients; }
        static public UInt16 getServerPort() { return serverRA.port; }
    }
}
