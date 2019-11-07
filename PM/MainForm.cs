using System.Drawing;
using System.Windows.Forms;

using PM.pages;

namespace PM
{
    public partial class MainForm : Form
    {
        public MainPage mainPage = new MainPage();
        public CreateServerPage createServerPage = new CreateServerPage();
        public CreateClientPage createClientPage = new CreateClientPage();
        public ManageServersPage manageServersPage = new ManageServersPage();

        public MainForm()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            setPageAttributes(mainPage);
            setPageAttributes(createServerPage);
            setPageAttributes(createClientPage);
            setPageAttributes(manageServersPage);

            switchPage(mainPage);
        }

        private void setPageAttributes(UserControl page)
        {
            page.BackColor = Color.Transparent;
            page.Dock = DockStyle.Fill;
        }

        public void switchPage(UserControl page)
        {
            pagesPanel.Controls.Clear();
            pagesPanel.Controls.Add(page);
        }

    }
}
