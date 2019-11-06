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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void goToCreateMeetingButton_Click(object sender, EventArgs e)
        {
            Client.clientFormUtilities.createMeetingForm.FillLocationsAndUsers();
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.createMeetingForm);
        }

        private void goToJoinMeeting_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.joinMeetingForm);
        }

        private void goToCloseMeetingButton_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.closeMeetingForm);
        }

        private void goToListMeetingsButton_Click(object sender, EventArgs e)
        {
            Client.clientFormUtilities.listMeetingsForm.FillListView();
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.listMeetingsForm);
        }

        private void goToBackButton_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.signInForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}