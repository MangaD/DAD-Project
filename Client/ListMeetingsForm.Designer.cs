using System;

namespace MSDAD_CLI
{
    partial class ListMeetingsForm
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
            this.ListMeetingsLv = new System.Windows.Forms.ListView();
            this.MeetingsLb = new System.Windows.Forms.Label();
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
            // ListMeetingsLv
            // 
            this.ListMeetingsLv.FullRowSelect = true;
            this.ListMeetingsLv.GridLines = true;
            this.ListMeetingsLv.HideSelection = false;
            this.ListMeetingsLv.Location = new System.Drawing.Point(58, 119);
            this.ListMeetingsLv.Name = "ListMeetingsLv";
            this.ListMeetingsLv.Size = new System.Drawing.Size(332, 181);
            this.ListMeetingsLv.TabIndex = 5;
            this.ListMeetingsLv.UseCompatibleStateImageBehavior = false;
            this.ListMeetingsLv.View = System.Windows.Forms.View.List;
            // 
            // MeetingsLb
            // 
            this.MeetingsLb.AutoSize = true;
            this.MeetingsLb.Location = new System.Drawing.Point(179, 89);
            this.MeetingsLb.Name = "MeetingsLb";
            this.MeetingsLb.Size = new System.Drawing.Size(69, 17);
            this.MeetingsLb.TabIndex = 6;
            this.MeetingsLb.Text = "Meetings:";
            // 
            // ListMeetingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.MeetingsLb);
            this.Controls.Add(this.ListMeetingsLv);
            this.Controls.Add(this.goToBackButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListMeetingsForm";
            this.Text = "List Meetings";
            this.Load += new System.EventHandler(this.ListMeetingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToBackButton;
        private System.Windows.Forms.ListView ListMeetingsLv;
        private System.Windows.Forms.Label MeetingsLb;
    }
}