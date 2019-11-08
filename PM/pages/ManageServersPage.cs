using System;
using System.Collections.Generic;
using System.Windows.Forms;

using API;

namespace PM.pages
{
    public partial class ManageServersPage : UserControl
    {
        public ManageServersPage()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer |
                ControlStyles.SupportsTransparentBackColor, true);
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            Program.mainForm.switchPage(Program.mainForm.mainPage);
        }

        public void AddServerToList(string serverID)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                serverListBox.Items.Add(serverID);
            }));
        }

        public void RemoveServerFromList(string serverID)
        {
            // https://stackoverflow.com/questions/142003/cross-thread-operation-not-valid-control-accessed-from-a-thread-other-than-the
            this.BeginInvoke(new MethodInvoker(delegate {
                serverListBox.Items.Remove(serverID);
            }));
        }

        private void freezeBtn_Click(object sender, EventArgs e)
        {
            if (serverListBox.SelectedItem == null || serverListBox.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Must select a server from the list.");
                return;
            }

            string serverID = serverListBox.SelectedItem.ToString();

            IServerPM server = Program.GetServer(serverID);

            if (server == null)
            {
                MessageBox.Show($"Server '{serverID}' is disconnected.");
                Program.RemoveServerFromList(serverID);
                return;
            }

            try
            {
                server.Freeze();
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show($"Server '{serverID}' is disconnected.");
                Program.RemoveServerFromList(serverID);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Server '{serverID}' has been frozen.");
        }

        private void unfreezeBtn_Click(object sender, EventArgs e)
        {
            if (serverListBox.SelectedItem == null || serverListBox.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Must select a server from the list.");
                return;
            }

            string serverID = serverListBox.SelectedItem.ToString();

            IServerPM server = Program.GetServer(serverID);

            if (server == null)
            {
                MessageBox.Show($"Server '{serverID}' is disconnected.");
                Program.RemoveServerFromList(serverID);
                return;
            }

            try
            {
                server.Unfreeze();
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show($"Server '{serverID}' is disconnected.");
                Program.RemoveServerFromList(serverID);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Server '{serverID}' has been unfrozen.");
        }

        private void crashBtn_Click(object sender, EventArgs e)
        {
            if (serverListBox.SelectedItem == null || serverListBox.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Must select a server from the list.");
                return;
            }

            string serverID = serverListBox.SelectedItem.ToString();

            IServerPM server = Program.GetServer(serverID);

            if (server == null)
            {
                MessageBox.Show($"Server '{serverID}' is disconnected.");
                Program.RemoveServerFromList(serverID);
                return;
            }

            try
            {
                server.Crash();
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show($"Server '{serverID}' has been crashed.");
                Program.RemoveServerFromList(serverID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            if (serverListBox.SelectedItem == null || serverListBox.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Must select a server from the list.");
                return;
            }

            string serverID = serverListBox.SelectedItem.ToString();

            if (nameTb.Text == "")
            {
                MessageBox.Show("Room name cannot be empty.");
                return;
            }

            if (locationCb.Text == "")
            {
                MessageBox.Show("Room location cannot be empty.");
                return;
            }

            if (capacityNUD.Value < 1)
            {
                MessageBox.Show("Room capacity must be bigger than 0.");
                return;
            }

            string name = nameTb.Text;
            string location = locationCb.Text;
            uint capacity = Convert.ToUInt32(capacityNUD.Value);

            IServerPM server = Program.GetServer(serverID);

            if (server == null)
            {
                MessageBox.Show($"Server '{serverID}' is disconnected.");
                Program.RemoveServerFromList(serverID);
                return;
            }

            try
            {
                server.AddRoom(location, capacity, name);
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show($"Server '{serverID}' is disconnected.");
                Program.RemoveServerFromList(serverID);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Room '{name}' for {location} has been created.");
        }

        public void FillLocationCb(List<string> locations)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                locationCb.Items.Clear();

                foreach (string loc in locations)
                {
                    locationCb.Items.Add(loc);
                }
            }));
        }
    }
}
