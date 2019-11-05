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
    public partial class CreateMeetingForm : Form
    {
        public CreateMeetingForm()
        {
            InitializeComponent();
        }
        private void goToBackButton_Click(object sender, EventArgs e)
        {
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

            Client.server.CreateMeeting(Client.ClientRA.ToString(), TopicTb.Text, Convert.ToUInt16(MinPartNud.Value), slots, invitees);
        }

        private void AddSlotBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateDTP.Value.Date;
            string location = LocationTB.Text;

            ListViewItem lvi = new ListViewItem(DateDTP.Text);
            lvi.SubItems.Add(LocationTB.Text);
            SlotsLv.Items.Add(lvi);
        }

        private void CreateMeetingForm_Load(object sender, EventArgs e)
        {
            List<string> usernamesList = Client.server.GetClientsUsername();
            foreach(string user in usernamesList)
            {
                if (user != Client.Username)
                {
                    InviteesLBox.Items.Add(user);
                }
            }
        }

        private void InviteUserBtn_Click(object sender, EventArgs e)
        {
            try
            { 
                InviteesLv.Items.Add(InviteesLBox.SelectedItem.ToString());
            } catch(NullReferenceException ex)
            {
                MessageBox.Show("Selecione um User!");
            }
            
        }
    }
}
