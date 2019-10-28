namespace PM
{
    partial class Form1
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
            this.lst_n_cli = new System.Windows.Forms.ListBox();
            this.lst_n_serv = new System.Windows.Forms.ListBox();
            this.btn_start_serv = new System.Windows.Forms.Button();
            this.btn_start_cli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_n_cli
            // 
            this.lst_n_cli.FormattingEnabled = true;
            this.lst_n_cli.ItemHeight = 16;
            this.lst_n_cli.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lst_n_cli.Location = new System.Drawing.Point(206, 70);
            this.lst_n_cli.Name = "lst_n_cli";
            this.lst_n_cli.Size = new System.Drawing.Size(77, 116);
            this.lst_n_cli.TabIndex = 3;
            // 
            // lst_n_serv
            // 
            this.lst_n_serv.FormattingEnabled = true;
            this.lst_n_serv.ItemHeight = 16;
            this.lst_n_serv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lst_n_serv.Location = new System.Drawing.Point(59, 70);
            this.lst_n_serv.Name = "lst_n_serv";
            this.lst_n_serv.Size = new System.Drawing.Size(84, 116);
            this.lst_n_serv.TabIndex = 4;
            // 
            // btn_start_serv
            // 
            this.btn_start_serv.Location = new System.Drawing.Point(59, 206);
            this.btn_start_serv.Name = "btn_start_serv";
            this.btn_start_serv.Size = new System.Drawing.Size(84, 42);
            this.btn_start_serv.TabIndex = 5;
            this.btn_start_serv.Text = "Start Servers";
            this.btn_start_serv.UseVisualStyleBackColor = true;
            this.btn_start_serv.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_start_cli
            // 
            this.btn_start_cli.Location = new System.Drawing.Point(206, 206);
            this.btn_start_cli.Name = "btn_start_cli";
            this.btn_start_cli.Size = new System.Drawing.Size(75, 42);
            this.btn_start_cli.TabIndex = 6;
            this.btn_start_cli.Text = "Start Clients";
            this.btn_start_cli.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_start_cli);
            this.Controls.Add(this.btn_start_serv);
            this.Controls.Add(this.lst_n_serv);
            this.Controls.Add(this.lst_n_cli);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lst_n_cli;
        private System.Windows.Forms.ListBox lst_n_serv;
        private System.Windows.Forms.Button btn_start_serv;
        private System.Windows.Forms.Button btn_start_cli;
    }
}

