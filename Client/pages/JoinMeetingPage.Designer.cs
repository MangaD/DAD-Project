namespace MSDAD_CLI.pages
{
    partial class JoinMeetingPage
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
            this.availableSlotsLabel = new System.Windows.Forms.Label();
            this.selectedSlotsLabel = new System.Windows.Forms.Label();
            this.joinMeetingButton = new System.Windows.Forms.Button();
            this.searchTopicButton = new System.Windows.Forms.Button();
            this.SelectedSlotsLv = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SlotsLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopicTb = new System.Windows.Forms.TextBox();
            this.TopicLb = new System.Windows.Forms.Label();
            this.goToBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // availableSlotsLabel
            // 
            this.availableSlotsLabel.AutoSize = true;
            this.availableSlotsLabel.BackColor = System.Drawing.Color.Transparent;
            this.availableSlotsLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.availableSlotsLabel.Location = new System.Drawing.Point(90, 23);
            this.availableSlotsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availableSlotsLabel.Name = "availableSlotsLabel";
            this.availableSlotsLabel.Size = new System.Drawing.Size(79, 13);
            this.availableSlotsLabel.TabIndex = 31;
            this.availableSlotsLabel.Text = "Available Slots:";
            // 
            // selectedSlotsLabel
            // 
            this.selectedSlotsLabel.AutoSize = true;
            this.selectedSlotsLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectedSlotsLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.selectedSlotsLabel.Location = new System.Drawing.Point(90, 191);
            this.selectedSlotsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedSlotsLabel.Name = "selectedSlotsLabel";
            this.selectedSlotsLabel.Size = new System.Drawing.Size(78, 13);
            this.selectedSlotsLabel.TabIndex = 30;
            this.selectedSlotsLabel.Text = "Selected Slots:";
            // 
            // joinMeetingButton
            // 
            this.joinMeetingButton.Location = new System.Drawing.Point(52, 300);
            this.joinMeetingButton.Margin = new System.Windows.Forms.Padding(2);
            this.joinMeetingButton.Name = "joinMeetingButton";
            this.joinMeetingButton.Size = new System.Drawing.Size(101, 19);
            this.joinMeetingButton.TabIndex = 29;
            this.joinMeetingButton.Text = "Join Meeting";
            this.joinMeetingButton.UseVisualStyleBackColor = true;
            this.joinMeetingButton.Click += new System.EventHandler(this.joinMeetingButton_Click);
            // 
            // searchTopicButton
            // 
            this.searchTopicButton.Location = new System.Drawing.Point(52, 86);
            this.searchTopicButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchTopicButton.Name = "searchTopicButton";
            this.searchTopicButton.Size = new System.Drawing.Size(101, 19);
            this.searchTopicButton.TabIndex = 28;
            this.searchTopicButton.Text = "Search Topic";
            this.searchTopicButton.UseVisualStyleBackColor = true;
            this.searchTopicButton.Click += new System.EventHandler(this.searchTopicButton_Click);
            // 
            // SelectedSlotsLv
            // 
            this.SelectedSlotsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.SelectedSlotsLv.FullRowSelect = true;
            this.SelectedSlotsLv.HideSelection = false;
            this.SelectedSlotsLv.Location = new System.Drawing.Point(171, 191);
            this.SelectedSlotsLv.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedSlotsLv.MultiSelect = false;
            this.SelectedSlotsLv.Name = "SelectedSlotsLv";
            this.SelectedSlotsLv.Size = new System.Drawing.Size(138, 128);
            this.SelectedSlotsLv.TabIndex = 27;
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
            // SlotsLv
            // 
            this.SlotsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SlotsLv.FullRowSelect = true;
            this.SlotsLv.HideSelection = false;
            this.SlotsLv.Location = new System.Drawing.Point(171, 23);
            this.SlotsLv.Margin = new System.Windows.Forms.Padding(2);
            this.SlotsLv.MultiSelect = false;
            this.SlotsLv.Name = "SlotsLv";
            this.SlotsLv.Size = new System.Drawing.Size(138, 128);
            this.SlotsLv.TabIndex = 26;
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
            // TopicTb
            // 
            this.TopicTb.Location = new System.Drawing.Point(52, 63);
            this.TopicTb.Margin = new System.Windows.Forms.Padding(2);
            this.TopicTb.Name = "TopicTb";
            this.TopicTb.Size = new System.Drawing.Size(102, 20);
            this.TopicTb.TabIndex = 25;
            // 
            // TopicLb
            // 
            this.TopicLb.AutoSize = true;
            this.TopicLb.BackColor = System.Drawing.Color.Transparent;
            this.TopicLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TopicLb.Location = new System.Drawing.Point(13, 66);
            this.TopicLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TopicLb.Name = "TopicLb";
            this.TopicLb.Size = new System.Drawing.Size(37, 13);
            this.TopicLb.TabIndex = 24;
            this.TopicLb.Text = "Topic:";
            // 
            // goToBackButton
            // 
            this.goToBackButton.Location = new System.Drawing.Point(276, 332);
            this.goToBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.goToBackButton.Name = "goToBackButton";
            this.goToBackButton.Size = new System.Drawing.Size(56, 19);
            this.goToBackButton.TabIndex = 23;
            this.goToBackButton.Text = "Back";
            this.goToBackButton.UseVisualStyleBackColor = true;
            this.goToBackButton.Click += new System.EventHandler(this.goToBackButton_Click);
            // 
            // JoinMeetingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.availableSlotsLabel);
            this.Controls.Add(this.selectedSlotsLabel);
            this.Controls.Add(this.joinMeetingButton);
            this.Controls.Add(this.searchTopicButton);
            this.Controls.Add(this.SelectedSlotsLv);
            this.Controls.Add(this.SlotsLv);
            this.Controls.Add(this.TopicTb);
            this.Controls.Add(this.TopicLb);
            this.Controls.Add(this.goToBackButton);
            this.Name = "JoinMeetingPage";
            this.Size = new System.Drawing.Size(349, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label availableSlotsLabel;
        private System.Windows.Forms.Label selectedSlotsLabel;
        private System.Windows.Forms.Button joinMeetingButton;
        private System.Windows.Forms.Button searchTopicButton;
        private System.Windows.Forms.ListView SelectedSlotsLv;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView SlotsLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox TopicTb;
        private System.Windows.Forms.Label TopicLb;
        private System.Windows.Forms.Button goToBackButton;
    }
}
