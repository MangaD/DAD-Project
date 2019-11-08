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

        private void backLbl_Click(object sender, EventArgs e)
        {
            Client.mainForm.switchPage(Client.mainForm.mainPage);
        }

        public void FillTopicListView()
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                listMeetingsLv.Items.Clear();

                try
                {
                    List<MeetingProposal> MeetingsList = Client.server.ListMeetings(Client.Username);
                    foreach (MeetingProposal mp in MeetingsList)
                    {
                        listMeetingsLv.Items.Add(new ListViewItem(mp.Topic));
                    }
                }
                catch (System.Net.Sockets.SocketException)
                {
                    MessageBox.Show("Lost connection to the server.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }));
        }

        public void AddMeetingToList(string topic)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                listMeetingsLv.Items.Add(new ListViewItem(topic));
            }));
        }
    }
}
