using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

using API;

namespace PCS
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel pcsChannel = new TcpChannel(50000);
            ChannelServices.RegisterChannel(pcsChannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PCSServices),
             "MSPCS", WellKnownObjectMode.Singleton);
            System.Console.ReadLine();
        }
    }

    public class PCSServices : MarshalByRefObject, IPCS
    {
        public bool AddRoom(string location, uint capacity, string roomName)
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

        public bool StartClient(string username, string clientURL, string serverURL, string scriptFile)
        {
            //TODO
            Console.WriteLine("I (PCS) Will Start " + 5 + " Clients!");
            return true;
        }

        public bool StartServer(string serverId, string serverURL, uint maxFaults, uint minDelay, uint maxDelay)
        {
            //TODO
            Console.WriteLine("I (PCS) Will Start " + 5 + " Servers!");
            return true;
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
