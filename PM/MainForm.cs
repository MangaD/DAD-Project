using System;
using System.Windows.Forms;

using API;

namespace PM
{
    public partial class MainForm : Form
    {
        IPCS pcs;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pcs = (IPCS)Activator.GetObject(typeof(IPCS), "tcp://localhost:50000/MSPCS");
        }

        private void loadScriptLbl_Click(object sender, EventArgs e)
        {
            openScriptDialog.ShowDialog();
            if (openScriptDialog.FileName != "")
            {
                MessageBox.Show("You've selected: " + openScriptDialog.FileName);
                Parser p = new Parser(openScriptDialog.FileName);
                p.Parse();
                p.ExecCommands();
            }
        }

        private void createSrvBtn_Click(object sender, EventArgs e)
        {
            //TODO this is just an example of a method call
            pcs.StartServer("oi", "ola", 2, 2, 2);
        }

    }
}
