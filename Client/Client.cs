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

        public static string ClientName { get; set; }
        public static RemotingAddress ClientRA { get; set; }
        public static RemotingAddress ServerRA { get; set; }

        public static void Main(string[] args)
        {
            if (args.Length != 6)
            {
                Utilities.WriteError("This program must take 4 argument. " +
                    "client name, client remoting address, server remoting address, " +
                    "Script filename.");
                Console.ReadKey();
                return;
            }

            ClientName = args[0];
            RemotingAddress clientRA = RemotingAddress.FromString(args[1]);
            RemotingAddress serverRA = RemotingAddress.FromString(args[2]);
            string scriptFilename = args[3];

            /*ClientName = "Leo";
            RemotingAddress clientRA = RemotingAddress.FromString("tcp://localhost:65001/MSClient");
            RemotingAddress serverRA = RemotingAddress.FromString("tcp://localhost:65000/MSServer");*/

            listenClient(clientRA.port, clientRA.channel);
            connectToServer(serverRA.ToString(), ClientName, clientRA.ToString());

            /*Parser parser = new Parser(scriptFilename, server);
            try
            {
                parser.Parse();
            } catch (ParserException pe)
            {
                Utilities.WriteError(pe.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }*/
            
            server.ClientSaysHelloToServer(clientRA.port);

            //parser.ExecCommands();

            /*do
            {
                Console.WriteLine("Choose Option: ");
                Console.WriteLine("1 - CreateMeeting");

                int opt = Convert.ToInt32(Console.ReadLine());

                if(opt == 1)
                {
                    server.CreateMeeting(clientRA.ToString(), "oi", 2, null, null);
                }
            } while (true);*/

            Console.ReadKey();
        }

        private static void connectToServer(string serverRA, string clientName, string clientRA)
        {
            server = (IServer)Activator.GetObject(typeof(IServer), serverRA);
            server.RegisterClient(clientName, clientRA);
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

        public void ServerRespondsHiToClient(UInt16 serverPort)
        {
            Console.WriteLine("Server: " + serverPort + " Responded Hi");
        }
    }
}
