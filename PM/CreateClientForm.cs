using System;
using System.Windows.Forms;

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
            if (serverRATb.Text == "")
            {
                valid = false;
                MessageBox.Show("Server remoting address cannot be empty.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (valid)
            {
                // TODO

                FormUtilities.switchForm(this, Program.formUtilities.mainForm);
            }
        }
    }
}
