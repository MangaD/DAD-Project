using System;
using System.Windows.Forms;

using API;

namespace PM
{
    public partial class ManageServersForm : Form
    {
        public ManageServersForm()
        {
            InitializeComponent();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            FormUtilities.switchForm(this, Program.formUtilities.mainForm);
        }

        public void AddServerToList(string serverID)
        {
            serverListBox.Items.Add(serverID);
        }

    }
}
