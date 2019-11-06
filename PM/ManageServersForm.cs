using System;
using System.Collections.Generic;
using System.Windows.Forms;

using API;

namespace PM
{
    public partial class ManageServersForm : Form
    {
        public ManageServersForm()
        {
            InitializeComponent();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            FormUtilities.switchForm(this, Program.formUtilities.mainForm);
        }

        public void AddServerToList(string serverID)
        {
            serverListBox.Items.Add(serverID);
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

            try
            {
                server.Freeze();
            } catch (Exception ex)
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

            try
            {
                server.Unfreeze();
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

            try
            {
                server.Crash();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Server '{serverID}' has been crashed.");
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

            try
            {
                server.AddRoom(location, capacity, name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Room '{name}' for {location} has been created.");
        }

        private void ManageServersForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Program.serverList.Count > 0)
            {
                List<string> locations = Program.serverList[0].Item3.GetLocationsPM();
                locationCb.Items.Clear();
                foreach (string loc in locations)
                {
                    locationCb.Items.Add(loc);
                }
            }
        }
    }
}
