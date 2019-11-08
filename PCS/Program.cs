using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using API;

namespace PCS
{
    class Program
    {
        public static RemotingAddress PCSRA = new RemotingAddress("localhost", 10000, "MSPCS");

        public static Dictionary<string, Process> clientProcesses = new Dictionary<string, Process>();
        public static Dictionary<string, Process> serverProcesses = new Dictionary<string, Process>();

        static void Main(string[] args)
        {
            ListenPCS();

            System.Console.WriteLine("<enter> to quit PCS...");
            System.Console.ReadLine();
        }

        private static void ListenPCS()
        {
            // https://stackoverflow.com/questions/527676/identifying-the-client-during-a-net-remoting-invocation
            BinaryServerFormatterSinkProvider bp = new BinaryServerFormatterSinkProvider();
            ClientIPServerSinkProvider csp = new ClientIPServerSinkProvider();
            csp.Next = bp;
            Hashtable ht = new Hashtable();
            ht.Add("port", PCSRA.port);
            TcpChannel pcsChannel = new TcpChannel(ht, null, csp);
            ChannelServices.RegisterChannel(pcsChannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PCSService),
                PCSRA.channel, WellKnownObjectMode.Singleton);
        }
    }

}
