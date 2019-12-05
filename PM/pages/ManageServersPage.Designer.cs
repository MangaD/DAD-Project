namespace PM.pages
{
    partial class ManageServersPage
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
            this.openScriptDialog = new System.Windows.Forms.OpenFileDialog();
            this.locationCb = new System.Windows.Forms.ComboBox();
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.capacityNUD = new System.Windows.Forms.NumericUpDown();
            this.capacityLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.addRoomLbl = new System.Windows.Forms.Label();
            this.crashBtn = new System.Windows.Forms.Button();
            this.unfreezeBtn = new System.Windows.Forms.Button();
            this.freezeBtn = new System.Windows.Forms.Button();
            this.serverListBox = new System.Windows.Forms.ListBox();
            this.serverListLbl = new System.Windows.Forms.Label();
            this.backLbl = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.statusBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // openScriptDialog
            // 
            this.openScriptDialog.FileName = "script.txt";
            // 
            // locationCb
            // 
            this.locationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationCb.FormattingEnabled = true;
            this.locationCb.ItemHeight = 16;
            this.locationCb.Location = new System.Drawing.Point(285, 233);
            this.locationCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.locationCb.Name = "locationCb";
            this.locationCb.Size = new System.Drawing.Size(161, 24);
            this.locationCb.TabIndex = 28;
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.BackColor = System.Drawing.Color.LightGray;
            this.addRoomBtn.FlatAppearance.BorderSize = 0;
            this.addRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addRoomBtn.Location = new System.Drawing.Point(321, 315);
            this.addRoomBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(100, 28);
            this.addRoomBtn.TabIndex = 30;
            this.addRoomBtn.Text = "Add room";
            this.addRoomBtn.UseVisualStyleBackColor = false;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLbl.Location = new System.Drawing.Point(335, 160);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(57, 18);
            this.nameLbl.TabIndex = 36;
            this.nameLbl.Text = "Name:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(285, 182);
            this.nameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(161, 22);
            this.nameTb.TabIndex = 27;
            // 
            // capacityNUD
            // 
            this.capacityNUD.Location = new System.Drawing.Point(289, 283);
            this.capacityNUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.capacityNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.capacityNUD.Name = "capacityNUD";
            this.capacityNUD.Size = new System.Drawing.Size(160, 22);
            this.capacityNUD.TabIndex = 29;
            // 
            // capacityLbl
            // 
            this.capacityLbl.AutoSize = true;
            this.capacityLbl.BackColor = System.Drawing.Color.Transparent;
            this.capacityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.capacityLbl.Location = new System.Drawing.Point(327, 261);
            this.capacityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capacityLbl.Name = "capacityLbl";
            this.capacityLbl.Size = new System.Drawing.Size(78, 18);
            this.capacityLbl.TabIndex = 35;
            this.capacityLbl.Text = "Capacity:";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.BackColor = System.Drawing.Color.Transparent;
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.locationLbl.Location = new System.Drawing.Point(327, 210);
            this.locationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(78, 18);
            this.locationLbl.TabIndex = 34;
            this.locationLbl.Text = "Location:";
            // 
            // addRoomLbl
            // 
            this.addRoomLbl.AutoSize = true;
            this.addRoomLbl.BackColor = System.Drawing.Color.Transparent;
            this.addRoomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRoomLbl.Location = new System.Drawing.Point(285, 134);
            this.addRoomLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addRoomLbl.Name = "addRoomLbl";
            this.addRoomLbl.Size = new System.Drawing.Size(86, 18);
            this.addRoomLbl.TabIndex = 33;
            this.addRoomLbl.Text = "Add room:";
            // 
            // crashBtn
            // 
            this.crashBtn.BackColor = System.Drawing.Color.DarkRed;
            this.crashBtn.FlatAppearance.BorderSize = 0;
            this.crashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crashBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.crashBtn.Location = new System.Drawing.Point(75, 348);
            this.crashBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crashBtn.Name = "crashBtn";
            this.crashBtn.Size = new System.Drawing.Size(100, 28);
            this.crashBtn.TabIndex = 26;
            this.crashBtn.Text = "Crash";
            this.crashBtn.UseVisualStyleBackColor = false;
            this.crashBtn.Click += new System.EventHandler(this.crashBtn_Click);
            // 
            // unfreezeBtn
            // 
            this.unfreezeBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.unfreezeBtn.FlatAppearance.BorderSize = 0;
            this.unfreezeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unfreezeBtn.Location = new System.Drawing.Point(129, 313);
            this.unfreezeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unfreezeBtn.Name = "unfreezeBtn";
            this.unfreezeBtn.Size = new System.Drawing.Size(100, 28);
            this.unfreezeBtn.TabIndex = 25;
            this.unfreezeBtn.Text = "Unfreeze";
            this.unfreezeBtn.UseVisualStyleBackColor = false;
            this.unfreezeBtn.Click += new System.EventHandler(this.unfreezeBtn_Click);
            // 
            // freezeBtn
            // 
            this.freezeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.freezeBtn.FlatAppearance.BorderSize = 0;
            this.freezeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freezeBtn.Location = new System.Drawing.Point(21, 313);
            this.freezeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.freezeBtn.Name = "freezeBtn";
            this.freezeBtn.Size = new System.Drawing.Size(100, 28);
            this.freezeBtn.TabIndex = 24;
            this.freezeBtn.Text = "Freeze";
            this.freezeBtn.UseVisualStyleBackColor = false;
            this.freezeBtn.Click += new System.EventHandler(this.freezeBtn_Click);
            // 
            // serverListBox
            // 
            this.serverListBox.BackColor = System.Drawing.SystemColors.Window;
            this.serverListBox.FormattingEnabled = true;
            this.serverListBox.ItemHeight = 16;
            this.serverListBox.Location = new System.Drawing.Point(21, 156);
            this.serverListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serverListBox.Name = "serverListBox";
            this.serverListBox.Size = new System.Drawing.Size(207, 148);
            this.serverListBox.TabIndex = 23;
            // 
            // serverListLbl
            // 
            this.serverListLbl.AutoSize = true;
            this.serverListLbl.BackColor = System.Drawing.Color.Transparent;
            this.serverListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverListLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serverListLbl.Location = new System.Drawing.Point(17, 134);
            this.serverListLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverListLbl.Name = "serverListLbl";
            this.serverListLbl.Size = new System.Drawing.Size(89, 18);
            this.serverListLbl.TabIndex = 31;
            this.serverListLbl.Text = "Server list:";
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.BackColor = System.Drawing.Color.Transparent;
            this.backLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backLbl.Location = new System.Drawing.Point(17, 418);
            this.backLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(46, 18);
            this.backLbl.TabIndex = 32;
            this.backLbl.Text = "Back";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(80, 34);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(285, 35);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Manage Servers";
            // 
            // statusBtn
            // 
            this.statusBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.statusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusBtn.Location = new System.Drawing.Point(285, 384);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.Size = new System.Drawing.Size(157, 34);
            this.statusBtn.TabIndex = 37;
            this.statusBtn.Text = "Status";
            this.statusBtn.UseVisualStyleBackColor = false;
            this.statusBtn.Click += new System.EventHandler(this.statusBtn_Click);
            // 
            // ManageServersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.statusBtn);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageServersPage";
            this.Size = new System.Drawing.Size(461, 449);
            ((System.ComponentModel.ISupportInitialize)(this.capacityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openScriptDialog;
        private System.Windows.Forms.ComboBox locationCb;
        private System.Windows.Forms.Button addRoomBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.NumericUpDown capacityNUD;
        private System.Windows.Forms.Label capacityLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label addRoomLbl;
        private System.Windows.Forms.Button crashBtn;
        private System.Windows.Forms.Button unfreezeBtn;
        private System.Windows.Forms.Button freezeBtn;
        private System.Windows.Forms.ListBox serverListBox;
        private System.Windows.Forms.Label serverListLbl;
        private System.Windows.Forms.Label backLbl;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button statusBtn;
    }
}
