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
            this.MeetingsLb = new System.Windows.Forms.Label();
            this.ListMeetingsLv = new System.Windows.Forms.ListView();
            this.goToBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeetingsLb
            // 
            this.MeetingsLb.AutoSize = true;
            this.MeetingsLb.BackColor = System.Drawing.Color.Transparent;
            this.MeetingsLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MeetingsLb.Location = new System.Drawing.Point(128, 67);
            this.MeetingsLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MeetingsLb.Name = "MeetingsLb";
            this.MeetingsLb.Size = new System.Drawing.Size(53, 13);
            this.MeetingsLb.TabIndex = 9;
            this.MeetingsLb.Text = "Meetings:";
            // 
            // ListMeetingsLv
            // 
            this.ListMeetingsLv.FullRowSelect = true;
            this.ListMeetingsLv.GridLines = true;
            this.ListMeetingsLv.HideSelection = false;
            this.ListMeetingsLv.Location = new System.Drawing.Point(38, 92);
            this.ListMeetingsLv.Margin = new System.Windows.Forms.Padding(2);
            this.ListMeetingsLv.Name = "ListMeetingsLv";
            this.ListMeetingsLv.Size = new System.Drawing.Size(250, 148);
            this.ListMeetingsLv.TabIndex = 8;
            this.ListMeetingsLv.UseCompatibleStateImageBehavior = false;
            this.ListMeetingsLv.View = System.Windows.Forms.View.List;
            // 
            // goToBackButton
            // 
            this.goToBackButton.Location = new System.Drawing.Point(276, 332);
            this.goToBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.goToBackButton.Name = "goToBackButton";
            this.goToBackButton.Size = new System.Drawing.Size(56, 19);
            this.goToBackButton.TabIndex = 7;
            this.goToBackButton.Text = "Back";
            this.goToBackButton.UseVisualStyleBackColor = true;
            this.goToBackButton.Click += new System.EventHandler(this.goToBackButton_Click);
            // 
            // ListMeetingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.MeetingsLb);
            this.Controls.Add(this.ListMeetingsLv);
            this.Controls.Add(this.goToBackButton);
            this.Name = "ListMeetingPage";
            this.Size = new System.Drawing.Size(349, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MeetingsLb;
        private System.Windows.Forms.ListView ListMeetingsLv;
        private System.Windows.Forms.Button goToBackButton;
    }
}
