using System;
using System.IO;
using System.Windows.Forms;

namespace PM
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }


        private void loadScriptLbl_Click(object sender, EventArgs e)
        {
            openScriptDialog.ShowDialog();
            if (openScriptDialog.FileName != "" && File.Exists(openScriptDialog.FileName))
            {
                Parser p = new Parser(openScriptDialog.FileName);
                p.Parse();
                p.ExecCommands();
            }
        }

        private void createSrvBtn_Click(object sender, EventArgs e)
        {
            FormUtilities.switchForm(this, Program.formUtilities.createServerForm);
        }

        private void createCliBtn_Click(object sender, EventArgs e)
        {
            FormUtilities.switchForm(this, Program.formUtilities.createClientForm);
        }

        private void manageServersLbl_Click(object sender, EventArgs e)
        {
            FormUtilities.switchForm(this, Program.formUtilities.manageServersForm);
        }
    }
}
