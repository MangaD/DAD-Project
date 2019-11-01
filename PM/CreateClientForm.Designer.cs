namespace PM
{
    partial class CreateClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClientForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.backLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.clientRALbl = new System.Windows.Forms.Label();
            this.serverRALbl = new System.Windows.Forms.Label();
            this.maxDelayLbl = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.clientRATb = new System.Windows.Forms.TextBox();
            this.createCliBtn = new System.Windows.Forms.Button();
            this.serverRATb = new System.Windows.Forms.TextBox();
            this.scriptPathTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(72, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(201, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Create Client";
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
            this.backLbl.TabIndex = 6;
            this.backLbl.Text = "Back";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameLbl.Location = new System.Drawing.Point(12, 106);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(77, 15);
            this.usernameLbl.TabIndex = 9;
            this.usernameLbl.Text = "Username:";
            // 
            // clientRALbl
            // 
            this.clientRALbl.AutoSize = true;
            this.clientRALbl.BackColor = System.Drawing.Color.Transparent;
            this.clientRALbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientRALbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientRALbl.Location = new System.Drawing.Point(12, 136);
            this.clientRALbl.Name = "clientRALbl";
            this.clientRALbl.Size = new System.Drawing.Size(70, 15);
            this.clientRALbl.TabIndex = 10;
            this.clientRALbl.Text = "Client RA:";
            // 
            // serverRALbl
            // 
            this.serverRALbl.AutoSize = true;
            this.serverRALbl.BackColor = System.Drawing.Color.Transparent;
            this.serverRALbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverRALbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serverRALbl.Location = new System.Drawing.Point(12, 166);
            this.serverRALbl.Name = "serverRALbl";
            this.serverRALbl.Size = new System.Drawing.Size(74, 15);
            this.serverRALbl.TabIndex = 11;
            this.serverRALbl.Text = "Server RA:";
            // 
            // maxDelayLbl
            // 
            this.maxDelayLbl.AutoSize = true;
            this.maxDelayLbl.BackColor = System.Drawing.Color.Transparent;
            this.maxDelayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDelayLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxDelayLbl.Location = new System.Drawing.Point(12, 196);
            this.maxDelayLbl.Name = "maxDelayLbl";
            this.maxDelayLbl.Size = new System.Drawing.Size(80, 15);
            this.maxDelayLbl.TabIndex = 13;
            this.maxDelayLbl.Text = "Script path:";
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(103, 106);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(138, 20);
            this.usernameTb.TabIndex = 1;
            // 
            // clientRATb
            // 
            this.clientRATb.Location = new System.Drawing.Point(103, 136);
            this.clientRATb.Name = "clientRATb";
            this.clientRATb.Size = new System.Drawing.Size(138, 20);
            this.clientRATb.TabIndex = 2;
            // 
            // createCliBtn
            // 
            this.createCliBtn.Location = new System.Drawing.Point(134, 231);
            this.createCliBtn.Name = "createCliBtn";
            this.createCliBtn.Size = new System.Drawing.Size(75, 23);
            this.createCliBtn.TabIndex = 5;
            this.createCliBtn.Text = "Create";
            this.createCliBtn.UseVisualStyleBackColor = true;
            this.createCliBtn.Click += new System.EventHandler(this.createCliBtn_Click);
            // 
            // serverRATb
            // 
            this.serverRATb.Location = new System.Drawing.Point(103, 165);
            this.serverRATb.Name = "serverRATb";
            this.serverRATb.Size = new System.Drawing.Size(138, 20);
            this.serverRATb.TabIndex = 3;
            // 
            // scriptPathTb
            // 
            this.scriptPathTb.Location = new System.Drawing.Point(103, 195);
            this.scriptPathTb.Name = "scriptPathTb";
            this.scriptPathTb.Size = new System.Drawing.Size(138, 20);
            this.scriptPathTb.TabIndex = 4;
            // 
            // CreateClientForm
            // 
            this.AcceptButton = this.createCliBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PM.Properties.Resources.puppetBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 366);
            this.Controls.Add(this.scriptPathTb);
            this.Controls.Add(this.serverRATb);
            this.Controls.Add(this.createCliBtn);
            this.Controls.Add(this.clientRATb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.maxDelayLbl);
            this.Controls.Add(this.serverRALbl);
            this.Controls.Add(this.clientRALbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateClientForm";
            this.Text = "Puppet Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label backLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label clientRALbl;
        private System.Windows.Forms.Label serverRALbl;
        private System.Windows.Forms.Label maxDelayLbl;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox clientRATb;
        private System.Windows.Forms.Button createCliBtn;
        private System.Windows.Forms.TextBox serverRATb;
        private System.Windows.Forms.TextBox scriptPathTb;
    }
}