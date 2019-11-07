using System;
using System.Collections.Generic;
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

            mainForm = new MainForm();
            Application.Run(mainForm);
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
                serverList.Add(new Tuple<string, RemotingAddress, IServerPM>(serverID, serverRA, server));
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
        }

        private static void RemovePCSFromList(RemotingAddress pcsRA)
        {
            PCSList.RemoveAll(p => p.Item1 == pcsRA);
        }
    }
}
