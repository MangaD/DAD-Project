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
            this.components = new System.ComponentModel.Container();
            this.InviteUserBtn = new System.Windows.Forms.Button();
            this.InviteesLv = new System.Windows.Forms.ListView();
            this.InviteesLb = new System.Windows.Forms.Label();
            this.SlotsLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.slotsLbl = new System.Windows.Forms.Label();
            this.DateLb = new System.Windows.Forms.Label();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.minPartLb = new System.Windows.Forms.Label();
            this.topicTb = new System.Windows.Forms.TextBox();
            this.topicLbl = new System.Windows.Forms.Label();
            this.MinPartNud = new System.Windows.Forms.NumericUpDown();
            this.CreateMeetingButton = new System.Windows.Forms.Button();
            this.inviteesCB = new System.Windows.Forms.ComboBox();
            this.locationCB = new System.Windows.Forms.ComboBox();
            this.AddSlotBtn = new System.Windows.Forms.Button();
            this.locationLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.backLbl = new System.Windows.Forms.Label();
            this.slotsCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inviteesCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeSlot = new System.Windows.Forms.ToolStripMenuItem();
            this.removeInvitee = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MinPartNud)).BeginInit();
            this.slotsCMS.SuspendLayout();
            this.inviteesCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // InviteUserBtn
            // 
            this.InviteUserBtn.BackColor = System.Drawing.Color.LightGray;
            this.InviteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InviteUserBtn.Location = new System.Drawing.Point(216, 280);
            this.InviteUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.InviteUserBtn.Name = "InviteUserBtn";
            this.InviteUserBtn.Size = new System.Drawing.Size(116, 23);
            this.InviteUserBtn.TabIndex = 7;
            this.InviteUserBtn.Text = "Invite User";
            this.InviteUserBtn.UseVisualStyleBackColor = false;
            this.InviteUserBtn.Click += new System.EventHandler(this.InviteUserBtn_Click);
            // 
            // InviteesLv
            // 
            this.InviteesLv.FullRowSelect = true;
            this.InviteesLv.GridLines = true;
            this.InviteesLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.InviteesLv.HideSelection = false;
            this.InviteesLv.Location = new System.Drawing.Point(216, 158);
            this.InviteesLv.Margin = new System.Windows.Forms.Padding(2);
            this.InviteesLv.Name = "InviteesLv";
            this.InviteesLv.Size = new System.Drawing.Size(116, 95);
            this.InviteesLv.TabIndex = 35;
            this.InviteesLv.UseCompatibleStateImageBehavior = false;
            this.InviteesLv.View = System.Windows.Forms.View.Details;
            this.InviteesLv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InviteesLv_MouseClick);
            // 
            // InviteesLb
            // 
            this.InviteesLb.AutoSize = true;
            this.InviteesLb.BackColor = System.Drawing.Color.Transparent;
            this.InviteesLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InviteesLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.InviteesLb.Location = new System.Drawing.Point(213, 143);
            this.InviteesLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InviteesLb.Name = "InviteesLb";
            this.InviteesLb.Size = new System.Drawing.Size(56, 13);
            this.InviteesLb.TabIndex = 33;
            this.InviteesLb.Text = "Invitees:";
            // 
            // SlotsLv
            // 
            this.SlotsLv.AllowColumnReorder = true;
            this.SlotsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SlotsLv.FullRowSelect = true;
            this.SlotsLv.GridLines = true;
            this.SlotsLv.HideSelection = false;
            this.SlotsLv.Location = new System.Drawing.Point(20, 158);
            this.SlotsLv.Margin = new System.Windows.Forms.Padding(2);
            this.SlotsLv.Name = "SlotsLv";
            this.SlotsLv.Size = new System.Drawing.Size(192, 95);
            this.SlotsLv.TabIndex = 31;
            this.SlotsLv.UseCompatibleStateImageBehavior = false;
            this.SlotsLv.View = System.Windows.Forms.View.Details;
            this.SlotsLv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SlotsLv_MouseClick);
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
            // slotsLbl
            // 
            this.slotsLbl.AutoSize = true;
            this.slotsLbl.BackColor = System.Drawing.Color.Transparent;
            this.slotsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotsLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.slotsLbl.Location = new System.Drawing.Point(17, 143);
            this.slotsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.slotsLbl.Name = "slotsLbl";
            this.slotsLbl.Size = new System.Drawing.Size(39, 13);
            this.slotsLbl.TabIndex = 30;
            this.slotsLbl.Text = "Slots:";
            // 
            // DateLb
            // 
            this.DateLb.AutoSize = true;
            this.DateLb.BackColor = System.Drawing.Color.Transparent;
            this.DateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DateLb.Location = new System.Drawing.Point(17, 263);
            this.DateLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLb.Name = "DateLb";
            this.DateLb.Size = new System.Drawing.Size(38, 13);
            this.DateLb.TabIndex = 29;
            this.DateLb.Text = "Date:";
            // 
            // DateDTP
            // 
            this.DateDTP.CustomFormat = "yyyy-MM-dd";
            this.DateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDTP.Location = new System.Drawing.Point(82, 257);
            this.DateDTP.Margin = new System.Windows.Forms.Padding(2);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.Size = new System.Drawing.Size(82, 20);
            this.DateDTP.TabIndex = 3;
            // 
            // minPartLb
            // 
            this.minPartLb.AutoSize = true;
            this.minPartLb.BackColor = System.Drawing.Color.Transparent;
            this.minPartLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPartLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.minPartLb.Location = new System.Drawing.Point(17, 115);
            this.minPartLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minPartLb.Name = "minPartLb";
            this.minPartLb.Size = new System.Drawing.Size(129, 13);
            this.minPartLb.TabIndex = 27;
            this.minPartLb.Text = "Minimum participants:";
            // 
            // topicTb
            // 
            this.topicTb.Location = new System.Drawing.Point(64, 84);
            this.topicTb.Margin = new System.Windows.Forms.Padding(2);
            this.topicTb.Name = "topicTb";
            this.topicTb.Size = new System.Drawing.Size(268, 20);
            this.topicTb.TabIndex = 1;
            // 
            // topicLbl
            // 
            this.topicLbl.AutoSize = true;
            this.topicLbl.BackColor = System.Drawing.Color.Transparent;
            this.topicLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.topicLbl.Location = new System.Drawing.Point(17, 87);
            this.topicLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topicLbl.Name = "topicLbl";
            this.topicLbl.Size = new System.Drawing.Size(43, 13);
            this.topicLbl.TabIndex = 25;
            this.topicLbl.Text = "Topic:";
            // 
            // MinPartNud
            // 
            this.MinPartNud.Location = new System.Drawing.Point(150, 113);
            this.MinPartNud.Margin = new System.Windows.Forms.Padding(2);
            this.MinPartNud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MinPartNud.Name = "MinPartNud";
            this.MinPartNud.Size = new System.Drawing.Size(182, 20);
            this.MinPartNud.TabIndex = 2;
            // 
            // CreateMeetingButton
            // 
            this.CreateMeetingButton.BackColor = System.Drawing.Color.LightGray;
            this.CreateMeetingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMeetingButton.Location = new System.Drawing.Point(119, 316);
            this.CreateMeetingButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateMeetingButton.Name = "CreateMeetingButton";
            this.CreateMeetingButton.Size = new System.Drawing.Size(125, 35);
            this.CreateMeetingButton.TabIndex = 8;
            this.CreateMeetingButton.Text = "Create Meeting";
            this.CreateMeetingButton.UseVisualStyleBackColor = false;
            this.CreateMeetingButton.Click += new System.EventHandler(this.CreateMeetingButton_Click);
            // 
            // inviteesCB
            // 
            this.inviteesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inviteesCB.FormattingEnabled = true;
            this.inviteesCB.Location = new System.Drawing.Point(216, 256);
            this.inviteesCB.Name = "inviteesCB";
            this.inviteesCB.Size = new System.Drawing.Size(116, 21);
            this.inviteesCB.TabIndex = 6;
            // 
            // locationCB
            // 
            this.locationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationCB.FormattingEnabled = true;
            this.locationCB.Location = new System.Drawing.Point(82, 282);
            this.locationCB.Name = "locationCB";
            this.locationCB.Size = new System.Drawing.Size(82, 21);
            this.locationCB.TabIndex = 4;
            // 
            // AddSlotBtn
            // 
            this.AddSlotBtn.BackColor = System.Drawing.Color.LightGray;
            this.AddSlotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSlotBtn.Location = new System.Drawing.Point(169, 257);
            this.AddSlotBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddSlotBtn.Name = "AddSlotBtn";
            this.AddSlotBtn.Size = new System.Drawing.Size(43, 46);
            this.AddSlotBtn.TabIndex = 5;
            this.AddSlotBtn.Text = "Add Slot";
            this.AddSlotBtn.UseVisualStyleBackColor = false;
            this.AddSlotBtn.Click += new System.EventHandler(this.AddSlotBtn_Click);
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.BackColor = System.Drawing.Color.Transparent;
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.locationLbl.Location = new System.Drawing.Point(17, 285);
            this.locationLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(60, 13);
            this.locationLbl.TabIndex = 40;
            this.locationLbl.Text = "Location:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLbl.Location = new System.Drawing.Point(41, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(267, 47);
            this.titleLbl.TabIndex = 41;
            this.titleLbl.Text = "Create Meeting";
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.BackColor = System.Drawing.Color.Transparent;
            this.backLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backLbl.Location = new System.Drawing.Point(17, 336);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(38, 15);
            this.backLbl.TabIndex = 9;
            this.backLbl.Text = "Back";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // slotsCMS
            // 
            this.slotsCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSlot});
            this.slotsCMS.Name = "slotsCMS";
            this.slotsCMS.Size = new System.Drawing.Size(118, 26);
            // 
            // inviteesCMS
            // 
            this.inviteesCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeInvitee});
            this.inviteesCMS.Name = "inviteesCMS";
            this.inviteesCMS.Size = new System.Drawing.Size(118, 26);
            // 
            // removeSlot
            // 
            this.removeSlot.Name = "removeSlot";
            this.removeSlot.Size = new System.Drawing.Size(117, 22);
            this.removeSlot.Text = "Remove";
            this.removeSlot.Click += new System.EventHandler(this.removeSlot_Click);
            // 
            // removeInvitee
            // 
            this.removeInvitee.Name = "removeInvitee";
            this.removeInvitee.Size = new System.Drawing.Size(117, 22);
            this.removeInvitee.Text = "Remove";
            this.removeInvitee.Click += new System.EventHandler(this.removeInvitee_Click);
            // 
            // CreateMeetingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.locationCB);
            this.Controls.Add(this.inviteesCB);
            this.Controls.Add(this.InviteUserBtn);
            this.Controls.Add(this.InviteesLv);
            this.Controls.Add(this.InviteesLb);
            this.Controls.Add(this.AddSlotBtn);
            this.Controls.Add(this.SlotsLv);
            this.Controls.Add(this.slotsLbl);
            this.Controls.Add(this.DateLb);
            this.Controls.Add(this.DateDTP);
            this.Controls.Add(this.minPartLb);
            this.Controls.Add(this.topicTb);
            this.Controls.Add(this.topicLbl);
            this.Controls.Add(this.MinPartNud);
            this.Controls.Add(this.CreateMeetingButton);
            this.Name = "CreateMeetingPage";
            this.Size = new System.Drawing.Size(349, 366);
            ((System.ComponentModel.ISupportInitialize)(this.MinPartNud)).EndInit();
            this.slotsCMS.ResumeLayout(false);
            this.inviteesCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InviteUserBtn;
        private System.Windows.Forms.ListView InviteesLv;
        private System.Windows.Forms.Label InviteesLb;
        private System.Windows.Forms.ListView SlotsLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label slotsLbl;
        private System.Windows.Forms.Label DateLb;
        private System.Windows.Forms.DateTimePicker DateDTP;
        private System.Windows.Forms.Label minPartLb;
        private System.Windows.Forms.TextBox topicTb;
        private System.Windows.Forms.Label topicLbl;
        private System.Windows.Forms.NumericUpDown MinPartNud;
        private System.Windows.Forms.Button CreateMeetingButton;
        private System.Windows.Forms.ComboBox inviteesCB;
        private System.Windows.Forms.ComboBox locationCB;
        private System.Windows.Forms.Button AddSlotBtn;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label backLbl;
        private System.Windows.Forms.ContextMenuStrip slotsCMS;
        private System.Windows.Forms.ContextMenuStrip inviteesCMS;
        private System.Windows.Forms.ToolStripMenuItem removeSlot;
        private System.Windows.Forms.ToolStripMenuItem removeInvitee;
    }
}
