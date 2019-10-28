using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using API;

namespace MSDAD_CLI
{
    class Client
    {
        private UInt16 clientPort;
        private string clientName;

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

            Client cli = new Client(clientPort, clientName);

            // Connect to server
            IServer server = (IServer)Activator.GetObject(typeof(IServer), "tcp://localhost:65000/MSServer");
            server.RegisterClient(clientPort, clientName);

            Parser parser = new Parser(scriptFilename, server);
            parser.Parse();


            TcpChannel channel = new TcpChannel(port);
            ChannelServices.RegisterChannel(channel, false);
            ClientServices services = new ClientServices();
            RemotingServices.Marshal(services, "MSClient",
                typeof(ClientServices));

            server.clientSaysHelloToServer(port);


            //parser.ExecCommands();

            Console.ReadKey();
        }

        public Client(UInt16 clientPort, string clientName)
        {
            this.clientPort = clientPort;
            this.clientName = clientName;
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
