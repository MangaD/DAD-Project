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
        private static IServer server;

        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Utilities.WriteError("This program may only take 1 argument, which is the file name of a client script.");
                Console.ReadKey();
                return;
            }

            string filename = args[0];

            // Get client port and name
            Console.WriteLine("Insert PORT: ");
            int cliPort = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert Name: ");
            string cliName = Console.ReadLine();

            // Connect to server
            server = (IServer)Activator.GetObject(typeof(IServer), "tcp://localhost:65000/MSServer");
            //List<string> messages = server.RegisterClient(port.ToString());
            server.RegisterClient(cliPort, cliName);

            Parser parser = new Parser(filename, server);
            parser.Parse();


            TcpChannel channel = new TcpChannel(cliPort);
            ChannelServices.RegisterChannel(channel, false);
            ClientServices services = new ClientServices();
            RemotingServices.Marshal(services, "MSClient",
                typeof(ClientServices));

            server.clientSaysHelloToServer(cliPort);


            //RunCommands();

            Console.ReadKey();
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
