using System.Drawing;
using System.Windows.Forms;

using MSDAD_CLI.pages;

namespace MSDAD_CLI
{
    public partial class MainForm : Form
    {
        public MainPage mainPage = new MainPage();
        public CreateMeetingPage createMeetingPage = new CreateMeetingPage();
        public JoinMeetingPage joinMeetingPage = new JoinMeetingPage();
        public CloseMeetingPage closeMeetingPage = new CloseMeetingPage();
        public ListMeetingPage listMeetingPage = new ListMeetingPage();

        public MainForm()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            setPageAttributes(mainPage);
            setPageAttributes(createMeetingPage);
            setPageAttributes(joinMeetingPage);
            setPageAttributes(closeMeetingPage);
            setPageAttributes(listMeetingPage);

            switchPage(mainPage);
        }

        private void setPageAttributes(UserControl page)
        {
            page.BackColor = Color.Transparent;
            page.Dock = DockStyle.Fill;

            // https://www.codeproject.com/Questions/549373/InvokeplusorplusBeginInvokepluscannotplusbepluscal
            if (!page.IsHandleCreated)
            {
                page.CreateControl();
            }
        }

        public void switchPage(UserControl page)
        {
            pagesPanel.Controls.Clear();
            pagesPanel.Controls.Add(page);
        }

        public void ResetAllControls(Control page)
        {
            foreach (Control control in page.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is ListView)
                {
                    ListView listView = (ListView)control;
                    if (listView.Items.Count > 0)
                        listView.Items.Clear();
                }

                if (control is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = 0;
                }
            }
        }

    }
}