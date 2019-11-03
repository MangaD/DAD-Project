﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void goToCreateMeetingButton_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.createMeetingForm);
        }

        private void goToJoinMeeting_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.joinMeetingForm);
        }

        private void goToCloseMeetingButton_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.closeMeetingForm);
        }

        private void goToListMeetingsButton_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.listMeetingsForm);
        }

        private void goToBackButton_Click(object sender, EventArgs e)
        {
            ClientFormUtilities.switchForm(this, Client.clientFormUtilities.signInForm);
        }
    }
}