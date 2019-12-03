using System;
using System.Collections.Generic;
using System.Windows.Forms;

using API;

namespace MSDAD_CLI.pages
{
    public partial class CloseMeetingPage : UserControl
    {
        public CloseMeetingPage()
        {
            InitializeComponent();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            Client.mainForm.switchPage(Client.mainForm.mainPage);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                closeMeetingButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void goToBackButton_Click(object sender, EventArgs e)
        {
            Client.mainForm.switchPage(Client.mainForm.mainPage);
        }

        private void closeMeetingButton_Click(object sender, EventArgs e)
        {
            if (topicCB == null || topicCB.Text == null || topicCB.Text == "")
            {
                MessageBox.Show($"Must select a topic.");
                return;
            }

            try
            {
                try
                {
                    Client.server.CloseMeeting(topicCB.Text, Client.Username);
                }
                catch (Exception ex)
                {
                    for (int i = 0; i < Client.serverReplicasList.Count; i++)
                    {
                        try
                        {
                            Client.serverReplicasList[i].CloseMeeting(topicCB.Text, Client.Username);
                            MessageBox.Show("Replica n: " + i + " closed the meeting!");
                            Client.server = Client.serverReplicasList[i];

                        }
                        catch (Exception excep)
                        {
                            MessageBox.Show("Server n: " + i + " is Down!");
                        }
                    }
                }

                MessageBox.Show($"Meeting '{topicCB.Text}' was booked.");

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
        }

        public void FillTopicCB()
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                topicCB.Items.Clear();

                try
                {
                    List<MeetingProposal> MeetingsList = Client.server.ListMeetings(Client.Username, true, false, false);
                    foreach (MeetingProposal mp in MeetingsList)
                    {
                        topicCB.Items.Add(new ListViewItem(mp.Topic));
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

        public void AddMeetingToCB(string topic)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                topicCB.Items.Add(topic);
            }));
        }
    }
}
