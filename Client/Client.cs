using System;
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
        public static IServerC server;

        public static string Username { get; set; }
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

            Username = args[0];
            RemotingAddress clientRA = RemotingAddress.FromString(args[1]);
            RemotingAddress serverRA = RemotingAddress.FromString(args[2]);
            string scriptFilename = args[3];

            MessageBox.Show(scriptFilename);

            ListenClient(clientRA.port, clientRA.channel);

            try
            {
                ConnectToServer(serverRA.ToString(), Username, clientRA.ToString());
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

        public static void ConnectToServer(string serverRA, string clientName, string clientRA)
        {
            Username = clientName;
            server = (IServerC) Activator.GetObject(typeof(IServerC), serverRA);
            server.RegisterClient(clientName, clientRA);
        }

        public static void ListenClient(UInt16 clientPort, string cliChannelName)
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
