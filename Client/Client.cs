using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using API;

namespace MSDAD_CLI
{
    class Client
    {
        private static TcpChannel clientChannel;
        private static IServer server;

        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Utilities.WriteError("This program may only take 1 argument, which is the file name of a client script.");
                Console.ReadKey();
                return;
            }

            string scriptFilename = args[0];
            UInt16 clientPort = (UInt16) Convert.ToInt32(args[1]);
            string clientName = args[2];
            UInt16 serverPort = (UInt16)Convert.ToInt32(args[3]);

            listenClient(clientPort, "MSClient");
            connectToServer("localhost", serverPort, "MSServer", clientPort, clientName);

            Parser parser = new Parser(scriptFilename, server);
            parser.Parse();

            server.clientSaysHelloToServer(clientPort);

            //parser.ExecCommands();

            Console.ReadKey();
        }

        private static void connectToServer(string address, UInt16 serverPort, string serverChannelName,
            UInt16 clientPort, string clientName)
        {
            server = (IServer)Activator.GetObject(typeof(IServer), "tcp://" + address + ":" + serverPort + "/" + serverChannelName);
            server.RegisterClient(clientPort, clientName);
        }

        private static void listenClient(UInt16 clientPort, string cliChannelName)
        {
            clientChannel = new TcpChannel(clientPort);
            ChannelServices.RegisterChannel(clientChannel, false);
            ClientServices services = new ClientServices();
            RemotingServices.Marshal(services, cliChannelName,
                typeof(ClientServices));
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
