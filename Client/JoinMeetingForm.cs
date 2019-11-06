using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API;

namespace MSDAD_CLI
{
    public partial class JoinMeetingForm : Form
    {
        public JoinMeetingForm()
        {
            InitializeComponent();
        }

        private void goToBackButton_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.mainForm);
        }

        private void searchTopicButton_Click(object sender, EventArgs e)
        {
            SlotsLv.Clear();
            SelectedSlotsLv.Clear();
            foreach (MeetingProposal mp in Client.server.ListMeetings(Client.Username))
            {
                if (mp.Topic == TopicTb.Text)
                {
                    foreach (Slot slot in mp.Slots)
                    {
                        ListViewItem lvi = new ListViewItem(slot.date.ToString());
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

            Client.server.JoinMeeting(TopicTb.Text, Client.Username, Client.ClientRA.ToString(), SelectedSlotsLv.Items.Count, selectedSlots);
        }
    }
}
