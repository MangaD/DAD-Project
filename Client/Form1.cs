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
using MSDAD_CLI;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        private Client myClient;

        //hardcoded for now
        private RemotingAddress clientRA;
        //hardcoded for now
        private RemotingAddress serverRA;

        public Form1()
        {
            InitializeComponent();
            myClient = new Client();
        }

        private void parserButton_Click(object sender, EventArgs e)
        {
            myClient.ParseFile();
        }
        private void listButton_Click(object sender, EventArgs e)
        {
            meetingsListTextBox.Text = string.Join("\n\r", myClient.ListMeetings().ToArray());
        }
        private void joinButton_Click(object sender, EventArgs e)
        {
            if (myClient != null) return;
            //TODO hardcoded for now
            clientRA = RemotingAddress.FromString("tcp://localhost:65001/MSClient");
            //TODO hardcoded for now
            serverRA = RemotingAddress.FromString("tcp://localhost:65000/MSServer");

            myClient.listenClient(clientRA.port, clientRA.channel);

            string clientName = nameTextBox.Text;
            if (clientName == null) return;
            myClient.connectToServer(serverRA.ToString(), clientName, clientRA.ToString());
        }

        private void meetProposalButton_Click(object sender, EventArgs e)
        {
            List<Slot> locations = new List<Slot>();
            string[] slotsLines = locationsTextBox.Lines;
            foreach (string line in slotsLines)
            {
                locations.Add(Slot.FromString(line));
            }

            myClient.JoinMeeting(topicTextBox.Text, (int) slotsNumberBox.Value, locations);
        }

        private void closeMeetButton_Click(object sender, EventArgs e)
        {
            myClient.CloseMeeting(topicTextBox.Text);
        }
    }
}
