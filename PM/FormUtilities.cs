using System;
using System.Drawing;
using System.Windows.Forms;

namespace PM
{
    class FormUtilities
    {
        public MainForm mainForm;
        public CreateServerForm createServerForm;
        public CreateClientForm createClientForm;

        public FormUtilities()
        {
            mainForm = new MainForm();

            createServerForm = new CreateServerForm();
            createClientForm = new CreateClientForm();
            setWindowAttributes(createServerForm);
            setWindowAttributes(createClientForm);
        }

        public void setWindowAttributes(Form form)
        {
            form.Text = mainForm.Text;
            form.Width = mainForm.Width;
            form.Height = mainForm.Height;
            form.Icon = mainForm.Icon;
            form.BackgroundImage = mainForm.BackgroundImage;
            form.BackgroundImageLayout = mainForm.BackgroundImageLayout;
            form.Location = mainForm.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.FormClosed += new FormClosedEventHandler(onClose);
        }

        public void onClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void switchForm(Form formHide, Form formShow)
        {
            formShow.Location = formHide.Location;
            formHide.Hide();
            formShow.Show();
        }
    }
}
