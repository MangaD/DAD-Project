﻿using System;
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
                    List<MeetingProposal> MeetingsList = Client.server.ListMeetings(Client.Username, false, false);
                    foreach (MeetingProposal mp in MeetingsList)
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { mp.Topic,
                            mp.CoordinatorUsername, mp.MinAttendees.ToString(),
                            (mp.IsClosed ? "Closed" : "Open") });
                        listMeetingsLv.Items.Add(lvi);

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

        public void AddMeetingToList(MeetingProposal mp)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                listMeetingsLv.Items.Add(new ListViewItem(new string[] { mp.Topic,
                    mp.CoordinatorUsername, mp.MinAttendees.ToString(),
                    (mp.IsClosed ? "Booked" : "Pending") }));
            }));
        }

        private void listMeetingsLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            SlotsLv.Items.Clear();
            InviteesLv.Items.Clear();

            if (listMeetingsLv.SelectedItems == null ||
                listMeetingsLv.SelectedItems.Count == 0 ||
                listMeetingsLv.SelectedItems[0] == null ||
                listMeetingsLv.SelectedItems[0].Text == "")
            {
                return;
            }

            string topic = listMeetingsLv.SelectedItems[0].Text;

            try
            {
                MeetingProposal mp = Client.server.GetMeeting(Client.Username, topic);

                foreach (Slot slot in mp.Slots)
                {
                    var lvi = new ListViewItem(new string[] { slot.date.ToString("yyyy-MM-dd"), slot.location });
                    SlotsLv.Items.Add(lvi);
                }
                foreach (string invitee in mp.Invitees)
                {
                    InviteesLv.Items.Add(new ListViewItem(invitee));
                }
                foreach (string attendee in mp.ClientsJoined.Keys)
                {
                    InviteesLv.Items.Add(new ListViewItem(attendee));
                }
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Lost connection to the server.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
