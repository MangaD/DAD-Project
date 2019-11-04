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
            List<string> TopicsList = Client.server.ListMeetings(Client.ClientRA.ToString());
            ListViewItem lvi = new ListViewItem();
            foreach(string topic in TopicsList)
            {
                lvi.SubItems.Add(topic);
                MessageBox.Show(topic);
            }
        }
    }
}
