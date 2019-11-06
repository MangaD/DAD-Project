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
    public partial class ListMeetingsForm : Form
    {
        public ListMeetingsForm()
        {
            InitializeComponent();
        }

        private void goToBackButton_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.mainForm);
        }

        private void ListMeetingsForm_Load(object sender, EventArgs e)
        {
            List<MeetingProposal> MeetingsList = Client.server.ListMeetings(Client.Username);

            foreach (MeetingProposal mp in MeetingsList)
            {
                MessageBox.Show(mp.Topic);
                ListMeetingsLv.Items.Add(new ListViewItem(mp.Topic));
            }
        }
    }
}
