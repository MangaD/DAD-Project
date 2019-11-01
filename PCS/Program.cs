using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using API;

namespace PCS
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel pcsChannel = new TcpChannel(10000);
            ChannelServices.RegisterChannel(pcsChannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PCSServices),
             "MSPCS", WellKnownObjectMode.Singleton);
            System.Console.ReadLine();
        }
    }

    public class PCSServices : MarshalByRefObject, IPCS
    {
        public void AddRoom(string location, uint capacity, string roomName)
        {
            throw new NotImplementedException();
        }

        public void Crash(string id)
        {
            throw new NotImplementedException();
        }

        public void Freeze(string id)
        {
            throw new NotImplementedException();
        }

        public void StartClient(string username, RemotingAddress clientRA, RemotingAddress serverRA, string scriptFile)
        {
            throw new NotImplementedException();
        }

        public void StartServer(string serverId, RemotingAddress serverRA, uint maxFaults, uint minDelay, uint maxDelay)
        {
            throw new NotImplementedException();
        }

        public string SystemStatus()
        {
            throw new NotImplementedException();
        }

        public void Unfreeze(string id)
        {
            throw new NotImplementedException();
        }
    }
}
