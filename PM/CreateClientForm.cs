using System;
using System.Windows.Forms;

using API;

namespace PM
{
    public partial class CreateClientForm : Form
    {
        public CreateClientForm()
        {
            InitializeComponent();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            FormUtilities.switchForm(this, Program.formUtilities.mainForm);
        }

        private void createCliBtn_Click(object sender, EventArgs e)
        {
            bool valid = true;

            RemotingAddress serverRA = new RemotingAddress();
            RemotingAddress clientRA = new RemotingAddress();

            if (usernameTb.Text == "")
            {
                valid = false;
                MessageBox.Show("Username cannot be empty.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (clientRATb.Text == "")
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
                    clientRA = RemotingAddress.FromString(clientRATb.Text);
                }
                catch (ArgumentException)
                {
                    valid = false;
                    MessageBox.Show("Client remoting address is invalid.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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

            if (valid)
            {
                try
                {
                    Program.CreateClient(usernameTb.Text, clientRA, serverRA, scriptPathTb.Text);

                    FormUtilities.switchForm(this, Program.formUtilities.mainForm);
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
