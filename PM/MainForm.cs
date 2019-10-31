using System;
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
            if (openScriptDialog.FileName != "")
            {
                Parser p = new Parser(openScriptDialog.FileName);
                p.Parse();
                p.ExecCommands();
            }
        }

        private void createSrvBtn_Click(object sender, EventArgs e)
        {
            //TODO this is just an example of a method call
            //Program.pcs.StartServer("oi", "ola", 2, 2, 2);

            FormUtilities.switchForm(this, Program.formUtilities.createServerForm);
        }

        private void createCliBtn_Click(object sender, EventArgs e)
        {
            FormUtilities.switchForm(this, Program.formUtilities.createClientForm);
        }
    }
}
