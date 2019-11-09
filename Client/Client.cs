﻿using System;
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
        private static TcpChannel clientChannel;
        public static IServerC server;

        public static string Username { get; set; }
        public static RemotingAddress ClientRA { get; set; }
        public static RemotingAddress ServerRA { get; set; }

        public static MainForm mainForm;

        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

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

            mainForm = new MainForm();
            Application.Run(mainForm);
        }

        public static void ConnectToServer(string serverRA, string clientName, string clientRA)
        {
            Username = clientName;
            server = (IServerC) Activator.GetObject(typeof(IServerC), serverRA);
            try
            {
                server.RegisterClient(clientName, clientRA);
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Lost connection to the server.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

        public void InformNewClient(string username)
        {
            if (Client.mainForm != null && Client.mainForm.createMeetingPage != null)
            {
                Client.mainForm.createMeetingPage.AddClientToCB(username);
            }
        }

        public void InformNewMeeting(MeetingProposal mp)
        {
            if (Client.mainForm != null && Client.mainForm.listMeetingPage != null)
            {
                Client.mainForm.listMeetingPage.AddMeetingToList(mp);
                Client.mainForm.joinMeetingPage.AddMeetingToCB(mp.Topic);
                Client.mainForm.closeMeetingPage.AddMeetingToCB(mp.Topic);
            }
        }
    }
}
