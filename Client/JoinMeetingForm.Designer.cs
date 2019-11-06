namespace MSDAD_CLI
{
    partial class JoinMeetingForm
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
            this.TopicLb = new System.Windows.Forms.Label();
            this.TopicTb = new System.Windows.Forms.TextBox();
            this.SlotsLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectedSlotsLv = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTopicButton = new System.Windows.Forms.Button();
            this.joinMeetingButton = new System.Windows.Forms.Button();
            this.selectedSlotsLabel = new System.Windows.Forms.Label();
            this.availableSlotsLabel = new System.Windows.Forms.Label();
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
            // TopicLb
            // 
            this.TopicLb.AutoSize = true;
            this.TopicLb.Location = new System.Drawing.Point(25, 87);
            this.TopicLb.Name = "TopicLb";
            this.TopicLb.Size = new System.Drawing.Size(47, 17);
            this.TopicLb.TabIndex = 8;
            this.TopicLb.Text = "Topic:";
            // 
            // TopicTb
            // 
            this.TopicTb.Location = new System.Drawing.Point(78, 84);
            this.TopicTb.Name = "TopicTb";
            this.TopicTb.Size = new System.Drawing.Size(135, 22);
            this.TopicTb.TabIndex = 9;
            // 
            // SlotsLv
            // 
            this.SlotsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SlotsLv.FullRowSelect = true;
            this.SlotsLv.HideSelection = false;
            this.SlotsLv.Location = new System.Drawing.Point(236, 35);
            this.SlotsLv.MultiSelect = false;
            this.SlotsLv.Name = "SlotsLv";
            this.SlotsLv.Size = new System.Drawing.Size(182, 157);
            this.SlotsLv.TabIndex = 15;
            this.SlotsLv.UseCompatibleStateImageBehavior = false;
            this.SlotsLv.View = System.Windows.Forms.View.Details;
            this.SlotsLv.Click += new System.EventHandler(this.SlotsLv_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 82;
            // 
            // SelectedSlotsLv
            // 
            this.SelectedSlotsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.SelectedSlotsLv.FullRowSelect = true;
            this.SelectedSlotsLv.HideSelection = false;
            this.SelectedSlotsLv.Location = new System.Drawing.Point(236, 241);
            this.SelectedSlotsLv.MultiSelect = false;
            this.SelectedSlotsLv.Name = "SelectedSlotsLv";
            this.SelectedSlotsLv.Size = new System.Drawing.Size(182, 157);
            this.SelectedSlotsLv.TabIndex = 18;
            this.SelectedSlotsLv.UseCompatibleStateImageBehavior = false;
            this.SelectedSlotsLv.View = System.Windows.Forms.View.Details;
            this.SelectedSlotsLv.Click += new System.EventHandler(this.SelectedSlotsLv_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Location";
            this.columnHeader4.Width = 82;
            // 
            // searchTopicButton
            // 
            this.searchTopicButton.Location = new System.Drawing.Point(78, 112);
            this.searchTopicButton.Name = "searchTopicButton";
            this.searchTopicButton.Size = new System.Drawing.Size(135, 23);
            this.searchTopicButton.TabIndex = 19;
            this.searchTopicButton.Text = "Search Topic";
            this.searchTopicButton.UseVisualStyleBackColor = true;
            this.searchTopicButton.Click += new System.EventHandler(this.searchTopicButton_Click);
            // 
            // joinMeetingButton
            // 
            this.joinMeetingButton.Location = new System.Drawing.Point(78, 375);
            this.joinMeetingButton.Name = "joinMeetingButton";
            this.joinMeetingButton.Size = new System.Drawing.Size(135, 23);
            this.joinMeetingButton.TabIndex = 20;
            this.joinMeetingButton.Text = "Join Meeting";
            this.joinMeetingButton.UseVisualStyleBackColor = true;
            this.joinMeetingButton.Click += new System.EventHandler(this.joinMeetingButton_Click);
            // 
            // selectedSlotsLabel
            // 
            this.selectedSlotsLabel.AutoSize = true;
            this.selectedSlotsLabel.Location = new System.Drawing.Point(128, 241);
            this.selectedSlotsLabel.Name = "selectedSlotsLabel";
            this.selectedSlotsLabel.Size = new System.Drawing.Size(102, 17);
            this.selectedSlotsLabel.TabIndex = 21;
            this.selectedSlotsLabel.Text = "Selected Slots:";
            // 
            // availableSlotsLabel
            // 
            this.availableSlotsLabel.AutoSize = true;
            this.availableSlotsLabel.Location = new System.Drawing.Point(128, 35);
            this.availableSlotsLabel.Name = "availableSlotsLabel";
            this.availableSlotsLabel.Size = new System.Drawing.Size(104, 17);
            this.availableSlotsLabel.TabIndex = 22;
            this.availableSlotsLabel.Text = "Available Slots:";
            // 
            // JoinMeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.availableSlotsLabel);
            this.Controls.Add(this.selectedSlotsLabel);
            this.Controls.Add(this.joinMeetingButton);
            this.Controls.Add(this.searchTopicButton);
            this.Controls.Add(this.SelectedSlotsLv);
            this.Controls.Add(this.SlotsLv);
            this.Controls.Add(this.TopicTb);
            this.Controls.Add(this.TopicLb);
            this.Controls.Add(this.goToBackButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JoinMeetingForm";
            this.Text = "Join Meeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToBackButton;
        private System.Windows.Forms.Label TopicLb;
        private System.Windows.Forms.TextBox TopicTb;
        private System.Windows.Forms.ListView SlotsLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView SelectedSlotsLv;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button searchTopicButton;
        private System.Windows.Forms.Button joinMeetingButton;
        private System.Windows.Forms.Label selectedSlotsLabel;
        private System.Windows.Forms.Label availableSlotsLabel;
    }
}