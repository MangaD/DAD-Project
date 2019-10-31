namespace PM
{
    partial class CreateServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateServerForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.backLbl = new System.Windows.Forms.Label();
            this.serverIDLbl = new System.Windows.Forms.Label();
            this.remotingAddrLbl = new System.Windows.Forms.Label();
            this.maxFaultsLbl = new System.Windows.Forms.Label();
            this.minDelayLbl = new System.Windows.Forms.Label();
            this.maxDelayLbl = new System.Windows.Forms.Label();
            this.serverIDTb = new System.Windows.Forms.TextBox();
            this.remotingAddrTb = new System.Windows.Forms.TextBox();
            this.maxFaultsNUD = new System.Windows.Forms.NumericUpDown();
            this.minDelayNUD = new System.Windows.Forms.NumericUpDown();
            this.maxDelayNUD = new System.Windows.Forms.NumericUpDown();
            this.createSrvBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maxFaultsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDelayNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDelayNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(68, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(209, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Create Server";
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
            this.backLbl.TabIndex = 8;
            this.backLbl.Text = "Back";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // serverIDLbl
            // 
            this.serverIDLbl.AutoSize = true;
            this.serverIDLbl.BackColor = System.Drawing.Color.Transparent;
            this.serverIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverIDLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serverIDLbl.Location = new System.Drawing.Point(12, 106);
            this.serverIDLbl.Name = "serverIDLbl";
            this.serverIDLbl.Size = new System.Drawing.Size(70, 15);
            this.serverIDLbl.TabIndex = 9;
            this.serverIDLbl.Text = "Server ID:";
            // 
            // remotingAddrLbl
            // 
            this.remotingAddrLbl.AutoSize = true;
            this.remotingAddrLbl.BackColor = System.Drawing.Color.Transparent;
            this.remotingAddrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remotingAddrLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remotingAddrLbl.Location = new System.Drawing.Point(12, 136);
            this.remotingAddrLbl.Name = "remotingAddrLbl";
            this.remotingAddrLbl.Size = new System.Drawing.Size(69, 30);
            this.remotingAddrLbl.TabIndex = 10;
            this.remotingAddrLbl.Text = "Remoting\r\nAddress:";
            // 
            // maxFaultsLbl
            // 
            this.maxFaultsLbl.AutoSize = true;
            this.maxFaultsLbl.BackColor = System.Drawing.Color.Transparent;
            this.maxFaultsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxFaultsLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxFaultsLbl.Location = new System.Drawing.Point(11, 182);
            this.maxFaultsLbl.Name = "maxFaultsLbl";
            this.maxFaultsLbl.Size = new System.Drawing.Size(81, 15);
            this.maxFaultsLbl.TabIndex = 11;
            this.maxFaultsLbl.Text = "Max. faults:";
            // 
            // minDelayLbl
            // 
            this.minDelayLbl.AutoSize = true;
            this.minDelayLbl.BackColor = System.Drawing.Color.Transparent;
            this.minDelayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minDelayLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minDelayLbl.Location = new System.Drawing.Point(11, 213);
            this.minDelayLbl.Name = "minDelayLbl";
            this.minDelayLbl.Size = new System.Drawing.Size(77, 15);
            this.minDelayLbl.TabIndex = 12;
            this.minDelayLbl.Text = "Min. delay:";
            // 
            // maxDelayLbl
            // 
            this.maxDelayLbl.AutoSize = true;
            this.maxDelayLbl.BackColor = System.Drawing.Color.Transparent;
            this.maxDelayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDelayLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxDelayLbl.Location = new System.Drawing.Point(12, 243);
            this.maxDelayLbl.Name = "maxDelayLbl";
            this.maxDelayLbl.Size = new System.Drawing.Size(80, 15);
            this.maxDelayLbl.TabIndex = 13;
            this.maxDelayLbl.Text = "Max. delay:";
            // 
            // serverIDTb
            // 
            this.serverIDTb.Location = new System.Drawing.Point(103, 106);
            this.serverIDTb.Name = "serverIDTb";
            this.serverIDTb.Size = new System.Drawing.Size(138, 20);
            this.serverIDTb.TabIndex = 14;
            // 
            // remotingAddrTb
            // 
            this.remotingAddrTb.Location = new System.Drawing.Point(103, 146);
            this.remotingAddrTb.Name = "remotingAddrTb";
            this.remotingAddrTb.Size = new System.Drawing.Size(138, 20);
            this.remotingAddrTb.TabIndex = 15;
            // 
            // maxFaultsNUD
            // 
            this.maxFaultsNUD.Location = new System.Drawing.Point(103, 182);
            this.maxFaultsNUD.Name = "maxFaultsNUD";
            this.maxFaultsNUD.Size = new System.Drawing.Size(138, 20);
            this.maxFaultsNUD.TabIndex = 16;
            // 
            // minDelayNUD
            // 
            this.minDelayNUD.Location = new System.Drawing.Point(103, 213);
            this.minDelayNUD.Name = "minDelayNUD";
            this.minDelayNUD.Size = new System.Drawing.Size(138, 20);
            this.minDelayNUD.TabIndex = 17;
            // 
            // maxDelayNUD
            // 
            this.maxDelayNUD.Location = new System.Drawing.Point(103, 243);
            this.maxDelayNUD.Name = "maxDelayNUD";
            this.maxDelayNUD.Size = new System.Drawing.Size(138, 20);
            this.maxDelayNUD.TabIndex = 18;
            // 
            // createSrvBtn
            // 
            this.createSrvBtn.Location = new System.Drawing.Point(132, 285);
            this.createSrvBtn.Name = "createSrvBtn";
            this.createSrvBtn.Size = new System.Drawing.Size(75, 23);
            this.createSrvBtn.TabIndex = 19;
            this.createSrvBtn.Text = "Create";
            this.createSrvBtn.UseVisualStyleBackColor = true;
            this.createSrvBtn.Click += new System.EventHandler(this.createSrvBtn_Click);
            // 
            // CreateServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PM.Properties.Resources.puppetBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 366);
            this.Controls.Add(this.createSrvBtn);
            this.Controls.Add(this.maxDelayNUD);
            this.Controls.Add(this.minDelayNUD);
            this.Controls.Add(this.maxFaultsNUD);
            this.Controls.Add(this.remotingAddrTb);
            this.Controls.Add(this.serverIDTb);
            this.Controls.Add(this.maxDelayLbl);
            this.Controls.Add(this.minDelayLbl);
            this.Controls.Add(this.maxFaultsLbl);
            this.Controls.Add(this.remotingAddrLbl);
            this.Controls.Add(this.serverIDLbl);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateServerForm";
            this.Text = "Puppet Master";
            ((System.ComponentModel.ISupportInitialize)(this.maxFaultsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDelayNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDelayNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label backLbl;
        private System.Windows.Forms.Label serverIDLbl;
        private System.Windows.Forms.Label remotingAddrLbl;
        private System.Windows.Forms.Label maxFaultsLbl;
        private System.Windows.Forms.Label minDelayLbl;
        private System.Windows.Forms.Label maxDelayLbl;
        private System.Windows.Forms.TextBox serverIDTb;
        private System.Windows.Forms.TextBox remotingAddrTb;
        private System.Windows.Forms.NumericUpDown maxFaultsNUD;
        private System.Windows.Forms.NumericUpDown minDelayNUD;
        private System.Windows.Forms.NumericUpDown maxDelayNUD;
        private System.Windows.Forms.Button createSrvBtn;
    }
}