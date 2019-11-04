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
    }
}
