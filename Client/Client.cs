using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;
using API;
using MSDAD_CLI;

namespace ClientForm
{
    public class Client
    {
        public static ClientFormUtilities clientFormUtilities;

        private TcpChannel clientChannel;
        private IServerC server;

        public string ClientName { get; set; }
        public RemotingAddress ClientRA { get; set; }
        public RemotingAddress ServerRA { get; set; }

        public Client()
        {

        }

        [STAThread]
        static void Main(string[] args)
        {
            clientFormUtilities = new ClientFormUtilities();

            Application.EnableVisualStyles();
            Application.Run(clientFormUtilities.mainForm);

            /*
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
            RemotingAddress serverRA = RemotingAddress.FromString("tcp://localhost:65000/MSServer");

            listenClient(clientRA.port, clientRA.channel);
            connectToServer(serverRA.ToString(), ClientName, clientRA.ToString());
            */
            /*Parser parser = new Parser(scriptFilename, server);
            try
            {
                parser.Parse();
            } catch (ParserException pe)
            {
                Utilities.WriteError(pe.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }

            server.ClientSaysHelloToServer(clientRA.port);
            */
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

        public void ParseFile()
        {
            //TODO filename
            Parser myParser = new Parser("filename", this);
            myParser.Parse();
        }

        public void connectToServer(string serverRA, string clientName, string clientRA)
        {
            ClientName = clientName;
            server = (IServerC)Activator.GetObject(typeof(IServerC), serverRA);
            server.RegisterClient(clientName, clientRA);
        }

        public void listenClient(UInt16 clientPort, string cliChannelName)
        {
            clientChannel = new TcpChannel(clientPort);
            ChannelServices.RegisterChannel(clientChannel, false);
            ClientServices services = new ClientServices();
            RemotingServices.Marshal(services, cliChannelName,
                typeof(ClientServices));
        }

        public List<string> ListMeetings()
        {
            List<string> result = server.ListMeetings(ClientName);
            Utilities.WriteDebug("Sent 'list' command to server");
            return result;
        }

        public void CreateMeeting( string topic, uint minAttendees,
            List<Slot> slots, List<string> invitees)
        {
            server.CreateMeeting(ClientName, topic, minAttendees, slots, invitees);
            Utilities.WriteDebug("Sent 'create " + topic + "' command to server");
        }

        public void JoinMeeting(string topic, int n_slots, List<Slot> locationDates)
        {
            //TODO do something with bool return
            server.JoinMeeting(topic, ClientName, ClientRA.ToString(), n_slots, locationDates);
            Utilities.WriteDebug("Sent 'join " + topic + "' command to server");
        }

        public void CloseMeeting(string topic)
        {
            //TODO do something with bool return
            server.CloseMeeting(topic, ClientName);
            Utilities.WriteDebug("Sent 'close " + topic + "' command to server");
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
