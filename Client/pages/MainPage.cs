using System;
using System.Windows.Forms;

namespace MSDAD_CLI.pages
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void goToCreateMeetingButton_Click(object sender, EventArgs e)
        {
            Client.mainForm.createMeetingPage.FillLocationsAndUsers();
            Client.mainForm.switchPage(Client.mainForm.createMeetingPage);
        }

        private void goToJoinMeeting_Click(object sender, EventArgs e)
        {
            Client.mainForm.switchPage(Client.mainForm.joinMeetingPage);
        }

        private void goToCloseMeetingButton_Click(object sender, EventArgs e)
        {
            Client.mainForm.switchPage(Client.mainForm.closeMeetingPage);
        }

        private void goToListMeetingsButton_Click(object sender, EventArgs e)
        {
            //Client.mainForm.listMeetingPage.FillListView();
            Client.mainForm.switchPage(Client.mainForm.listMeetingPage);
        }
    }
}
