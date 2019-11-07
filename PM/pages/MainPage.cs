using System;
using System.IO;
using System.Windows.Forms;

namespace PM.pages
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer |
                ControlStyles.SupportsTransparentBackColor, true);
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
            Program.mainForm.switchPage(Program.mainForm.createServerPage);
        }

        private void createCliBtn_Click(object sender, EventArgs e)
        {
            Program.mainForm.switchPage(Program.mainForm.createClientPage);
        }

        private void manageServersLbl_Click(object sender, EventArgs e)
        {
            Program.mainForm.switchPage(Program.mainForm.manageServersPage);
        }
    }
}
