using System;
using System.Windows.Forms;

using API;

namespace MSDAD_CLI
{
    public class ClientFormUtilities
    {
        public SignInForm signInForm;

        public MainForm mainForm;
        
        public ListMeetingsForm listMeetingsForm;
        public CreateMeetingForm createMeetingForm;
        public JoinMeetingForm joinMeetingForm;
        public CloseMeetingForm closeMeetingForm;

        public ClientFormUtilities()
        {
            signInForm = new SignInForm();

            mainForm = new MainForm();

            listMeetingsForm = new ListMeetingsForm();
            createMeetingForm = new CreateMeetingForm();
            joinMeetingForm = new JoinMeetingForm();
            closeMeetingForm = new CloseMeetingForm();

            setWindowAttributes(signInForm); 
            setWindowAttributes(listMeetingsForm);
            setWindowAttributes(createMeetingForm);
            setWindowAttributes(joinMeetingForm);
            setWindowAttributes(closeMeetingForm);
        }

        public void setWindowAttributes(Form form)
        {
            form.Width = mainForm.Width;
            form.Height = mainForm.Height;
            form.Icon = mainForm.Icon;
            form.BackgroundImage = mainForm.BackgroundImage;
            form.BackgroundImageLayout = mainForm.BackgroundImageLayout;
            form.Location = mainForm.Location;

            // Necessary so we can set the location of new form to the same as the old form
            form.StartPosition = FormStartPosition.Manual;

            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.FormClosed += new FormClosedEventHandler(onClose);
        }

        public void onClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void switchForm(Form formHide, Form formShow)
        {
            formShow.Location = formHide.Location;
            formHide.Hide();
            formShow.Show();
        }
        /*
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
        */
    }
}
