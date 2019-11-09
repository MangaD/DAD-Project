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
            this.titleLbl = new System.Windows.Forms.Label();
            this.backLbl = new System.Windows.Forms.Label();
            this.topicHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coordinatorHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minimumParticipantsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listMeetingsLv
            // 
            this.listMeetingsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.topicHeader,
            this.coordinatorHeader,
            this.minimumParticipantsHeader});
            this.listMeetingsLv.FullRowSelect = true;
            this.listMeetingsLv.GridLines = true;
            this.listMeetingsLv.HideSelection = false;
            this.listMeetingsLv.Location = new System.Drawing.Point(20, 96);
            this.listMeetingsLv.Margin = new System.Windows.Forms.Padding(2);
            this.listMeetingsLv.Name = "listMeetingsLv";
            this.listMeetingsLv.Size = new System.Drawing.Size(307, 204);
            this.listMeetingsLv.TabIndex = 1;
            this.listMeetingsLv.UseCompatibleStateImageBehavior = false;
            this.listMeetingsLv.View = System.Windows.Forms.View.Details;
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
            // topicHeader
            // 
            this.topicHeader.Text = "Topic";
            this.topicHeader.Width = 100;
            // 
            // coordinatorHeader
            // 
            this.coordinatorHeader.Text = "Coordinator";
            this.coordinatorHeader.Width = 100;
            // 
            // minimumParticipantsHeader
            // 
            this.minimumParticipantsHeader.Text = "Min. Participants";
            this.minimumParticipantsHeader.Width = 90;
            // 
            // ListMeetingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
        private System.Windows.Forms.ColumnHeader minimumParticipantsHeader;
    }
}
