﻿using System;
using System.Windows.Forms;

namespace PM
{
    public partial class CreateServerForm : Form
    {
        public CreateServerForm()
        {
            InitializeComponent();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            FormUtilities.switchForm(this, Program.formUtilities.mainForm);
        }

        private void createSrvBtn_Click(object sender, EventArgs e)
        {
            // TODO

            FormUtilities.switchForm(this, Program.formUtilities.mainForm);
        }
    }
}
