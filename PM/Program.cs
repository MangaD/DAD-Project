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

        /**
         * Form stuff
         */

        public static MainForm mainForm;
        public static CreateServerForm createServerForm;

        public static void setWindowAttributes(Form form)
        {
            form.Text = mainForm.Text;
            form.Width = mainForm.Width;
            form.Height = mainForm.Height;
            form.Icon = mainForm.Icon;
            form.BackgroundImage = mainForm.BackgroundImage;
            form.BackgroundImageLayout = mainForm.BackgroundImageLayout;
            //form.Location = mainForm.Location;
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormClosed += new FormClosedEventHandler(onClose);
        }

        public static void onClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainForm = new MainForm();

            createServerForm = new CreateServerForm();
            setWindowAttributes(createServerForm);

            PCSList = new List<Tuple<RemotingAddress, IPCS>>();

            Application.Run(mainForm);
        }

        public static IPCS ConnectToPCS(string PCSRemotingAddress)
        {
            RemotingAddress ra = RemotingAddress.FromString(PCSRemotingAddress);

            if (!PCSList.Exists(x => x.Item1 == ra))
            {
                IPCS pcs = (IPCS)Activator.GetObject(typeof(IPCS), PCSRemotingAddress);
                if (pcs == null)
                {
                    MessageBox.Show("Could not locate PCS: " + PCSRemotingAddress);
                    return null;
                }
                PCSList.Add(new Tuple<RemotingAddress, IPCS>(ra, pcs));
                return pcs;
            }
            else
            {
                return PCSList.Find(x => x.Item1 == ra).Item2;
            }
        }
    }
}
