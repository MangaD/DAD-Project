using System;
using System.Windows.Forms;

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

            if (serverIDTb.Text == "")
            {
                valid = false;
                MessageBox.Show("Server ID cannot be empty.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (remotingAddrTb.Text == "")
            {
                valid = false;
                MessageBox.Show("Remoting Address cannot be empty.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                // TODO

                FormUtilities.switchForm(this, Program.formUtilities.mainForm);
            }
        }
    }
}
