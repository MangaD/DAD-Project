using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading;

using API;

namespace Client
{
    class Program
    {

        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Utilities.WriteError("This program may only take 1 argument, which is the file name of a client script.");
                Console.ReadKey();
                return;
            }

            string filename = args[0];

            Parser parser = new Parser(filename);
            parser.Parse();

            Console.WriteLine("Insert PORT: ");
            int cliPort = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert Name: ");
            string cliName = Console.ReadLine();

            Client client = new Client(cliPort, cliName);
            TcpChannel cliChannel = client.ClientListening();
            client.clientSaysHello();


            //RunCommands();

            Console.ReadKey();
        }
               

    }

    public class Client
    {
        //public const int CLIENT_PORT = 55001;
        //public const string CLIENT_NAME = "LEO";
        private int clientPort;
        private string clientName;
        private TcpChannel cliChannel;
        private static IServer server;

        public Client(int cp, string cn)
        {
            this.clientPort = cp;
            this.clientName = cn;
        }

        public TcpChannel ClientListening() {
            TcpChannel channel = new TcpChannel(clientPort);
            ChannelServices.RegisterChannel(channel, false);
            ClientServices services = new ClientServices();
            RemotingServices.Marshal(services, "MSClient",
                typeof(ClientServices));

            server = (IServer)Activator.GetObject(typeof(IServer), "tcp://localhost:65000/MSServer");
            //List<string> messages = server.RegisterClient(port.ToString());
            server.RegisterClient(clientPort, clientName);
            this.cliChannel = channel;

            return channel;
        }

        public void clientSaysHello()
        {
            server.clientSaysHelloToServer(clientPort);
        }

    }

    public class ClientServices : MarshalByRefObject, IClient
    {

        public ClientServices()
        {
        }

        public void serverRespondsHiToClient(int serverPort)
        {
            Console.WriteLine("Server: " + serverPort + " Responded Hi");
        }
    }
}
