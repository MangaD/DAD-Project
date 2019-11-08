using System;
using System.Collections.Generic;
using System.Windows.Forms;

using API;

namespace MSDAD_CLI.pages
{
    public partial class CreateMeetingPage : UserControl
    {
        public CreateMeetingPage()
        {
            InitializeComponent();
        }

        private void goToBackButton_Click(object sender, EventArgs e)
        {
            Client.mainForm.ResetAllControls(this);
            Client.mainForm.switchPage(Client.mainForm.mainPage);
        }

        private void CreateMeetingButton_Click(object sender, EventArgs e)
        {
            List<Slot> slots = new List<Slot>();
            foreach (ListViewItem s in SlotsLv.Items)
            {
                Slot slot = Slot.FromString(s.SubItems[1].Text + "," + s.SubItems[0].Text);
                slots.Add(new Slot(slot.location, slot.date));
            }
            List<string> invitees = new List<string>();
            foreach (ListViewItem i in InviteesLv.Items)
            {
                invitees.Add(i.Text);
            }

            Client.server.CreateMeeting(Client.Username, Client.ClientRA.ToString(), TopicTb.Text, Convert.ToUInt16(MinPartNud.Value), slots, invitees);

            Client.mainForm.ResetAllControls(this);
            Client.mainForm.switchPage(Client.mainForm.mainPage);
        }

        private void AddSlotBtn_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(DateDTP.Text);
            lvi.SubItems.Add(locationCB.SelectedItem.ToString());
            SlotsLv.Items.Add(lvi);
        }

        private void InviteUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                InviteesLv.Items.Add(inviteesCB.SelectedItem.ToString());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Must select a user.");
            }

        }

        public void FillLocationsAndUsers()
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                inviteesCB.Items.Clear();
                locationCB.Items.Clear();

                List<string> usernamesList = Client.server.GetClientsUsername();
                foreach (string user in usernamesList)
                {
                    if (user != Client.Username)
                    {
                        inviteesCB.Items.Add(user);
                    }
                }

                List<string> locationsList = Client.server.GetLocations();
                foreach (string location in locationsList)
                {
                    locationCB.Items.Add(location);
                }
            }));
        }

    }
}
