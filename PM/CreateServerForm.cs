using System;
using System.Windows.Forms;

using API;

namespace PM
{
    public partial class CreateServerForm : Form
    {
        public CreateServerForm()
        {
            InitializeComponent();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            FormUtilities.switchForm(this, Program.formUtilities.mainForm);
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
                    MessageBox.Show("Server remoting address is invalid.",
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

            if (valid)
            {
                try
                {
                    Program.CreateServer(serverIDTb.Text, serverRA, Convert.ToUInt16(maxFaultsNUD.Value),
                        Convert.ToUInt16(minDelayNUD.Value), Convert.ToUInt16(maxDelayNUD.Value));

                    FormUtilities.switchForm(this, Program.formUtilities.mainForm);
                } catch (Exception ex)
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
