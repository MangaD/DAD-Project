namespace PM.pages
{
    partial class MainPage
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
            this.manageServersLbl = new System.Windows.Forms.Label();
            this.loadScriptLbl = new System.Windows.Forms.Label();
            this.createCliBtn = new System.Windows.Forms.Button();
            this.createServBtn = new System.Windows.Forms.Button();
            this.openScriptDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // manageServersLbl
            // 
            this.manageServersLbl.AutoSize = true;
            this.manageServersLbl.BackColor = System.Drawing.Color.Transparent;
            this.manageServersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageServersLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manageServersLbl.Location = new System.Drawing.Point(12, 339);
            this.manageServersLbl.Name = "manageServersLbl";
            this.manageServersLbl.Size = new System.Drawing.Size(109, 15);
            this.manageServersLbl.TabIndex = 12;
            this.manageServersLbl.Text = "Manage servers";
            this.manageServersLbl.Click += new System.EventHandler(this.manageServersLbl_Click);
            // 
            // loadScriptLbl
            // 
            this.loadScriptLbl.AutoSize = true;
            this.loadScriptLbl.BackColor = System.Drawing.Color.Transparent;
            this.loadScriptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadScriptLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadScriptLbl.Location = new System.Drawing.Point(233, 339);
            this.loadScriptLbl.Name = "loadScriptLbl";
            this.loadScriptLbl.Size = new System.Drawing.Size(102, 15);
            this.loadScriptLbl.TabIndex = 11;
            this.loadScriptLbl.Text = "Load script file";
            this.loadScriptLbl.Click += new System.EventHandler(this.loadScriptLbl_Click);
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
            this.createCliBtn.Location = new System.Drawing.Point(204, 148);
            this.createCliBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createCliBtn.Name = "createCliBtn";
            this.createCliBtn.Size = new System.Drawing.Size(83, 63);
            this.createCliBtn.TabIndex = 10;
            this.createCliBtn.TabStop = false;
            this.createCliBtn.Text = "Create Client";
            this.createCliBtn.UseVisualStyleBackColor = false;
            this.createCliBtn.Click += new System.EventHandler(this.createCliBtn_Click);
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
            this.createServBtn.Location = new System.Drawing.Point(48, 148);
            this.createServBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createServBtn.Name = "createServBtn";
            this.createServBtn.Size = new System.Drawing.Size(83, 63);
            this.createServBtn.TabIndex = 9;
            this.createServBtn.TabStop = false;
            this.createServBtn.Text = "Create Server";
            this.createServBtn.UseVisualStyleBackColor = false;
            this.createServBtn.Click += new System.EventHandler(this.createSrvBtn_Click);
            // 
            // openScriptDialog
            // 
            this.openScriptDialog.FileName = "script.txt";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.manageServersLbl);
            this.Controls.Add(this.loadScriptLbl);
            this.Controls.Add(this.createCliBtn);
            this.Controls.Add(this.createServBtn);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(346, 365);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manageServersLbl;
        private System.Windows.Forms.Label loadScriptLbl;
        private System.Windows.Forms.Button createCliBtn;
        private System.Windows.Forms.Button createServBtn;
        private System.Windows.Forms.OpenFileDialog openScriptDialog;
    }
}
