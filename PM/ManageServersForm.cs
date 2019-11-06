using System;
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
    }
}
