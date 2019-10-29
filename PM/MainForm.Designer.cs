namespace PM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createServBtn = new System.Windows.Forms.Button();
            this.createCliBtn = new System.Windows.Forms.Button();
            this.loadScriptLbl = new System.Windows.Forms.Label();
            this.openScriptDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // createServBtn
            // 
            this.createServBtn.BackColor = System.Drawing.Color.Transparent;
            this.createServBtn.FlatAppearance.BorderSize = 0;
            this.createServBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.createServBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.createServBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createServBtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createServBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createServBtn.Location = new System.Drawing.Point(48, 151);
            this.createServBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createServBtn.Name = "createServBtn";
            this.createServBtn.Size = new System.Drawing.Size(83, 63);
            this.createServBtn.TabIndex = 5;
            this.createServBtn.Text = "Create Server";
            this.createServBtn.UseVisualStyleBackColor = false;
            this.createServBtn.Click += new System.EventHandler(this.createSrvBtn_Click);
            // 
            // createCliBtn
            // 
            this.createCliBtn.BackColor = System.Drawing.Color.Transparent;
            this.createCliBtn.FlatAppearance.BorderSize = 0;
            this.createCliBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.createCliBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.createCliBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCliBtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCliBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createCliBtn.Location = new System.Drawing.Point(204, 151);
            this.createCliBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createCliBtn.Name = "createCliBtn";
            this.createCliBtn.Size = new System.Drawing.Size(83, 63);
            this.createCliBtn.TabIndex = 6;
            this.createCliBtn.Text = "Create Client";
            this.createCliBtn.UseVisualStyleBackColor = false;
            // 
            // loadScriptLbl
            // 
            this.loadScriptLbl.AutoSize = true;
            this.loadScriptLbl.BackColor = System.Drawing.Color.Transparent;
            this.loadScriptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadScriptLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadScriptLbl.Location = new System.Drawing.Point(221, 342);
            this.loadScriptLbl.Name = "loadScriptLbl";
            this.loadScriptLbl.Size = new System.Drawing.Size(114, 15);
            this.loadScriptLbl.TabIndex = 7;
            this.loadScriptLbl.Text = "Load script file...";
            this.loadScriptLbl.Click += new System.EventHandler(this.loadScriptLbl_Click);
            // 
            // openScriptDialog
            // 
            this.openScriptDialog.FileName = "script.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 366);
            this.Controls.Add(this.loadScriptLbl);
            this.Controls.Add(this.createCliBtn);
            this.Controls.Add(this.createServBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Puppet Master";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createServBtn;
        private System.Windows.Forms.Button createCliBtn;
        private System.Windows.Forms.Label loadScriptLbl;
        private System.Windows.Forms.OpenFileDialog openScriptDialog;
    }
}

