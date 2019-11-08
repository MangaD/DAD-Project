using System;
using System.Collections.Generic;
using System.Windows.Forms;

using API;

namespace MSDAD_CLI.pages
{
    public partial class JoinMeetingPage : UserControl
    {
        public JoinMeetingPage()
        {
            InitializeComponent();
        }

        private void goToBackButton_Click(object sender, EventArgs e)
        {
            Client.mainForm.switchPage(Client.mainForm.mainPage);
        }

        private void searchTopicButton_Click(object sender, EventArgs e)
        {
            SlotsLv.Items.Clear();
            SelectedSlotsLv.Items.Clear();
            foreach (MeetingProposal mp in Client.server.ListMeetings(Client.Username))
            {
                if (mp.Topic == TopicTb.Text)
                {
                    foreach (Slot slot in mp.Slots)
                    {
                        ListViewItem lvi = new ListViewItem(slot.date.ToString("yyyy-MM-dd"));
                        lvi.SubItems.Add(slot.location);
                        SlotsLv.Items.Add(lvi);
                    }
                    break;
                }
            }
        }

        private void SlotsLv_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = SlotsLv.SelectedItems[0];
            SlotsLv.Items.Remove(lvi);
            SelectedSlotsLv.Items.Add(lvi);

        }

        private void SelectedSlotsLv_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = SelectedSlotsLv.SelectedItems[0];
            SelectedSlotsLv.Items.Remove(lvi);
            SlotsLv.Items.Add(lvi);
        }

        private void joinMeetingButton_Click(object sender, EventArgs e)
        {
            List<Slot> selectedSlots = new List<Slot>();
            foreach (ListViewItem s in SelectedSlotsLv.Items)
            {
                Slot slot = Slot.FromString(s.SubItems[1].Text + "," + s.SubItems[0].Text);
                selectedSlots.Add(slot);
            }

            if (Client.server.JoinMeeting(TopicTb.Text, Client.Username, Client.ClientRA.ToString(), SelectedSlotsLv.Items.Count, selectedSlots))
            {
                //success
                MessageBox.Show("Meeting was joined.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                //fail
                MessageBox.Show("Meeting couldn't be joined.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
