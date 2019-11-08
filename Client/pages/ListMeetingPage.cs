using System;
using System.Collections.Generic;
using System.Windows.Forms;

using API;

namespace MSDAD_CLI.pages
{
    public partial class ListMeetingPage : UserControl
    {
        public ListMeetingPage()
        {
            InitializeComponent();
        }

        private void goToBackButton_Click(object sender, EventArgs e)
        {
            Client.mainForm.switchPage(Client.mainForm.mainPage);
        }

        public void FillListView()
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                ListMeetingsLv.Items.Clear();

                List<MeetingProposal> MeetingsList = Client.server.ListMeetings(Client.Username);
                foreach (MeetingProposal mp in MeetingsList)
                {
                    ListMeetingsLv.Items.Add(new ListViewItem(mp.Topic));
                }
            }));
        }
    }
}
