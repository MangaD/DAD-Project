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
                    List<MeetingProposal> MeetingsList = null;
                    try
                    {
                        MeetingsList = Client.server.ListMeetings(Client.Username, false, false, false);
                    }
                    catch (System.Net.Sockets.SocketException)
                    {
                        for (int i = 0; i < Client.serverReplicasList.Count; i++)
                        {
                            try
                            {
                                Client.serverReplicasList[i].ListMeetings(Client.Username, false, false, false);
                                MessageBox.Show("Replica n: " + i + " listed meetings!");
                                Client.server = Client.serverReplicasList[i];

                            }
                            catch (System.Net.Sockets.SocketException)
                            {
                                MessageBox.Show("Server n: " + i + " is Down!");
                            }
                        }
                    }

                    foreach (MeetingProposal mp in MeetingsList)
                    {
                        string state = "";

                        if (mp.Status == MeetingProposal.StatusEnum.Open)
                        {
                            state = "Open";
                        }
                        else if (mp.Status == MeetingProposal.StatusEnum.Closed)
                        {
                            state = "Closed";
                        }
                        else if (mp.Status == MeetingProposal.StatusEnum.Cancelled)
                        {
                            state = "Cancelled";
                        }

                        string bookedSlot = (mp.BookedSlot == null ||
                            mp.BookedSlot.location == null ||
                            mp.BookedSlot.location == "" ? "" : mp.BookedSlot.ToString());
                        string bookedRoom = (mp.BookedRoom == null ||
                            mp.BookedRoom.Name == null ||
                            mp.BookedRoom.Name == "" ? "" : mp.BookedRoom.Name);

                        listMeetingsLv.Items.Add(new ListViewItem(new string[] { mp.Topic,
                            mp.CoordinatorUsername, mp.MinAttendees.ToString(),
                            state, bookedSlot, bookedRoom }));

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

        public void RemoveMeetingFromList(MeetingProposal mp)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                foreach (ListViewItem item in listMeetingsLv.Items)
                {
                    if (item.Text.Contains(mp.Topic))
                    {
                        listMeetingsLv.Items.Remove(item);
                    }
                }
            }));
        }

        public void AddMeetingToList(MeetingProposal mp)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                string state = "";

                if (mp.Status == MeetingProposal.StatusEnum.Open)
                {
                    state = "Open";
                }
                else if (mp.Status == MeetingProposal.StatusEnum.Closed)
                {
                    state = "Closed";
                }
                else if (mp.Status == MeetingProposal.StatusEnum.Cancelled)
                {
                    state = "Cancelled";
                }

                string bookedSlot = (mp.BookedSlot == null ||
                    mp.BookedSlot.location == null ||
                    mp.BookedSlot.location == "" ? "" : mp.BookedSlot.ToString());
                string bookedRoom = (mp.BookedRoom == null ||
                    mp.BookedRoom.Name == null ||
                    mp.BookedRoom.Name == "" ? "" : mp.BookedRoom.Name);

                listMeetingsLv.Items.Add(new ListViewItem(new string[] { mp.Topic,
                    mp.CoordinatorUsername, mp.MinAttendees.ToString(),
                    state, bookedSlot, bookedRoom }));
            }));
        }

        private void listMeetingsLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            SlotsLv.Items.Clear();
            InviteesLv.Items.Clear();
            attendeesLv.Items.Clear();

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
                MeetingProposal mp = null;
                try
                {
                    mp = Client.server.GetMeeting(Client.Username, topic);
                }
                catch (System.Net.Sockets.SocketException)
                {
                    for (int i = 0; i < Client.serverReplicasList.Count; i++)
                    {
                        try
                        {
                            mp = Client.serverReplicasList[i].GetMeeting(Client.Username, topic);
                            Client.server = Client.serverReplicasList[i];
                        }
                        catch (System.Net.Sockets.SocketException)
                        {
                            MessageBox.Show("Server n: " + i + " is Down!");
                        }
                    }
                }

                if (mp.Slots != null)
                {
                    foreach (Slot slot in mp.Slots)
                    {
                        var lvi = new ListViewItem(new string[] { slot.date.ToString("yyyy-MM-dd"), slot.location });
                        SlotsLv.Items.Add(lvi);
                    }
                }
                if (mp.Invitees != null)
                {
                    foreach (string invitee in mp.Invitees)
                    {
                        InviteesLv.Items.Add(new ListViewItem(invitee));
                    }
                }
                if (mp.ClientsJoined != null)
                {
                    foreach (string attendee in mp.ClientsJoined.Keys)
                    {
                        string admission;
                        bool accepted = (mp.ClientsAccepted != null && mp.ClientsAccepted.ContainsKey(attendee));


                        if (mp.Status == MeetingProposal.StatusEnum.Closed && accepted)
                        {
                            admission = "Accepted";
                        }
                        else if (mp.Status == MeetingProposal.StatusEnum.Closed && !accepted)
                        {
                            admission = "Rejected";
                        }
                        else
                        {
                            admission = "Pending";
                        }

                        attendeesLv.Items.Add(new ListViewItem(new string[] { attendee, admission }));
                    }
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
