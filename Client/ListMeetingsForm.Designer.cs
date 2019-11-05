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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.ListMeetingsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListMeetingsLv.FullRowSelect = true;
            this.ListMeetingsLv.GridLines = true;
            this.ListMeetingsLv.HideSelection = false;
            this.ListMeetingsLv.Location = new System.Drawing.Point(50, 80);
            this.ListMeetingsLv.Name = "ListMeetingsLv";
            this.ListMeetingsLv.Size = new System.Drawing.Size(332, 181);
            this.ListMeetingsLv.TabIndex = 5;
            this.ListMeetingsLv.UseCompatibleStateImageBehavior = false;
            this.ListMeetingsLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Topic";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Min Participants";
            this.columnHeader2.Width = 109;
            // 
            // ListMeetingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.ListMeetingsLv);
            this.Controls.Add(this.goToBackButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListMeetingsForm";
            this.Text = "List Meetings";
            this.Load += new System.EventHandler(this.ListMeetingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goToBackButton;
        private System.Windows.Forms.ListView ListMeetingsLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}