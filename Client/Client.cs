using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

using API;

namespace MSDAD_CLI
{
    public static class Client
    {
        public static ClientFormUtilities clientFormUtilities;

        private static TcpChannel clientChannel;
        private static IServerC server;

        public static string ClientName { get; set; }
        public static RemotingAddress ClientRA { get; set; }
        public static RemotingAddress ServerRA { get; set; }

        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            clientFormUtilities = new ClientFormUtilities();

            if (args.Length != 4)
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

            listenClient(clientRA.port, clientRA.channel);

            try
            {
                connectToServer(serverRA.ToString(), ClientName, clientRA.ToString());
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //https://stackoverflow.com/questions/5991249/application-exit-not-working
                Environment.Exit(0);
            }

            Parser parser = new Parser(scriptFilename);
            try
            {
                parser.Parse();
            } catch (ParserException pe)
            {
                MessageBox.Show(pe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Utilities.WriteError(pe.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }

            server.ClientSaysHelloToServer(clientRA.port);

            //parser.ExecCommands();

            Application.Run(clientFormUtilities.mainForm);
        }

        public static void connectToServer(string serverRA, string clientName, string clientRA)
        {
            ClientName = clientName;
            server = (IServerC)Activator.GetObject(typeof(IServerC), serverRA);
            server.RegisterClient(clientName, clientRA);
        }

        public static void listenClient(UInt16 clientPort, string cliChannelName)
        {
            clientChannel = new TcpChannel(clientPort);
            ChannelServices.RegisterChannel(clientChannel, false);
            ClientServices services = new ClientServices();
            RemotingServices.Marshal(services, cliChannelName,
                typeof(ClientServices));
        }

        public static List<string> ListMeetings()
        {
            List<string> result = server.ListMeetings(ClientName);
            Utilities.WriteDebug("Sent 'list' command to server");
            return result;
        }

        public static void CreateMeeting( string topic, uint minAttendees,
            List<Slot> slots, List<string> invitees)
        {
            server.CreateMeeting(ClientName, topic, minAttendees, slots, invitees);
            Utilities.WriteDebug("Sent 'create " + topic + "' command to server");
        }

        public static void JoinMeeting(string topic, int slotCount, List<Slot> slots)
        {
            //TODO do something with bool return
            server.JoinMeeting(topic, ClientName, ClientRA.ToString(), slotCount, slots);
            Utilities.WriteDebug("Sent 'join " + topic + "' command to server");
        }

        public static void CloseMeeting(string topic)
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
