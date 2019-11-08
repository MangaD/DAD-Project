using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSDAD_CLI
{
    public partial class CloseMeetingForm : Form
    {
        public CloseMeetingForm()
        {
            InitializeComponent();
        }
        private void goToBackButton_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.mainForm);
        }

        private void closeMeetingButton_Click(object sender, EventArgs e)
        {
            if (Client.server.CloseMeeting(topicTb.Text, Client.Username))
            {
                //success
                MessageBox.Show("Meeting was booked.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                //fail
                MessageBox.Show("Meeting was cancelled.\nNot enough participants.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
