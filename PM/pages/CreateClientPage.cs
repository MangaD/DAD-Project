﻿using System;
using System.Windows.Forms;

using API;

namespace PM.pages
{
    public partial class CreateClientPage : UserControl
    {
        public CreateClientPage()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer |
                ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                createCliBtn.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            Program.mainForm.switchPage(Program.mainForm.mainPage);
        }

        private void createCliBtn_Click(object sender, EventArgs e)
        {
            bool valid = true;

            RemotingAddress serverRA = new RemotingAddress();
            RemotingAddress clientRA = new RemotingAddress();

            string username = usernameTb.Text.Trim();
            string clientRAStr = clientRATb.Text.Trim();
            string serverRAStr = serverRATb.Text.Trim();
            string scriptPath = scriptPathTb.Text.Trim();

            if (username == "")
            {
                valid = false;
                MessageBox.Show("Username cannot be empty.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (clientRAStr == "")
            {
                valid = false;
                MessageBox.Show("Client remoting address cannot be empty.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    clientRA = RemotingAddress.FromString(clientRAStr);
                }
                catch (ArgumentException)
                {
                    valid = false;
                    MessageBox.Show("Client remoting address is invalid.\n" +
                        "Must be of the format: tcp://address:port/channel",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            if (serverRAStr == "")
            {
                valid = false;
                MessageBox.Show("Server remoting address cannot be empty.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    serverRA = RemotingAddress.FromString(serverRAStr);
                }
                catch (ArgumentException)
                {
                    valid = false;
                    MessageBox.Show("Server remoting address is invalid.\n" +
                        "Must be of the format: tcp://address:port/channel",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            if (valid)
            {
                try
                {
                    Program.CreateClient(username, clientRA, serverRA, scriptPath);

                    Program.mainForm.switchPage(Program.mainForm.mainPage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating client: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
