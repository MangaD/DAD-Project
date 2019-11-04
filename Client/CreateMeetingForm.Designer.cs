namespace MSDAD_CLI
{
    partial class CreateMeetingForm
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
            this.CreateMeetingButton = new System.Windows.Forms.Button();
            this.MinPartNud = new System.Windows.Forms.NumericUpDown();
            this.TopicLb = new System.Windows.Forms.Label();
            this.TopicTb = new System.Windows.Forms.TextBox();
            this.MinPartLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinPartNud)).BeginInit();
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
            // CreateMeetingButton
            // 
            this.CreateMeetingButton.Location = new System.Drawing.Point(173, 295);
            this.CreateMeetingButton.Name = "CreateMeetingButton";
            this.CreateMeetingButton.Size = new System.Drawing.Size(103, 43);
            this.CreateMeetingButton.TabIndex = 5;
            this.CreateMeetingButton.Text = "Create Meeting";
            this.CreateMeetingButton.UseVisualStyleBackColor = true;
            this.CreateMeetingButton.Click += new System.EventHandler(this.CreateMeetingButton_Click);
            // 
            // MinPartNud
            // 
            this.MinPartNud.Location = new System.Drawing.Point(159, 135);
            this.MinPartNud.Name = "MinPartNud";
            this.MinPartNud.Size = new System.Drawing.Size(135, 22);
            this.MinPartNud.TabIndex = 6;
            // 
            // TopicLb
            // 
            this.TopicLb.AutoSize = true;
            this.TopicLb.Location = new System.Drawing.Point(35, 94);
            this.TopicLb.Name = "TopicLb";
            this.TopicLb.Size = new System.Drawing.Size(47, 17);
            this.TopicLb.TabIndex = 7;
            this.TopicLb.Text = "Topic:";
            // 
            // TopicTb
            // 
            this.TopicTb.Location = new System.Drawing.Point(159, 89);
            this.TopicTb.Name = "TopicTb";
            this.TopicTb.Size = new System.Drawing.Size(135, 22);
            this.TopicTb.TabIndex = 8;
            // 
            // MinPartLb
            // 
            this.MinPartLb.AutoSize = true;
            this.MinPartLb.Location = new System.Drawing.Point(35, 137);
            this.MinPartLb.Name = "MinPartLb";
            this.MinPartLb.Size = new System.Drawing.Size(112, 17);
            this.MinPartLb.TabIndex = 9;
            this.MinPartLb.Text = "Min Participants:";
            // 
            // CreateMeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.MinPartLb);
            this.Controls.Add(this.TopicTb);
            this.Controls.Add(this.TopicLb);
            this.Controls.Add(this.MinPartNud);
            this.Controls.Add(this.CreateMeetingButton);
            this.Controls.Add(this.goToBackButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateMeetingForm";
            this.Text = "Create Meeting";
            ((System.ComponentModel.ISupportInitialize)(this.MinPartNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToBackButton;
        private System.Windows.Forms.Button CreateMeetingButton;
        private System.Windows.Forms.NumericUpDown MinPartNud;
        private System.Windows.Forms.Label TopicLb;
        private System.Windows.Forms.TextBox TopicTb;
        private System.Windows.Forms.Label MinPartLb;
    }
}