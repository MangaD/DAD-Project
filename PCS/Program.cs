using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using API;

namespace PCS
{
    class Program
    {
        private static UInt16 PCSPort = 10000;
        private static string PCSChannel = "MSPCS";

        static void Main(string[] args)
        {
            TcpChannel pcsChannel = new TcpChannel(PCSPort);
            ChannelServices.RegisterChannel(pcsChannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PCSServices),
                PCSChannel, WellKnownObjectMode.Singleton);

            System.Console.WriteLine("<enter> to quit...");
            System.Console.ReadLine();
        }
    }

    public class PCSServices : MarshalByRefObject, IPCS
    {
        public void AddRoom(string location, uint capacity, string roomName)
        {
            throw new NotImplementedRemotingException();
        }

        public void Crash(string id)
        {
            throw new NotImplementedRemotingException();
        }

        public void Freeze(string id)
        {
            throw new NotImplementedRemotingException();
        }

        public void StartClient(string username, RemotingAddress clientRA, RemotingAddress serverRA, string scriptFile)
        {
            throw new NotImplementedRemotingException();
        }

        public void StartServer(string serverId, RemotingAddress serverRA, uint maxFaults, uint minDelay, uint maxDelay)
        {
            throw new NotImplementedRemotingException();
        }

        public string SystemStatus()
        {
            throw new NotImplementedRemotingException();
        }

        public void Unfreeze(string id)
        {
            throw new NotImplementedRemotingException();
        }
    }
}
