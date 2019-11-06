using System;
using System.Collections.Generic;
using System.Windows.Forms;

using API;

namespace MSDAD_CLI
{
    public partial class CreateMeetingForm : Form
    {
        public CreateMeetingForm()
        {
            InitializeComponent();
        }
        private void goToBackButton_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.ResetAllControls(this);
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.mainForm);
        }

        private void CreateMeetingButton_Click(object sender, EventArgs e)
        {
            List<Slot> slots = new List<Slot>();
            foreach(ListViewItem s in SlotsLv.Items)
            {
                Slot slot = Slot.FromString(s.SubItems[1].Text + "," + s.SubItems[0].Text);
                slots.Add(new Slot(slot.location, slot.date));
            }
            List<string> invitees = new List<string>();
            foreach(ListViewItem i in InviteesLv.Items)
            {
                invitees.Add(i.Text);
            }

            Client.server.CreateMeeting(Client.Username, Client.ClientRA.ToString(), TopicTb.Text, Convert.ToUInt16(MinPartNud.Value), slots, invitees);

            ClientFormUtilities.ResetAllControls(this);
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.mainForm);
        }

        private void AddSlotBtn_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(DateDTP.Text);
            lvi.SubItems.Add(LocationLBox.SelectedItem.ToString());
            SlotsLv.Items.Add(lvi);
        }

        private void CreateMeetingForm_Load(object sender, EventArgs e)
        {
         
        }

        private void InviteUserBtn_Click(object sender, EventArgs e)
        {
            try
            { 
                InviteesLv.Items.Add(InviteesLBox.SelectedItem.ToString());
            } catch(NullReferenceException)
            {
                MessageBox.Show("Must select a user.");
            }
            
        }

        public void FillLocationsAndUsers()
        {
            InviteesLBox.Items.Clear();
            LocationLBox.Items.Clear();

            List<string> usernamesList = Client.server.GetClientsUsername();
            foreach (string user in usernamesList)
            {
                if (user != Client.Username)
                {
                    InviteesLBox.Items.Add(user);
                }
            }

            List<string> locationsList = Client.server.GetLocations();
            foreach (string location in locationsList)
            {
                LocationLBox.Items.Add(location);
            }
        }
    }
}
