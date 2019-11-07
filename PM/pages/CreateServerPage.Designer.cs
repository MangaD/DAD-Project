namespace PM.pages
{
    partial class CreateServerPage
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
            this.createSrvBtn = new System.Windows.Forms.Button();
            this.maxDelayNUD = new System.Windows.Forms.NumericUpDown();
            this.minDelayNUD = new System.Windows.Forms.NumericUpDown();
            this.maxFaultsNUD = new System.Windows.Forms.NumericUpDown();
            this.serverRATb = new System.Windows.Forms.TextBox();
            this.serverIDTb = new System.Windows.Forms.TextBox();
            this.maxDelayLbl = new System.Windows.Forms.Label();
            this.minDelayLbl = new System.Windows.Forms.Label();
            this.maxFaultsLbl = new System.Windows.Forms.Label();
            this.serverRALbl = new System.Windows.Forms.Label();
            this.serverIDLbl = new System.Windows.Forms.Label();
            this.backLbl = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maxDelayNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDelayNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxFaultsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // openScriptDialog
            // 
            this.openScriptDialog.FileName = "script.txt";
            // 
            // createSrvBtn
            // 
            this.createSrvBtn.Location = new System.Drawing.Point(134, 268);
            this.createSrvBtn.Name = "createSrvBtn";
            this.createSrvBtn.Size = new System.Drawing.Size(75, 23);
            this.createSrvBtn.TabIndex = 20;
            this.createSrvBtn.Text = "Create";
            this.createSrvBtn.UseVisualStyleBackColor = true;
            this.createSrvBtn.Click += new System.EventHandler(this.createSrvBtn_Click);
            // 
            // maxDelayNUD
            // 
            this.maxDelayNUD.Location = new System.Drawing.Point(104, 228);
            this.maxDelayNUD.Name = "maxDelayNUD";
            this.maxDelayNUD.Size = new System.Drawing.Size(138, 20);
            this.maxDelayNUD.TabIndex = 19;
            // 
            // minDelayNUD
            // 
            this.minDelayNUD.Location = new System.Drawing.Point(104, 196);
            this.minDelayNUD.Name = "minDelayNUD";
            this.minDelayNUD.Size = new System.Drawing.Size(138, 20);
            this.minDelayNUD.TabIndex = 18;
            // 
            // maxFaultsNUD
            // 
            this.maxFaultsNUD.Location = new System.Drawing.Point(104, 164);
            this.maxFaultsNUD.Name = "maxFaultsNUD";
            this.maxFaultsNUD.Size = new System.Drawing.Size(138, 20);
            this.maxFaultsNUD.TabIndex = 17;
            // 
            // serverRATb
            // 
            this.serverRATb.Location = new System.Drawing.Point(104, 134);
            this.serverRATb.Name = "serverRATb";
            this.serverRATb.Size = new System.Drawing.Size(138, 20);
            this.serverRATb.TabIndex = 16;
            // 
            // serverIDTb
            // 
            this.serverIDTb.Location = new System.Drawing.Point(104, 103);
            this.serverIDTb.Name = "serverIDTb";
            this.serverIDTb.Size = new System.Drawing.Size(138, 20);
            this.serverIDTb.TabIndex = 15;
            // 
            // maxDelayLbl
            // 
            this.maxDelayLbl.AutoSize = true;
            this.maxDelayLbl.BackColor = System.Drawing.Color.Transparent;
            this.maxDelayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDelayLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxDelayLbl.Location = new System.Drawing.Point(14, 228);
            this.maxDelayLbl.Name = "maxDelayLbl";
            this.maxDelayLbl.Size = new System.Drawing.Size(80, 15);
            this.maxDelayLbl.TabIndex = 26;
            this.maxDelayLbl.Text = "Max. delay:";
            // 
            // minDelayLbl
            // 
            this.minDelayLbl.AutoSize = true;
            this.minDelayLbl.BackColor = System.Drawing.Color.Transparent;
            this.minDelayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minDelayLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minDelayLbl.Location = new System.Drawing.Point(13, 196);
            this.minDelayLbl.Name = "minDelayLbl";
            this.minDelayLbl.Size = new System.Drawing.Size(77, 15);
            this.minDelayLbl.TabIndex = 25;
            this.minDelayLbl.Text = "Min. delay:";
            // 
            // maxFaultsLbl
            // 
            this.maxFaultsLbl.AutoSize = true;
            this.maxFaultsLbl.BackColor = System.Drawing.Color.Transparent;
            this.maxFaultsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxFaultsLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxFaultsLbl.Location = new System.Drawing.Point(13, 164);
            this.maxFaultsLbl.Name = "maxFaultsLbl";
            this.maxFaultsLbl.Size = new System.Drawing.Size(81, 15);
            this.maxFaultsLbl.TabIndex = 24;
            this.maxFaultsLbl.Text = "Max. faults:";
            // 
            // serverRALbl
            // 
            this.serverRALbl.AutoSize = true;
            this.serverRALbl.BackColor = System.Drawing.Color.Transparent;
            this.serverRALbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverRALbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serverRALbl.Location = new System.Drawing.Point(13, 135);
            this.serverRALbl.Name = "serverRALbl";
            this.serverRALbl.Size = new System.Drawing.Size(74, 15);
            this.serverRALbl.TabIndex = 23;
            this.serverRALbl.Text = "Server RA:";
            // 
            // serverIDLbl
            // 
            this.serverIDLbl.AutoSize = true;
            this.serverIDLbl.BackColor = System.Drawing.Color.Transparent;
            this.serverIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverIDLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serverIDLbl.Location = new System.Drawing.Point(13, 104);
            this.serverIDLbl.Name = "serverIDLbl";
            this.serverIDLbl.Size = new System.Drawing.Size(70, 15);
            this.serverIDLbl.TabIndex = 22;
            this.serverIDLbl.Text = "Server ID:";
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.BackColor = System.Drawing.Color.Transparent;
            this.backLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backLbl.Location = new System.Drawing.Point(13, 340);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(38, 15);
            this.backLbl.TabIndex = 21;
            this.backLbl.Text = "Back";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(69, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(209, 29);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "Create Server";
            // 
            // CreateServerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.createSrvBtn);
            this.Controls.Add(this.maxDelayNUD);
            this.Controls.Add(this.minDelayNUD);
            this.Controls.Add(this.maxFaultsNUD);
            this.Controls.Add(this.serverRATb);
            this.Controls.Add(this.serverIDTb);
            this.Controls.Add(this.maxDelayLbl);
            this.Controls.Add(this.minDelayLbl);
            this.Controls.Add(this.maxFaultsLbl);
            this.Controls.Add(this.serverRALbl);
            this.Controls.Add(this.serverIDLbl);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.titleLabel);
            this.Name = "CreateServerPage";
            this.Size = new System.Drawing.Size(346, 365);
            ((System.ComponentModel.ISupportInitialize)(this.maxDelayNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDelayNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxFaultsNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openScriptDialog;
        private System.Windows.Forms.Button createSrvBtn;
        private System.Windows.Forms.NumericUpDown maxDelayNUD;
        private System.Windows.Forms.NumericUpDown minDelayNUD;
        private System.Windows.Forms.NumericUpDown maxFaultsNUD;
        private System.Windows.Forms.TextBox serverRATb;
        private System.Windows.Forms.TextBox serverIDTb;
        private System.Windows.Forms.Label maxDelayLbl;
        private System.Windows.Forms.Label minDelayLbl;
        private System.Windows.Forms.Label maxFaultsLbl;
        private System.Windows.Forms.Label serverRALbl;
        private System.Windows.Forms.Label serverIDLbl;
        private System.Windows.Forms.Label backLbl;
        private System.Windows.Forms.Label titleLabel;
    }
}
