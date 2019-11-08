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
            this.closeMeetingButton = new System.Windows.Forms.Button();
            this.goToBackButton = new System.Windows.Forms.Button();
            this.topicCB = new System.Windows.Forms.ComboBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeMeetingButton
            // 
            this.closeMeetingButton.BackColor = System.Drawing.Color.LightGray;
            this.closeMeetingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeMeetingButton.Location = new System.Drawing.Point(105, 197);
            this.closeMeetingButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeMeetingButton.Name = "closeMeetingButton";
            this.closeMeetingButton.Size = new System.Drawing.Size(125, 35);
            this.closeMeetingButton.TabIndex = 8;
            this.closeMeetingButton.Text = "Close Meeting";
            this.closeMeetingButton.UseVisualStyleBackColor = false;
            this.closeMeetingButton.Click += new System.EventHandler(this.closeMeetingButton_Click);
            // 
            // goToBackButton
            // 
            this.goToBackButton.BackColor = System.Drawing.Color.LightGray;
            this.goToBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToBackButton.Location = new System.Drawing.Point(20, 328);
            this.goToBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.goToBackButton.Name = "goToBackButton";
            this.goToBackButton.Size = new System.Drawing.Size(56, 23);
            this.goToBackButton.TabIndex = 7;
            this.goToBackButton.Text = "Back";
            this.goToBackButton.UseVisualStyleBackColor = false;
            this.goToBackButton.Click += new System.EventHandler(this.goToBackButton_Click);
            // 
            // topicCB
            // 
            this.topicCB.FormattingEnabled = true;
            this.topicCB.Location = new System.Drawing.Point(20, 154);
            this.topicCB.Name = "topicCB";
            this.topicCB.Size = new System.Drawing.Size(304, 21);
            this.topicCB.TabIndex = 9;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLbl.Location = new System.Drawing.Point(49, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(245, 47);
            this.titleLbl.TabIndex = 42;
            this.titleLbl.Text = "Close Meeting";
            // 
            // CloseMeetingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.topicCB);
            this.Controls.Add(this.closeMeetingButton);
            this.Controls.Add(this.goToBackButton);
            this.Name = "CloseMeetingPage";
            this.Size = new System.Drawing.Size(349, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeMeetingButton;
        private System.Windows.Forms.Button goToBackButton;
        private System.Windows.Forms.ComboBox topicCB;
        private System.Windows.Forms.Label titleLbl;
    }
}
