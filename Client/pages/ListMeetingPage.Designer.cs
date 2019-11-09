namespace MSDAD_CLI.pages
{
    partial class ListMeetingPage
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
            this.listMeetingsLv = new System.Windows.Forms.ListView();
            this.topicHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coordinatorHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minimumAttendeesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleLbl = new System.Windows.Forms.Label();
            this.backLbl = new System.Windows.Forms.Label();
            this.InviteesLb = new System.Windows.Forms.Label();
            this.slotsLbl = new System.Windows.Forms.Label();
            this.meetingsLbl = new System.Windows.Forms.Label();
            this.InviteesLv = new System.Windows.Forms.ListView();
            this.SlotsLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attendeesLv = new System.Windows.Forms.ListView();
            this.attendeesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listMeetingsLv
            // 
            this.listMeetingsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.topicHeader,
            this.coordinatorHeader,
            this.minimumAttendeesHeader,
            this.statusHeader});
            this.listMeetingsLv.FullRowSelect = true;
            this.listMeetingsLv.GridLines = true;
            this.listMeetingsLv.HideSelection = false;
            this.listMeetingsLv.Location = new System.Drawing.Point(20, 106);
            this.listMeetingsLv.Margin = new System.Windows.Forms.Padding(2);
            this.listMeetingsLv.MultiSelect = false;
            this.listMeetingsLv.Name = "listMeetingsLv";
            this.listMeetingsLv.Size = new System.Drawing.Size(307, 103);
            this.listMeetingsLv.TabIndex = 1;
            this.listMeetingsLv.UseCompatibleStateImageBehavior = false;
            this.listMeetingsLv.View = System.Windows.Forms.View.Details;
            this.listMeetingsLv.SelectedIndexChanged += new System.EventHandler(this.listMeetingsLv_SelectedIndexChanged);
            // 
            // topicHeader
            // 
            this.topicHeader.Text = "Topic";
            this.topicHeader.Width = 70;
            // 
            // coordinatorHeader
            // 
            this.coordinatorHeader.Text = "Coordinator";
            this.coordinatorHeader.Width = 70;
            // 
            // minimumAttendeesHeader
            // 
            this.minimumAttendeesHeader.Text = "Min. Attendees";
            this.minimumAttendeesHeader.Width = 90;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLbl.Location = new System.Drawing.Point(60, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(230, 47);
            this.titleLbl.TabIndex = 42;
            this.titleLbl.Text = "Meetings List";
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
            this.backLbl.TabIndex = 2;
            this.backLbl.Text = "Back";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // InviteesLb
            // 
            this.InviteesLb.AutoSize = true;
            this.InviteesLb.BackColor = System.Drawing.Color.Transparent;
            this.InviteesLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InviteesLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.InviteesLb.Location = new System.Drawing.Point(186, 223);
            this.InviteesLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InviteesLb.Name = "InviteesLb";
            this.InviteesLb.Size = new System.Drawing.Size(56, 13);
            this.InviteesLb.TabIndex = 45;
            this.InviteesLb.Text = "Invitees:";
            // 
            // slotsLbl
            // 
            this.slotsLbl.AutoSize = true;
            this.slotsLbl.BackColor = System.Drawing.Color.Transparent;
            this.slotsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotsLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.slotsLbl.Location = new System.Drawing.Point(17, 223);
            this.slotsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.slotsLbl.Name = "slotsLbl";
            this.slotsLbl.Size = new System.Drawing.Size(39, 13);
            this.slotsLbl.TabIndex = 44;
            this.slotsLbl.Text = "Slots:";
            // 
            // meetingsLbl
            // 
            this.meetingsLbl.AutoSize = true;
            this.meetingsLbl.BackColor = System.Drawing.Color.Transparent;
            this.meetingsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingsLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.meetingsLbl.Location = new System.Drawing.Point(17, 91);
            this.meetingsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.meetingsLbl.Name = "meetingsLbl";
            this.meetingsLbl.Size = new System.Drawing.Size(62, 13);
            this.meetingsLbl.TabIndex = 43;
            this.meetingsLbl.Text = "Meetings:";
            // 
            // InviteesLv
            // 
            this.InviteesLv.FullRowSelect = true;
            this.InviteesLv.GridLines = true;
            this.InviteesLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.InviteesLv.HideSelection = false;
            this.InviteesLv.Location = new System.Drawing.Point(189, 238);
            this.InviteesLv.Margin = new System.Windows.Forms.Padding(2);
            this.InviteesLv.Name = "InviteesLv";
            this.InviteesLv.Size = new System.Drawing.Size(69, 82);
            this.InviteesLv.TabIndex = 47;
            this.InviteesLv.UseCompatibleStateImageBehavior = false;
            this.InviteesLv.View = System.Windows.Forms.View.List;
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
            this.SlotsLv.Location = new System.Drawing.Point(20, 238);
            this.SlotsLv.Margin = new System.Windows.Forms.Padding(2);
            this.SlotsLv.Name = "SlotsLv";
            this.SlotsLv.Size = new System.Drawing.Size(165, 82);
            this.SlotsLv.TabIndex = 46;
            this.SlotsLv.UseCompatibleStateImageBehavior = false;
            this.SlotsLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 82;
            // 
            // attendeesLv
            // 
            this.attendeesLv.FullRowSelect = true;
            this.attendeesLv.GridLines = true;
            this.attendeesLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.attendeesLv.HideSelection = false;
            this.attendeesLv.Location = new System.Drawing.Point(262, 238);
            this.attendeesLv.Margin = new System.Windows.Forms.Padding(2);
            this.attendeesLv.Name = "attendeesLv";
            this.attendeesLv.Size = new System.Drawing.Size(65, 82);
            this.attendeesLv.TabIndex = 49;
            this.attendeesLv.UseCompatibleStateImageBehavior = false;
            this.attendeesLv.View = System.Windows.Forms.View.List;
            // 
            // attendeesLbl
            // 
            this.attendeesLbl.AutoSize = true;
            this.attendeesLbl.BackColor = System.Drawing.Color.Transparent;
            this.attendeesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendeesLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.attendeesLbl.Location = new System.Drawing.Point(259, 223);
            this.attendeesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.attendeesLbl.Name = "attendeesLbl";
            this.attendeesLbl.Size = new System.Drawing.Size(68, 13);
            this.attendeesLbl.TabIndex = 48;
            this.attendeesLbl.Text = "Attendees:";
            // 
            // ListMeetingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.attendeesLv);
            this.Controls.Add(this.attendeesLbl);
            this.Controls.Add(this.InviteesLv);
            this.Controls.Add(this.SlotsLv);
            this.Controls.Add(this.InviteesLb);
            this.Controls.Add(this.slotsLbl);
            this.Controls.Add(this.meetingsLbl);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.listMeetingsLv);
            this.Name = "ListMeetingPage";
            this.Size = new System.Drawing.Size(349, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listMeetingsLv;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label backLbl;
        private System.Windows.Forms.ColumnHeader topicHeader;
        private System.Windows.Forms.ColumnHeader coordinatorHeader;
        private System.Windows.Forms.ColumnHeader minimumAttendeesHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.Label InviteesLb;
        private System.Windows.Forms.Label slotsLbl;
        private System.Windows.Forms.Label meetingsLbl;
        private System.Windows.Forms.ListView InviteesLv;
        private System.Windows.Forms.ListView SlotsLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView attendeesLv;
        private System.Windows.Forms.Label attendeesLbl;
    }
}
