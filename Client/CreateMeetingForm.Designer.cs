namespace MSDAD_CLI
{
    partial class CreateMeetingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.goToBackButton = new System.Windows.Forms.Button();
            this.CreateMeetingButton = new System.Windows.Forms.Button();
            this.MinPartNud = new System.Windows.Forms.NumericUpDown();
            this.TopicLb = new System.Windows.Forms.Label();
            this.TopicTb = new System.Windows.Forms.TextBox();
            this.MinPartLb = new System.Windows.Forms.Label();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.LocationTB = new System.Windows.Forms.TextBox();
            this.DateLb = new System.Windows.Forms.Label();
            this.LocationLb = new System.Windows.Forms.Label();
            this.SlotsLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddSlotBtn = new System.Windows.Forms.Button();
            this.SlotsLb = new System.Windows.Forms.Label();
            this.InviteesLb = new System.Windows.Forms.Label();
            this.InviteesLBox = new System.Windows.Forms.ListBox();
            this.InviteesLv = new System.Windows.Forms.ListView();
            this.InviteUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MinPartNud)).BeginInit();
            this.SuspendLayout();
            // 
            // goToBackButton
            // 
            this.goToBackButton.Location = new System.Drawing.Point(376, 415);
            this.goToBackButton.Name = "goToBackButton";
            this.goToBackButton.Size = new System.Drawing.Size(75, 23);
            this.goToBackButton.TabIndex = 4;
            this.goToBackButton.Text = "Back";
            this.goToBackButton.UseVisualStyleBackColor = true;
            this.goToBackButton.Click += new System.EventHandler(this.goToBackButton_Click);
            // 
            // CreateMeetingButton
            // 
            this.CreateMeetingButton.Location = new System.Drawing.Point(117, 395);
            this.CreateMeetingButton.Name = "CreateMeetingButton";
            this.CreateMeetingButton.Size = new System.Drawing.Size(103, 43);
            this.CreateMeetingButton.TabIndex = 5;
            this.CreateMeetingButton.Text = "Create Meeting";
            this.CreateMeetingButton.UseVisualStyleBackColor = true;
            this.CreateMeetingButton.Click += new System.EventHandler(this.CreateMeetingButton_Click);
            // 
            // MinPartNud
            // 
            this.MinPartNud.Location = new System.Drawing.Point(349, 35);
            this.MinPartNud.Name = "MinPartNud";
            this.MinPartNud.Size = new System.Drawing.Size(102, 22);
            this.MinPartNud.TabIndex = 6;
            // 
            // TopicLb
            // 
            this.TopicLb.AutoSize = true;
            this.TopicLb.Location = new System.Drawing.Point(35, 32);
            this.TopicLb.Name = "TopicLb";
            this.TopicLb.Size = new System.Drawing.Size(47, 17);
            this.TopicLb.TabIndex = 7;
            this.TopicLb.Text = "Topic:";
            // 
            // TopicTb
            // 
            this.TopicTb.Location = new System.Drawing.Point(112, 35);
            this.TopicTb.Name = "TopicTb";
            this.TopicTb.Size = new System.Drawing.Size(135, 22);
            this.TopicTb.TabIndex = 8;
            // 
            // MinPartLb
            // 
            this.MinPartLb.AutoSize = true;
            this.MinPartLb.Location = new System.Drawing.Point(282, 37);
            this.MinPartLb.Name = "MinPartLb";
            this.MinPartLb.Size = new System.Drawing.Size(64, 17);
            this.MinPartLb.TabIndex = 9;
            this.MinPartLb.Text = "Min Part:";
            // 
            // DateDTP
            // 
            this.DateDTP.CustomFormat = "yyyy-MM-dd";
            this.DateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDTP.Location = new System.Drawing.Point(112, 91);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.Size = new System.Drawing.Size(130, 22);
            this.DateDTP.TabIndex = 10;
            // 
            // LocationTB
            // 
            this.LocationTB.Location = new System.Drawing.Point(112, 138);
            this.LocationTB.Name = "LocationTB";
            this.LocationTB.Size = new System.Drawing.Size(130, 22);
            this.LocationTB.TabIndex = 11;
            // 
            // DateLb
            // 
            this.DateLb.AutoSize = true;
            this.DateLb.Location = new System.Drawing.Point(38, 85);
            this.DateLb.Name = "DateLb";
            this.DateLb.Size = new System.Drawing.Size(42, 17);
            this.DateLb.TabIndex = 12;
            this.DateLb.Text = "Date:";
            // 
            // LocationLb
            // 
            this.LocationLb.AutoSize = true;
            this.LocationLb.Location = new System.Drawing.Point(39, 129);
            this.LocationLb.Name = "LocationLb";
            this.LocationLb.Size = new System.Drawing.Size(66, 17);
            this.LocationLb.TabIndex = 13;
            this.LocationLb.Text = "Location:";
            // 
            // SlotsLv
            // 
            this.SlotsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SlotsLv.HideSelection = false;
            this.SlotsLv.Location = new System.Drawing.Point(269, 91);
            this.SlotsLv.Name = "SlotsLv";
            this.SlotsLv.Size = new System.Drawing.Size(182, 116);
            this.SlotsLv.TabIndex = 14;
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
            // AddSlotBtn
            // 
            this.AddSlotBtn.Location = new System.Drawing.Point(112, 172);
            this.AddSlotBtn.Name = "AddSlotBtn";
            this.AddSlotBtn.Size = new System.Drawing.Size(130, 35);
            this.AddSlotBtn.TabIndex = 15;
            this.AddSlotBtn.Text = "Add Slot";
            this.AddSlotBtn.UseVisualStyleBackColor = true;
            this.AddSlotBtn.Click += new System.EventHandler(this.AddSlotBtn_Click);
            // 
            // SlotsLb
            // 
            this.SlotsLb.AutoSize = true;
            this.SlotsLb.Location = new System.Drawing.Point(346, 71);
            this.SlotsLb.Name = "SlotsLb";
            this.SlotsLb.Size = new System.Drawing.Size(39, 17);
            this.SlotsLb.TabIndex = 16;
            this.SlotsLb.Text = "Slots";
            // 
            // InviteesLb
            // 
            this.InviteesLb.AutoSize = true;
            this.InviteesLb.Location = new System.Drawing.Point(266, 230);
            this.InviteesLb.Name = "InviteesLb";
            this.InviteesLb.Size = new System.Drawing.Size(60, 17);
            this.InviteesLb.TabIndex = 17;
            this.InviteesLb.Text = "Invitees:";
            // 
            // InviteesLBox
            // 
            this.InviteesLBox.FormattingEnabled = true;
            this.InviteesLBox.ItemHeight = 16;
            this.InviteesLBox.Location = new System.Drawing.Point(112, 230);
            this.InviteesLBox.Name = "InviteesLBox";
            this.InviteesLBox.Size = new System.Drawing.Size(130, 116);
            this.InviteesLBox.TabIndex = 18;
            // 
            // InviteesLv
            // 
            this.InviteesLv.HideSelection = false;
            this.InviteesLv.Location = new System.Drawing.Point(366, 230);
            this.InviteesLv.Name = "InviteesLv";
            this.InviteesLv.Size = new System.Drawing.Size(83, 116);
            this.InviteesLv.TabIndex = 19;
            this.InviteesLv.UseCompatibleStateImageBehavior = false;
            this.InviteesLv.View = System.Windows.Forms.View.List;
            // 
            // InviteUserBtn
            // 
            this.InviteUserBtn.Location = new System.Drawing.Point(265, 287);
            this.InviteUserBtn.Name = "InviteUserBtn";
            this.InviteUserBtn.Size = new System.Drawing.Size(81, 49);
            this.InviteUserBtn.TabIndex = 20;
            this.InviteUserBtn.Text = "Invite User";
            this.InviteUserBtn.UseVisualStyleBackColor = true;
            this.InviteUserBtn.Click += new System.EventHandler(this.InviteUserBtn_Click);
            // 
            // CreateMeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.InviteUserBtn);
            this.Controls.Add(this.InviteesLv);
            this.Controls.Add(this.InviteesLBox);
            this.Controls.Add(this.InviteesLb);
            this.Controls.Add(this.SlotsLb);
            this.Controls.Add(this.AddSlotBtn);
            this.Controls.Add(this.SlotsLv);
            this.Controls.Add(this.LocationLb);
            this.Controls.Add(this.DateLb);
            this.Controls.Add(this.LocationTB);
            this.Controls.Add(this.DateDTP);
            this.Controls.Add(this.MinPartLb);
            this.Controls.Add(this.TopicTb);
            this.Controls.Add(this.TopicLb);
            this.Controls.Add(this.MinPartNud);
            this.Controls.Add(this.CreateMeetingButton);
            this.Controls.Add(this.goToBackButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateMeetingForm";
            this.Text = "Create Meeting";
            this.Load += new System.EventHandler(this.CreateMeetingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinPartNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToBackButton;
        private System.Windows.Forms.Button CreateMeetingButton;
        private System.Windows.Forms.NumericUpDown MinPartNud;
        private System.Windows.Forms.Label TopicLb;
        private System.Windows.Forms.TextBox TopicTb;
        private System.Windows.Forms.Label MinPartLb;
        private System.Windows.Forms.DateTimePicker DateDTP;
        private System.Windows.Forms.TextBox LocationTB;
        private System.Windows.Forms.Label DateLb;
        private System.Windows.Forms.Label LocationLb;
        private System.Windows.Forms.ListView SlotsLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button AddSlotBtn;
        private System.Windows.Forms.Label SlotsLb;
        private System.Windows.Forms.Label InviteesLb;
        private System.Windows.Forms.ListBox InviteesLBox;
        private System.Windows.Forms.ListView InviteesLv;
        private System.Windows.Forms.Button InviteUserBtn;
    }
}