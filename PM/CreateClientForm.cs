using System;
using System.Windows.Forms;

namespace PM
{
    public partial class CreateClientForm : Form
    {
        public CreateClientForm()
        {
            InitializeComponent();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            FormUtilities.switchForm(this, Program.formUtilities.mainForm);
        }

        private void createCliBtn_Click(object sender, EventArgs e)
        {
            // TODO

            FormUtilities.switchForm(this, Program.formUtilities.mainForm);
        }
    }
}
