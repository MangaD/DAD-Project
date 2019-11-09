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
            this.selectedSlotsLv = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availableSlotsLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopicLb = new System.Windows.Forms.Label();
            this.topicCB = new System.Windows.Forms.ComboBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.backLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // availableSlotsLabel
            // 
            this.availableSlotsLabel.AutoSize = true;
            this.availableSlotsLabel.BackColor = System.Drawing.Color.Transparent;
            this.availableSlotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableSlotsLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.availableSlotsLabel.Location = new System.Drawing.Point(17, 141);
            this.availableSlotsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availableSlotsLabel.Name = "availableSlotsLabel";
            this.availableSlotsLabel.Size = new System.Drawing.Size(95, 13);
            this.availableSlotsLabel.TabIndex = 31;
            this.availableSlotsLabel.Text = "Available Slots:";
            // 
            // selectedSlotsLabel
            // 
            this.selectedSlotsLabel.AutoSize = true;
            this.selectedSlotsLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectedSlotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedSlotsLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.selectedSlotsLabel.Location = new System.Drawing.Point(173, 141);
            this.selectedSlotsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedSlotsLabel.Name = "selectedSlotsLabel";
            this.selectedSlotsLabel.Size = new System.Drawing.Size(93, 13);
            this.selectedSlotsLabel.TabIndex = 30;
            this.selectedSlotsLabel.Text = "Selected Slots:";
            // 
            // joinMeetingButton
            // 
            this.joinMeetingButton.BackColor = System.Drawing.Color.LightGray;
            this.joinMeetingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinMeetingButton.Location = new System.Drawing.Point(115, 307);
            this.joinMeetingButton.Margin = new System.Windows.Forms.Padding(2);
            this.joinMeetingButton.Name = "joinMeetingButton";
            this.joinMeetingButton.Size = new System.Drawing.Size(125, 35);
            this.joinMeetingButton.TabIndex = 4;
            this.joinMeetingButton.Text = "Join Meeting";
            this.joinMeetingButton.UseVisualStyleBackColor = false;
            this.joinMeetingButton.Click += new System.EventHandler(this.joinMeetingButton_Click);
            // 
            // selectedSlotsLv
            // 
            this.selectedSlotsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.selectedSlotsLv.FullRowSelect = true;
            this.selectedSlotsLv.HideSelection = false;
            this.selectedSlotsLv.Location = new System.Drawing.Point(176, 157);
            this.selectedSlotsLv.Margin = new System.Windows.Forms.Padding(2);
            this.selectedSlotsLv.MultiSelect = false;
            this.selectedSlotsLv.Name = "selectedSlotsLv";
            this.selectedSlotsLv.Size = new System.Drawing.Size(152, 128);
            this.selectedSlotsLv.TabIndex = 3;
            this.selectedSlotsLv.UseCompatibleStateImageBehavior = false;
            this.selectedSlotsLv.View = System.Windows.Forms.View.Details;
            this.selectedSlotsLv.Click += new System.EventHandler(this.selectedSlotsLv_Click);
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
            // availableSlotsLv
            // 
            this.availableSlotsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.availableSlotsLv.FullRowSelect = true;
            this.availableSlotsLv.HideSelection = false;
            this.availableSlotsLv.Location = new System.Drawing.Point(20, 157);
            this.availableSlotsLv.Margin = new System.Windows.Forms.Padding(2);
            this.availableSlotsLv.MultiSelect = false;
            this.availableSlotsLv.Name = "availableSlotsLv";
            this.availableSlotsLv.Size = new System.Drawing.Size(152, 128);
            this.availableSlotsLv.TabIndex = 2;
            this.availableSlotsLv.UseCompatibleStateImageBehavior = false;
            this.availableSlotsLv.View = System.Windows.Forms.View.Details;
            this.availableSlotsLv.Click += new System.EventHandler(this.availableSlotsLv_Click);
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
            // TopicLb
            // 
            this.TopicLb.AutoSize = true;
            this.TopicLb.BackColor = System.Drawing.Color.Transparent;
            this.TopicLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicLb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TopicLb.Location = new System.Drawing.Point(17, 103);
            this.TopicLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TopicLb.Name = "TopicLb";
            this.TopicLb.Size = new System.Drawing.Size(43, 13);
            this.TopicLb.TabIndex = 24;
            this.TopicLb.Text = "Topic:";
            // 
            // topicCB
            // 
            this.topicCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topicCB.FormattingEnabled = true;
            this.topicCB.Location = new System.Drawing.Point(65, 100);
            this.topicCB.Name = "topicCB";
            this.topicCB.Size = new System.Drawing.Size(263, 21);
            this.topicCB.TabIndex = 1;
            this.topicCB.SelectedIndexChanged += new System.EventHandler(this.topicCB_SelectedIndexChanged);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLbl.Location = new System.Drawing.Point(68, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(226, 47);
            this.titleLbl.TabIndex = 42;
            this.titleLbl.Text = "Join Meeting";
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.BackColor = System.Drawing.Color.Transparent;
            this.backLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backLbl.Location = new System.Drawing.Point(17, 336);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(38, 15);
            this.backLbl.TabIndex = 5;
            this.backLbl.Text = "Back";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // JoinMeetingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.topicCB);
            this.Controls.Add(this.availableSlotsLabel);
            this.Controls.Add(this.selectedSlotsLabel);
            this.Controls.Add(this.joinMeetingButton);
            this.Controls.Add(this.selectedSlotsLv);
            this.Controls.Add(this.availableSlotsLv);
            this.Controls.Add(this.TopicLb);
            this.Name = "JoinMeetingPage";
            this.Size = new System.Drawing.Size(349, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label availableSlotsLabel;
        private System.Windows.Forms.Label selectedSlotsLabel;
        private System.Windows.Forms.Button joinMeetingButton;
        private System.Windows.Forms.ListView selectedSlotsLv;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView availableSlotsLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label TopicLb;
        private System.Windows.Forms.ComboBox topicCB;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label backLbl;
    }
}
