using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Client.server.CreateMeeting(Client.ClientRA.ToString(), TopicTb.Text, Convert.ToUInt16(MinPartNud.Value), null, null);
        }

    }
}
