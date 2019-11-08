namespace MSDAD_CLI
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
            this.pagesPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pagesPanel
            // 
            this.pagesPanel.BackColor = System.Drawing.Color.Transparent;
            this.pagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesPanel.Location = new System.Drawing.Point(0, 0);
            this.pagesPanel.Name = "pagesPanel";
            this.pagesPanel.Size = new System.Drawing.Size(349, 366);
            this.pagesPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 366);
            this.Controls.Add(this.pagesPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Meeting Scheduler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pagesPanel;
    }
}