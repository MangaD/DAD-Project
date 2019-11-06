namespace PM
{
    partial class ManageServersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageServersForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.backLbl = new System.Windows.Forms.Label();
            this.serverListLbl = new System.Windows.Forms.Label();
            this.serverListBox = new System.Windows.Forms.ListBox();
            this.freezeBtn = new System.Windows.Forms.Button();
            this.unfreezeBtn = new System.Windows.Forms.Button();
            this.crashBtn = new System.Windows.Forms.Button();
            this.addRoomLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.capacityLbl = new System.Windows.Forms.Label();
            this.capacityNUD = new System.Windows.Forms.NumericUpDown();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.locationCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(59, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(229, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Manage Servers";
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.BackColor = System.Drawing.Color.Transparent;
            this.backLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backLbl.Location = new System.Drawing.Point(12, 342);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(38, 15);
            this.backLbl.TabIndex = 7;
            this.backLbl.Text = "Back";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // serverListLbl
            // 
            this.serverListLbl.AutoSize = true;
            this.serverListLbl.BackColor = System.Drawing.Color.Transparent;
            this.serverListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverListLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serverListLbl.Location = new System.Drawing.Point(12, 111);
            this.serverListLbl.Name = "serverListLbl";
            this.serverListLbl.Size = new System.Drawing.Size(75, 15);
            this.serverListLbl.TabIndex = 9;
            this.serverListLbl.Text = "Server list:";
            // 
            // serverListBox
            // 
            this.serverListBox.BackColor = System.Drawing.SystemColors.Window;
            this.serverListBox.FormattingEnabled = true;
            this.serverListBox.Location = new System.Drawing.Point(15, 129);
            this.serverListBox.Name = "serverListBox";
            this.serverListBox.Size = new System.Drawing.Size(111, 147);
            this.serverListBox.TabIndex = 10;
            // 
            // freezeBtn
            // 
            this.freezeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.freezeBtn.FlatAppearance.BorderSize = 0;
            this.freezeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freezeBtn.Location = new System.Drawing.Point(132, 195);
            this.freezeBtn.Name = "freezeBtn";
            this.freezeBtn.Size = new System.Drawing.Size(75, 23);
            this.freezeBtn.TabIndex = 11;
            this.freezeBtn.Text = "Freeze";
            this.freezeBtn.UseVisualStyleBackColor = false;
            this.freezeBtn.Click += new System.EventHandler(this.freezeBtn_Click);
            // 
            // unfreezeBtn
            // 
            this.unfreezeBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.unfreezeBtn.FlatAppearance.BorderSize = 0;
            this.unfreezeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unfreezeBtn.Location = new System.Drawing.Point(132, 224);
            this.unfreezeBtn.Name = "unfreezeBtn";
            this.unfreezeBtn.Size = new System.Drawing.Size(75, 23);
            this.unfreezeBtn.TabIndex = 12;
            this.unfreezeBtn.Text = "Unfreeze";
            this.unfreezeBtn.UseVisualStyleBackColor = false;
            this.unfreezeBtn.Click += new System.EventHandler(this.unfreezeBtn_Click);
            // 
            // crashBtn
            // 
            this.crashBtn.BackColor = System.Drawing.Color.DarkRed;
            this.crashBtn.FlatAppearance.BorderSize = 0;
            this.crashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crashBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.crashBtn.Location = new System.Drawing.Point(132, 253);
            this.crashBtn.Name = "crashBtn";
            this.crashBtn.Size = new System.Drawing.Size(75, 23);
            this.crashBtn.TabIndex = 13;
            this.crashBtn.Text = "Crash";
            this.crashBtn.UseVisualStyleBackColor = false;
            this.crashBtn.Click += new System.EventHandler(this.crashBtn_Click);
            // 
            // addRoomLbl
            // 
            this.addRoomLbl.AutoSize = true;
            this.addRoomLbl.BackColor = System.Drawing.Color.Transparent;
            this.addRoomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRoomLbl.Location = new System.Drawing.Point(213, 111);
            this.addRoomLbl.Name = "addRoomLbl";
            this.addRoomLbl.Size = new System.Drawing.Size(72, 15);
            this.addRoomLbl.TabIndex = 14;
            this.addRoomLbl.Text = "Add room:";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.BackColor = System.Drawing.Color.Transparent;
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.locationLbl.Location = new System.Drawing.Point(244, 173);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(66, 15);
            this.locationLbl.TabIndex = 16;
            this.locationLbl.Text = "Location:";
            // 
            // capacityLbl
            // 
            this.capacityLbl.AutoSize = true;
            this.capacityLbl.BackColor = System.Drawing.Color.Transparent;
            this.capacityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.capacityLbl.Location = new System.Drawing.Point(244, 214);
            this.capacityLbl.Name = "capacityLbl";
            this.capacityLbl.Size = new System.Drawing.Size(65, 15);
            this.capacityLbl.TabIndex = 18;
            this.capacityLbl.Text = "Capacity:";
            // 
            // capacityNUD
            // 
            this.capacityNUD.Location = new System.Drawing.Point(216, 232);
            this.capacityNUD.Name = "capacityNUD";
            this.capacityNUD.Size = new System.Drawing.Size(120, 20);
            this.capacityNUD.TabIndex = 19;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLbl.Location = new System.Drawing.Point(250, 132);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 15);
            this.nameLbl.TabIndex = 21;
            this.nameLbl.Text = "Name:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(213, 150);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(122, 20);
            this.nameTb.TabIndex = 20;
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.BackColor = System.Drawing.Color.LightGray;
            this.addRoomBtn.FlatAppearance.BorderSize = 0;
            this.addRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addRoomBtn.Location = new System.Drawing.Point(240, 258);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(75, 23);
            this.addRoomBtn.TabIndex = 22;
            this.addRoomBtn.Text = "Add room";
            this.addRoomBtn.UseVisualStyleBackColor = false;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // locationCb
            // 
            this.locationCb.FormattingEnabled = true;
            this.locationCb.Location = new System.Drawing.Point(213, 191);
            this.locationCb.Name = "locationCb";
            this.locationCb.Size = new System.Drawing.Size(122, 21);
            this.locationCb.TabIndex = 23;
            // 
            // ManageServersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PM.Properties.Resources.puppetBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 366);
            this.Controls.Add(this.locationCb);
            this.Controls.Add(this.addRoomBtn);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.capacityNUD);
            this.Controls.Add(this.capacityLbl);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.addRoomLbl);
            this.Controls.Add(this.crashBtn);
            this.Controls.Add(this.unfreezeBtn);
            this.Controls.Add(this.freezeBtn);
            this.Controls.Add(this.serverListBox);
            this.Controls.Add(this.serverListLbl);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageServersForm";
            this.Text = "Puppet Master";
            this.Shown += new System.EventHandler(this.ManageServersForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.capacityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label backLbl;
        private System.Windows.Forms.Label serverListLbl;
        private System.Windows.Forms.ListBox serverListBox;
        private System.Windows.Forms.Button freezeBtn;
        private System.Windows.Forms.Button unfreezeBtn;
        private System.Windows.Forms.Button crashBtn;
        private System.Windows.Forms.Label addRoomLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label capacityLbl;
        private System.Windows.Forms.NumericUpDown capacityNUD;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button addRoomBtn;
        private System.Windows.Forms.ComboBox locationCb;
    }
}