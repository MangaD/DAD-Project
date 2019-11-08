using System;
using System.Windows.Forms;

namespace MSDAD_CLI.pages
{
    public partial class CloseMeetingPage : UserControl
    {
        public CloseMeetingPage()
        {
            InitializeComponent();
        }
        private void goToBackButton_Click(object sender, EventArgs e)
        {
            Client.mainForm.switchPage(Client.mainForm.mainPage);
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
