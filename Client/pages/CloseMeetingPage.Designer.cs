namespace MSDAD_CLI.pages
{
    partial class CloseMeetingPage
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
            this.topicTb = new System.Windows.Forms.TextBox();
            this.closeMeetingButton = new System.Windows.Forms.Button();
            this.goToBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topicTb
            // 
            this.topicTb.Location = new System.Drawing.Point(122, 30);
            this.topicTb.Margin = new System.Windows.Forms.Padding(2);
            this.topicTb.Name = "topicTb";
            this.topicTb.Size = new System.Drawing.Size(136, 20);
            this.topicTb.TabIndex = 9;
            // 
            // closeMeetingButton
            // 
            this.closeMeetingButton.Location = new System.Drawing.Point(12, 29);
            this.closeMeetingButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeMeetingButton.Name = "closeMeetingButton";
            this.closeMeetingButton.Size = new System.Drawing.Size(106, 19);
            this.closeMeetingButton.TabIndex = 8;
            this.closeMeetingButton.Text = "Close Meeting";
            this.closeMeetingButton.UseVisualStyleBackColor = true;
            this.closeMeetingButton.Click += new System.EventHandler(this.closeMeetingButton_Click);
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
            // CloseMeetingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.topicTb);
            this.Controls.Add(this.closeMeetingButton);
            this.Controls.Add(this.goToBackButton);
            this.Name = "CloseMeetingPage";
            this.Size = new System.Drawing.Size(349, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox topicTb;
        private System.Windows.Forms.Button closeMeetingButton;
        private System.Windows.Forms.Button goToBackButton;
    }
}
