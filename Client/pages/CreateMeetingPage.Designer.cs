namespace MSDAD_CLI.pages
{
    partial class CreateMeetingPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LocationLBox = new System.Windows.Forms.ListBox();
            this.InviteUserBtn = new System.Windows.Forms.Button();
            this.InviteesLv = new System.Windows.Forms.ListView();
            this.InviteesLBox = new System.Windows.Forms.ListBox();
            this.InviteesLb = new System.Windows.Forms.Label();
            this.AddSlotBtn = new System.Windows.Forms.Button();
            this.SlotsLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationLb = new System.Windows.Forms.Label();
            this.DateLb = new System.Windows.Forms.Label();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.MinPartLb = new System.Windows.Forms.Label();
            this.TopicTb = new System.Windows.Forms.TextBox();
            this.TopicLb = new System.Windows.Forms.Label();
            this.MinPartNud = new System.Windows.Forms.NumericUpDown();
            this.CreateMeetingButton = new System.Windows.Forms.Button();
            this.goToBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MinPartNud)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationLBox
            // 
            this.LocationLBox.FormattingEnabled = true;
            this.LocationLBox.Location = new System.Drawing.Point(77, 95);
            this.LocationLBox.Margin = new System.Windows.Forms.Padding(2);
            this.LocationLBox.Name = "LocationLBox";
            this.LocationLBox.Size = new System.Drawing.Size(99, 69);
            this.LocationLBox.TabIndex = 37;
            // 
            // InviteUserBtn
            // 
            this.InviteUserBtn.Location = new System.Drawing.Point(193, 228);
            this.InviteUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.InviteUserBtn.Name = "InviteUserBtn";
            this.InviteUserBtn.Size = new System.Drawing.Size(61, 40);
            this.InviteUserBtn.TabIndex = 36;
            this.InviteUserBtn.Text = "Invite User";
            this.InviteUserBtn.UseVisualStyleBackColor = true;
            this.InviteUserBtn.Click += new System.EventHandler(this.InviteUserBtn_Click);
            // 
            // InviteesLv
            // 
            this.InviteesLv.HideSelection = false;
            this.InviteesLv.Location = new System.Drawing.Point(268, 182);
            this.InviteesLv.Margin = new System.Windows.Forms.Padding(2);
            this.InviteesLv.Name = "InviteesLv";
            this.InviteesLv.Size = new System.Drawing.Size(63, 95);
            this.InviteesLv.TabIndex = 35;
            this.InviteesLv.UseCompatibleStateImageBehavior = false;
            this.InviteesLv.View = System.Windows.Forms.View.List;
            // 
            // InviteesLBox
            // 
            this.InviteesLBox.FormattingEnabled = true;
            this.InviteesLBox.Location = new System.Drawing.Point(78, 182);
            this.InviteesLBox.Margin = new System.Windows.Forms.Padding(2);
            this.InviteesLBox.Name = "InviteesLBox";
            this.InviteesLBox.Size = new System.Drawing.Size(98, 95);
            this.InviteesLBox.TabIndex = 34;
            // 
            // InviteesLb
            // 
            this.InviteesLb.AutoSize = true;
            this.InviteesLb.BackColor = System.Drawing.Color.Transparent;
            this.InviteesLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.InviteesLb.Location = new System.Drawing.Point(194, 182);
            this.InviteesLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InviteesLb.Name = "InviteesLb";
            this.InviteesLb.Size = new System.Drawing.Size(47, 13);
            this.InviteesLb.TabIndex = 33;
            this.InviteesLb.Text = "Invitees:";
            // 
            // AddSlotBtn
            // 
            this.AddSlotBtn.Location = new System.Drawing.Point(22, 126);
            this.AddSlotBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddSlotBtn.Name = "AddSlotBtn";
            this.AddSlotBtn.Size = new System.Drawing.Size(50, 37);
            this.AddSlotBtn.TabIndex = 32;
            this.AddSlotBtn.Text = "Add Slot";
            this.AddSlotBtn.UseVisualStyleBackColor = true;
            this.AddSlotBtn.Click += new System.EventHandler(this.AddSlotBtn_Click);
            // 
            // SlotsLv
            // 
            this.SlotsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SlotsLv.HideSelection = false;
            this.SlotsLv.Location = new System.Drawing.Point(196, 69);
            this.SlotsLv.Margin = new System.Windows.Forms.Padding(2);
            this.SlotsLv.Name = "SlotsLv";
            this.SlotsLv.Size = new System.Drawing.Size(138, 95);
            this.SlotsLv.TabIndex = 31;
            this.SlotsLv.UseCompatibleStateImageBehavior = false;
            this.SlotsLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 82;
            // 
            // LocationLb
            // 
            this.LocationLb.AutoSize = true;
            this.LocationLb.BackColor = System.Drawing.Color.Transparent;
            this.LocationLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LocationLb.Location = new System.Drawing.Point(23, 100);
            this.LocationLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LocationLb.Name = "LocationLb";
            this.LocationLb.Size = new System.Drawing.Size(51, 13);
            this.LocationLb.TabIndex = 30;
            this.LocationLb.Text = "Location:";
            // 
            // DateLb
            // 
            this.DateLb.AutoSize = true;
            this.DateLb.BackColor = System.Drawing.Color.Transparent;
            this.DateLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DateLb.Location = new System.Drawing.Point(22, 64);
            this.DateLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLb.Name = "DateLb";
            this.DateLb.Size = new System.Drawing.Size(33, 13);
            this.DateLb.TabIndex = 29;
            this.DateLb.Text = "Date:";
            // 
            // DateDTP
            // 
            this.DateDTP.CustomFormat = "yyyy-MM-dd";
            this.DateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDTP.Location = new System.Drawing.Point(78, 69);
            this.DateDTP.Margin = new System.Windows.Forms.Padding(2);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.Size = new System.Drawing.Size(98, 20);
            this.DateDTP.TabIndex = 28;
            // 
            // MinPartLb
            // 
            this.MinPartLb.AutoSize = true;
            this.MinPartLb.BackColor = System.Drawing.Color.Transparent;
            this.MinPartLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MinPartLb.Location = new System.Drawing.Point(206, 25);
            this.MinPartLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinPartLb.Name = "MinPartLb";
            this.MinPartLb.Size = new System.Drawing.Size(49, 13);
            this.MinPartLb.TabIndex = 27;
            this.MinPartLb.Text = "Min Part:";
            // 
            // TopicTb
            // 
            this.TopicTb.Location = new System.Drawing.Point(78, 23);
            this.TopicTb.Margin = new System.Windows.Forms.Padding(2);
            this.TopicTb.Name = "TopicTb";
            this.TopicTb.Size = new System.Drawing.Size(102, 20);
            this.TopicTb.TabIndex = 26;
            // 
            // TopicLb
            // 
            this.TopicLb.AutoSize = true;
            this.TopicLb.BackColor = System.Drawing.Color.Transparent;
            this.TopicLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TopicLb.Location = new System.Drawing.Point(20, 21);
            this.TopicLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TopicLb.Name = "TopicLb";
            this.TopicLb.Size = new System.Drawing.Size(37, 13);
            this.TopicLb.TabIndex = 25;
            this.TopicLb.Text = "Topic:";
            // 
            // MinPartNud
            // 
            this.MinPartNud.Location = new System.Drawing.Point(256, 23);
            this.MinPartNud.Margin = new System.Windows.Forms.Padding(2);
            this.MinPartNud.Name = "MinPartNud";
            this.MinPartNud.Size = new System.Drawing.Size(76, 20);
            this.MinPartNud.TabIndex = 24;
            // 
            // CreateMeetingButton
            // 
            this.CreateMeetingButton.Location = new System.Drawing.Point(82, 316);
            this.CreateMeetingButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateMeetingButton.Name = "CreateMeetingButton";
            this.CreateMeetingButton.Size = new System.Drawing.Size(77, 35);
            this.CreateMeetingButton.TabIndex = 23;
            this.CreateMeetingButton.Text = "Create Meeting";
            this.CreateMeetingButton.UseVisualStyleBackColor = true;
            this.CreateMeetingButton.Click += new System.EventHandler(this.CreateMeetingButton_Click);
            // 
            // goToBackButton
            // 
            this.goToBackButton.Location = new System.Drawing.Point(276, 332);
            this.goToBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.goToBackButton.Name = "goToBackButton";
            this.goToBackButton.Size = new System.Drawing.Size(56, 19);
            this.goToBackButton.TabIndex = 22;
            this.goToBackButton.Text = "Back";
            this.goToBackButton.UseVisualStyleBackColor = true;
            this.goToBackButton.Click += new System.EventHandler(this.goToBackButton_Click);
            // 
            // CreateMeetingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.LocationLBox);
            this.Controls.Add(this.InviteUserBtn);
            this.Controls.Add(this.InviteesLv);
            this.Controls.Add(this.InviteesLBox);
            this.Controls.Add(this.InviteesLb);
            this.Controls.Add(this.AddSlotBtn);
            this.Controls.Add(this.SlotsLv);
            this.Controls.Add(this.LocationLb);
            this.Controls.Add(this.DateLb);
            this.Controls.Add(this.DateDTP);
            this.Controls.Add(this.MinPartLb);
            this.Controls.Add(this.TopicTb);
            this.Controls.Add(this.TopicLb);
            this.Controls.Add(this.MinPartNud);
            this.Controls.Add(this.CreateMeetingButton);
            this.Controls.Add(this.goToBackButton);
            this.Name = "CreateMeetingPage";
            this.Size = new System.Drawing.Size(349, 366);
            ((System.ComponentModel.ISupportInitialize)(this.MinPartNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LocationLBox;
        private System.Windows.Forms.Button InviteUserBtn;
        private System.Windows.Forms.ListView InviteesLv;
        private System.Windows.Forms.ListBox InviteesLBox;
        private System.Windows.Forms.Label InviteesLb;
        private System.Windows.Forms.Button AddSlotBtn;
        private System.Windows.Forms.ListView SlotsLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label LocationLb;
        private System.Windows.Forms.Label DateLb;
        private System.Windows.Forms.DateTimePicker DateDTP;
        private System.Windows.Forms.Label MinPartLb;
        private System.Windows.Forms.TextBox TopicTb;
        private System.Windows.Forms.Label TopicLb;
        private System.Windows.Forms.NumericUpDown MinPartNud;
        private System.Windows.Forms.Button CreateMeetingButton;
        private System.Windows.Forms.Button goToBackButton;
    }
}
