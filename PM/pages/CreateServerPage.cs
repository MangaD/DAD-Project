using System;
using System.Windows.Forms;

using API;

namespace PM.pages
{
    public partial class CreateServerPage : UserControl
    {
        public CreateServerPage()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer |
                ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                createSrvBtn.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            Program.mainForm.switchPage(Program.mainForm.mainPage);
        }

        private void createSrvBtn_Click(object sender, EventArgs e)
        {
            bool valid = true;

            RemotingAddress serverRA = new RemotingAddress();

            if (serverIDTb.Text == "")
            {
                valid = false;
                MessageBox.Show("Server ID cannot be empty.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (serverRATb.Text == "")
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
                    serverRA = RemotingAddress.FromString(serverRATb.Text);
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
            if (maxFaultsNUD.Value < 0)
            {
                valid = false;
                MessageBox.Show("Maximum faults cannot be negative.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (minDelayNUD.Value < 0)
            {
                valid = false;
                MessageBox.Show("Minimum delay cannot be negative.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (maxDelayNUD.Value < 0)
            {
                valid = false;
                MessageBox.Show("Maximum delay cannot be negative.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (minDelayNUD.Value > maxDelayNUD.Value)
            {
                valid = false;
                MessageBox.Show("Minimum delay cannot be bigger than maximum delay.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (valid)
            {
                try
                {
                    Program.CreateServer(serverIDTb.Text, serverRA, Convert.ToUInt16(maxFaultsNUD.Value),
                        Convert.ToUInt16(minDelayNUD.Value), Convert.ToUInt16(maxDelayNUD.Value));

                    Program.mainForm.switchPage(Program.mainForm.mainPage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating server: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
