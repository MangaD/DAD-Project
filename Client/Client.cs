using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading;
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

            if (args.Length < 3 || args.Length > 4)
            {
                string error = "This program must take at least 3 arguments. " +
                    "client name, client remoting address, and server remoting address. " +
                    "Optionally a 4th argument, the script filename.";
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Username = args[0];
            ClientRA = RemotingAddress.FromString(args[1]);
            ServerRA = RemotingAddress.FromString(args[2]);

            ListenClient(ClientRA.port, ClientRA.channel);

            try
            {
                ConnectToServer(ServerRA.ToString(), Username, ClientRA.ToString());
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //https://stackoverflow.com/questions/5991249/application-exit-not-working
                Environment.Exit(0);
            }

            if (args.Length > 3 && args[3] != "")
            {
                string scriptFilename = args[3];

                try
                {
                    Parser parser = new Parser(scriptFilename);
                    parser.Parse();
                    Thread scriptThread = new Thread(parser.ExecCommands);
                    scriptThread.Start();
                }
                catch (ParserException pe)
                {
                    MessageBox.Show(pe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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

    }
}
