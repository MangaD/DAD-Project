﻿using System;
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

        private void backLbl_Click(object sender, EventArgs e)
        {
            Client.mainForm.ResetAllControls(this);
            Client.mainForm.switchPage(Client.mainForm.mainPage);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                CreateMeetingButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CreateMeetingButton_Click(object sender, EventArgs e)
        {
            if (topicTb == null || topicTb.Text == null || topicTb.Text == "")
            {
                MessageBox.Show("You must add a topic to the meeting.");
                return;
            }

            if (MinPartNud.Value <= 0)
            {
                MessageBox.Show("Minimum attendees must be bigger than 0.");
                return;
            }

            List<Slot> slots = new List<Slot>();
            foreach (ListViewItem s in SlotsLv.Items)
            {
                Slot slot = Slot.FromString(s.SubItems[1].Text + "," + s.SubItems[0].Text);
                slots.Add(new Slot(slot.location, slot.date));
            }

            if (slots.Count == 0)
            {
                MessageBox.Show("You must add slots to the meeting.");
                return;
            }

            List<string> invitees = new List<string>();
            foreach (ListViewItem i in InviteesLv.Items)
            {
                invitees.Add(i.Text);
            }

            try
            {
                try
                {
                    Client.server.CreateMeeting(Client.Username, Client.ClientRA,
                    topicTb.Text, Convert.ToUInt16(MinPartNud.Value), slots, invitees);
                }catch (System.Net.Sockets.SocketException)
                {
                    bool serverDown = true;
                    for (int i=0; i< Client.serverReplicasList.Count; i++)
                    {
                        //MessageBox.Show("serverDown: " + serverDown + "Number of Replicas: " + 
                          //  Client.serverReplicasList.Count + " Replica number: " + i);
                        if (serverDown)
                        {
                            try
                            {
                                Client.serverReplicasList[i].CreateMeeting(Client.Username, Client.ClientRA,
                            topicTb.Text, Convert.ToUInt16(MinPartNud.Value), slots, invitees);
                                MessageBox.Show("Replica n: " + i + " created the meeting!");
                                Client.server = Client.serverReplicasList[i];
                                serverDown = false;
                            }
                            catch (System.Net.Sockets.SocketException)
                            {
                                MessageBox.Show("Server n: " + i + " is Down!");
                            }
                        }
                    }
                }

                MessageBox.Show($"Created meeting '{topicTb.Text}'");

                Client.mainForm.ResetAllControls(this);
                Client.mainForm.switchPage(Client.mainForm.mainPage);
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

            Client.mainForm.ResetAllControls(this);
            Client.mainForm.switchPage(Client.mainForm.mainPage);
        }

        private void AddSlotBtn_Click(object sender, EventArgs e)
        {
            if (DateDTP == null || DateDTP.Text == null || DateDTP.Text == "")
            {
                MessageBox.Show("Must select a date for the slot!");
                return;
            }
            if (locationCB == null || locationCB.SelectedItem == null ||
                locationCB.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Must select a location for the slot!");
                return;
            }

            foreach (ListViewItem item in SlotsLv.Items)
            {
                if (item.Text == DateDTP.Text)
                {
                    foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    {
                        if (subitem.Text == locationCB.SelectedItem.ToString())
                        {
                            MessageBox.Show("You have already added this slot.");
                            return;
                        }
                    }
                }
            }

            ListViewItem lvi = new ListViewItem(DateDTP.Text);
            lvi.SubItems.Add(locationCB.SelectedItem.ToString());
            SlotsLv.Items.Add(lvi);
        }

        private void InviteUserBtn_Click(object sender, EventArgs e)
        {
            if (inviteesCB == null || inviteesCB.Text == null || inviteesCB.Text == "")
            {
                MessageBox.Show("Must select a user to invite!");
                return;
            }

            foreach (ListViewItem item in InviteesLv.Items)
            {
                if (item.Text == inviteesCB.Text)
                {
                    MessageBox.Show("You have already added this invitee.");
                    return;
                }
            }

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

                try
                {
                    List<string> usernamesList = Client.server.GetClientUsernames();
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

        public void AddClientToCB(string username)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                inviteesCB.Items.Add(username);
            }));
        }

        private void SlotsLv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (SlotsLv.FocusedItem.Bounds.Contains(e.Location))
                {
                    slotsCMS.Show(Cursor.Position);
                }
            }
        }

        private void InviteesLv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (SlotsLv.FocusedItem.Bounds.Contains(e.Location))
                {
                    slotsCMS.Show(Cursor.Position);
                }
            }
        }

        private void removeSlot_Click(object sender, EventArgs e)
        {
            if (SlotsLv.SelectedItems != null && SlotsLv.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in SlotsLv.SelectedItems)
                {
                    SlotsLv.Items.Remove(lvi);
                }
            }
        }

        private void removeInvitee_Click(object sender, EventArgs e)
        {
            if (InviteesLv.SelectedItems != null && InviteesLv.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in InviteesLv.SelectedItems)
                {
                    InviteesLv.Items.Remove(lvi);
                }
            }
        }

    }
}
