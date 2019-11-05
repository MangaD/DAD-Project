﻿using System;
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

        public static List<Tuple<RemotingAddress, IServerPM>> serverList;

        /**
         * Form stuff
         */
        public static FormUtilities formUtilities;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formUtilities = new FormUtilities();

            PCSList = new List<Tuple<RemotingAddress, IPCS>>();

            Application.Run(formUtilities.mainForm);
        }

        public static void CreateServer(string serverID, RemotingAddress serverRA,
            uint maxFaults, uint minDelay, uint maxDelay)
        {
            RemotingAddress pcsRA = new RemotingAddress(serverRA.address, PCSPort, PCSChannel);

            IPCS pcs = GetPCS(pcsRA);

            pcs.StartServer(serverID, serverRA, maxFaults, minDelay, maxDelay);
            ConnectToServer(serverID, serverRA);
        }

        public static void CreateClient(string username, RemotingAddress clientRA,
            RemotingAddress serverRA, string scriptFile)
        {
            RemotingAddress pcsRA = new RemotingAddress(serverRA.address, PCSPort, PCSChannel);

            IPCS pcs = GetPCS(pcsRA);

            pcs.StartClient(username, clientRA, serverRA, scriptFile);
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

        private static void ConnectToServer(string serverID, RemotingAddress serverRA)
        {
            /*if (!PCSList.Exists(x => x.Item1 == PCSRemotingAddress))
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
            }*/
        }
    }
}
