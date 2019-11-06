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
            this.serverListBox.Location = new System.Drawing.Point(12, 129);
            this.serverListBox.Name = "serverListBox";
            this.serverListBox.Size = new System.Drawing.Size(117, 147);
            this.serverListBox.TabIndex = 10;
            // 
            // freezeBtn
            // 
            this.freezeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.freezeBtn.FlatAppearance.BorderSize = 0;
            this.freezeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freezeBtn.Location = new System.Drawing.Point(213, 129);
            this.freezeBtn.Name = "freezeBtn";
            this.freezeBtn.Size = new System.Drawing.Size(122, 45);
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
            this.unfreezeBtn.Location = new System.Drawing.Point(213, 180);
            this.unfreezeBtn.Name = "unfreezeBtn";
            this.unfreezeBtn.Size = new System.Drawing.Size(122, 45);
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
            this.crashBtn.Location = new System.Drawing.Point(213, 231);
            this.crashBtn.Name = "crashBtn";
            this.crashBtn.Size = new System.Drawing.Size(122, 45);
            this.crashBtn.TabIndex = 13;
            this.crashBtn.Text = "Crash";
            this.crashBtn.UseVisualStyleBackColor = false;
            this.crashBtn.Click += new System.EventHandler(this.crashBtn_Click);
            // 
            // ManageServersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PM.Properties.Resources.puppetBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 366);
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
    }
}