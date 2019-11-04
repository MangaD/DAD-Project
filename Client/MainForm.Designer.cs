namespace MSDAD_CLI
{
    partial class MainForm
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
            this.goToCreateMeetingButton = new System.Windows.Forms.Button();
            this.goToJoinMeetingButton = new System.Windows.Forms.Button();
            this.goToCloseMeetingButton = new System.Windows.Forms.Button();
            this.goToListMeetingsButton = new System.Windows.Forms.Button();
            this.goToBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goToCreateMeetingButton
            // 
            this.goToCreateMeetingButton.Location = new System.Drawing.Point(12, 35);
            this.goToCreateMeetingButton.Name = "goToCreateMeetingButton";
            this.goToCreateMeetingButton.Size = new System.Drawing.Size(439, 49);
            this.goToCreateMeetingButton.TabIndex = 0;
            this.goToCreateMeetingButton.Text = "Create Meeting";
            this.goToCreateMeetingButton.UseVisualStyleBackColor = true;
            this.goToCreateMeetingButton.Click += new System.EventHandler(this.goToCreateMeetingButton_Click);
            // 
            // goToJoinMeetingButton
            // 
            this.goToJoinMeetingButton.Location = new System.Drawing.Point(12, 90);
            this.goToJoinMeetingButton.Name = "goToJoinMeetingButton";
            this.goToJoinMeetingButton.Size = new System.Drawing.Size(439, 49);
            this.goToJoinMeetingButton.TabIndex = 1;
            this.goToJoinMeetingButton.Text = "Join Meeting";
            this.goToJoinMeetingButton.UseVisualStyleBackColor = true;
            this.goToJoinMeetingButton.Click += new System.EventHandler(this.goToJoinMeeting_Click);
            // 
            // goToCloseMeetingButton
            // 
            this.goToCloseMeetingButton.Location = new System.Drawing.Point(12, 145);
            this.goToCloseMeetingButton.Name = "goToCloseMeetingButton";
            this.goToCloseMeetingButton.Size = new System.Drawing.Size(439, 49);
            this.goToCloseMeetingButton.TabIndex = 2;
            this.goToCloseMeetingButton.Text = "Close Meeting";
            this.goToCloseMeetingButton.UseVisualStyleBackColor = true;
            this.goToCloseMeetingButton.Click += new System.EventHandler(this.goToCloseMeetingButton_Click);
            // 
            // goToListMeetingsButton
            // 
            this.goToListMeetingsButton.Location = new System.Drawing.Point(12, 201);
            this.goToListMeetingsButton.Name = "goToListMeetingsButton";
            this.goToListMeetingsButton.Size = new System.Drawing.Size(439, 49);
            this.goToListMeetingsButton.TabIndex = 3;
            this.goToListMeetingsButton.Text = "List Meetings";
            this.goToListMeetingsButton.UseVisualStyleBackColor = true;
            this.goToListMeetingsButton.Click += new System.EventHandler(this.goToListMeetingsButton_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.goToBackButton);
            this.Controls.Add(this.goToListMeetingsButton);
            this.Controls.Add(this.goToCloseMeetingButton);
            this.Controls.Add(this.goToJoinMeetingButton);
            this.Controls.Add(this.goToCreateMeetingButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MSDAD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goToCreateMeetingButton;
        private System.Windows.Forms.Button goToJoinMeetingButton;
        private System.Windows.Forms.Button goToCloseMeetingButton;
        private System.Windows.Forms.Button goToListMeetingsButton;
        private System.Windows.Forms.Button goToBackButton;
    }
}