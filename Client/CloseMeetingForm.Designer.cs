namespace MSDAD_CLI
{
    partial class CloseMeetingForm
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
            this.closeMeetingButton = new System.Windows.Forms.Button();
            this.topicTb = new System.Windows.Forms.TextBox();
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
            // closeMeetingButton
            // 
            this.closeMeetingButton.Location = new System.Drawing.Point(24, 42);
            this.closeMeetingButton.Name = "closeMeetingButton";
            this.closeMeetingButton.Size = new System.Drawing.Size(141, 23);
            this.closeMeetingButton.TabIndex = 5;
            this.closeMeetingButton.Text = "Close Meeting";
            this.closeMeetingButton.UseVisualStyleBackColor = true;
            this.closeMeetingButton.Click += new System.EventHandler(this.closeMeetingButton_Click);
            // 
            // topicTb
            // 
            this.topicTb.Location = new System.Drawing.Point(171, 43);
            this.topicTb.Name = "topicTb";
            this.topicTb.Size = new System.Drawing.Size(180, 22);
            this.topicTb.TabIndex = 6;
            // 
            // CloseMeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.topicTb);
            this.Controls.Add(this.closeMeetingButton);
            this.Controls.Add(this.goToBackButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CloseMeetingForm";
            this.Text = "Close Meeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToBackButton;
        private System.Windows.Forms.Button closeMeetingButton;
        private System.Windows.Forms.TextBox topicTb;
    }
}