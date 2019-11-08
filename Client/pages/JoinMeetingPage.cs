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

        private void backLbl_Click(object sender, EventArgs e)
        {
            Client.mainForm.ResetAllControls(this);
            Client.mainForm.switchPage(Client.mainForm.mainPage);
        }

        private void topicCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableSlotsLv.Items.Clear();
            selectedSlotsLv.Items.Clear();

            if (topicCB == null || topicCB.Text == null || topicCB.Text == "")
            {
                return;
            }

            MeetingProposal mp = Client.server.GetMeeting(topicCB.Text);

            foreach (Slot slot in mp.Slots)
            {
                ListViewItem lvi = new ListViewItem(slot.date.ToString("yyyy-MM-dd"));
                lvi.SubItems.Add(slot.location);
                availableSlotsLv.Items.Add(lvi);
            }
        }

        private void SlotsLv_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = availableSlotsLv.SelectedItems[0];
            availableSlotsLv.Items.Remove(lvi);
            selectedSlotsLv.Items.Add(lvi);

        }

        private void SelectedSlotsLv_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = selectedSlotsLv.SelectedItems[0];
            selectedSlotsLv.Items.Remove(lvi);
            availableSlotsLv.Items.Add(lvi);
        }

        private void joinMeetingButton_Click(object sender, EventArgs e)
        {
            List<Slot> selectedSlots = new List<Slot>();
            foreach (ListViewItem s in selectedSlotsLv.Items)
            {
                Slot slot = Slot.FromString(s.SubItems[1].Text + "," + s.SubItems[0].Text);
                selectedSlots.Add(slot);
            }

            try
            {
                Client.server.JoinMeeting(topicCB.Text, Client.Username, Client.ClientRA.ToString(),
                    selectedSlotsLv.Items.Count, selectedSlots);
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Lost connection to the server.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void FillTopicCB()
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                topicCB.Items.Clear();

                try
                {
                    List<MeetingProposal> MeetingsList = Client.server.ListMeetings(Client.Username);
                    foreach (MeetingProposal mp in MeetingsList)
                    {
                        topicCB.Items.Add(new ListViewItem(mp.Topic));
                    }
                } catch (System.Net.Sockets.SocketException)
                {
                    MessageBox.Show("Lost connection to the server.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }));
        }

        public void AddMeetingToCB(string topic)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                topicCB.Items.Add(topic);
            }));
        }

    }
}
