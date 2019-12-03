using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

using API;

namespace PM
{
    static class Program
    {
        /**
         * Assignment: It is the PuppetMaster that reads the system configuration file and starts
         * all the relevant processes. The PCS on each machine should expose a service
         * at an URL on port 10000 for the PuppetMaster to request the creation of a process.
         * For simplicity, we assume that the PuppetMaster knows the URLs of the entire set
         * of available PCSs. This information can be provided, for instance, via
         * configuration file or command line.
         * 
         * Note: A better idea is to just assume there is a PCS, listening on port 10000,
         * on the URL of the server or client that we're trying to launch. Therefore,
         * everytime we attempt to launch a server or client, we add the corresponding
         * PCS to this list (if it is not here already).
         */
        public static List<Tuple<RemotingAddress, IPCS>> PCSList;
        private static string PCSChannel = "MSPCS";
        private static UInt16 PCSPort = 10000;

        /**
         * PM stuff
         */
        public static RemotingAddress PMRA = new RemotingAddress("localhost", 10001, "MSPM");
        public static TcpChannel PMChannel;

        public static List<Tuple<string, RemotingAddress, IServerPM>> serverList;

        /**
         * Form stuff
         */
        public static MainForm mainForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PCSList = new List<Tuple<RemotingAddress, IPCS>>();
            serverList = new List<Tuple<string, RemotingAddress, IServerPM>>();

            ListenPM();

            mainForm = new MainForm();
            Application.Run(mainForm);
        }

        public static void ListenPM()
        {
            PMChannel = new TcpChannel((int)PMRA.port);
            ChannelServices.RegisterChannel(PMChannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PMService),
                PMRA.channel, WellKnownObjectMode.Singleton);
        }

        public static void CreateServer(string serverID, RemotingAddress serverRA,
            uint maxFaults, uint minDelay, uint maxDelay)
        {
            if (serverList.Exists(x => x.Item1 == serverID))
            {
                throw new ApplicationException($"Server with ID '{serverID}' already exists.");
            }

            RemotingAddress pcsRA = new RemotingAddress(serverRA.address, PCSPort, PCSChannel);

            IPCS pcs = GetPCS(pcsRA);

            try
            {
                pcs.StartServer(serverID, serverRA, maxFaults, minDelay, maxDelay);
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show($"Connection with PCS on remoting address '{pcsRA.ToString()}' was lost.\n" +
                    "If the PCS has been restarted you may try again.");
                Program.RemovePCSFromList(pcsRA);
                return;
            }

            IServerPM server = ConnectToServer(serverID, serverRA);

            List<Tuple<string, RemotingAddress>> remoteServerList = new List<Tuple<string, RemotingAddress>>();
            foreach(Tuple<string, RemotingAddress, IServerPM> serv in serverList)
            {
                remoteServerList.Add(new Tuple<string, RemotingAddress>(serv.Item1, serv.Item2));
            }

            //Replication - Its done here because its before adding this server to the list
            //Inform new server of all existing servers
            server.SendExistingServersList(remoteServerList);
            //Inform all existing servers of new server
            foreach (Tuple<string, RemotingAddress, IServerPM> serv in serverList)
            {
                serv.Item3.BroadcastNewServer(new Tuple<string, RemotingAddress>(serverID, serverRA));
            }

            // Fill location list
            if (serverList.Count == 1)
            {
                mainForm.manageServersPage.FillLocationCb(server.GetLocationsPM());
            }

            mainForm.manageServersPage.AddServerToList(serverID);

        }

        public static void CreateClient(string username, RemotingAddress clientRA,
            RemotingAddress serverRA, string scriptFile)
        {
            RemotingAddress pcsRA = new RemotingAddress(serverRA.address, PCSPort, PCSChannel);

            IPCS pcs = GetPCS(pcsRA);

            try
            {
                pcs.StartClient(username, clientRA, serverRA, scriptFile);
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show($"Connection with PCS on remoting address '{pcsRA.ToString()}' was lost.\n" +
                    "If the PCS has been restarted you may try again.");
                Program.RemovePCSFromList(pcsRA);
                return;
            }
        }

        private static IPCS ConnectToPCS(RemotingAddress PCSRemotingAddress)
        {
            if (!PCSList.Exists(x => x.Item1 == PCSRemotingAddress))
            {
                IPCS pcs = (IPCS)Activator.GetObject(typeof(IPCS), PCSRemotingAddress.ToString());
                if (pcs == null)
                {
                    throw new ApplicationException("Could not locate PCS: " + PCSRemotingAddress.ToString());
                }
                PCSList.Add(new Tuple<RemotingAddress, IPCS>(PCSRemotingAddress, pcs));
                return pcs;
            }
            else
            {
                return PCSList.Find(x => x.Item1 == PCSRemotingAddress).Item2;
            }
        }

        private static IPCS GetPCS(RemotingAddress PCSRA)
        {
            return ConnectToPCS(PCSRA);
        }

        private static IServerPM ConnectToServer(string serverID, RemotingAddress serverRA)
        {
            if (!serverList.Exists(x => x.Item2 == serverRA))
            {
                if (serverList.Exists(x => x.Item1 == serverID))
                {
                    throw new ApplicationException($"Server with ID '{serverID}' already exists.");
                }

                IServerPM server = (IServerPM)Activator.GetObject(typeof(IServerPM), serverRA.ToString());
                if (server == null)
                {
                    throw new ApplicationException("Could not locate Server: " + serverRA.ToString());
                }

                Tuple<string, RemotingAddress, IServerPM> newServer =
                    new Tuple<string, RemotingAddress, IServerPM>(serverID, serverRA, server);

                serverList.Add(newServer);

                return server;
            }
            else
            {
                throw new ApplicationException("Already connected to server: " + serverRA.ToString());
            }
        }

        public static IServerPM GetServer(string serverID)
        {
            return serverList.Find(x => x.Item1 == serverID).Item3;
        }

        public static IServerPM GetServer(RemotingAddress serverRA)
        {
            return serverList.Find(x => x.Item2 == serverRA).Item3;
        }

        public static void RemoveServerFromList(string serverID)
        {
            mainForm.manageServersPage.RemoveServerFromList(serverID);
            serverList.RemoveAll(p => p.Item1 == serverID);
            MessageBox.Show($"Server '{serverID}' has exited.");
        }

        private static void RemovePCSFromList(RemotingAddress pcsRA)
        {
            PCSList.RemoveAll(p => p.Item1 == pcsRA);
        }

        public static void PrintStatus()
        {
            foreach (var s in serverList)
            {
                s.Item3.SystemStatus();
            }
        }
    }
}
