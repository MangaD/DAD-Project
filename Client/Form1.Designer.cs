namespace ClientForm
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
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.meetProposalButton = new System.Windows.Forms.Button();
            this.tcpStuffTextBox = new System.Windows.Forms.TextBox();
            this.joinButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.slotsNumberBox = new System.Windows.Forms.NumericUpDown();
            this.locationsTextBox = new System.Windows.Forms.TextBox();
            this.parserButton = new System.Windows.Forms.Button();
            this.meetingsListTextBox = new System.Windows.Forms.TextBox();
            this.listButton = new System.Windows.Forms.Button();
            this.closeMeetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slotsNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(12, 12);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(186, 22);
            this.topicTextBox.TabIndex = 0;
            // 
            // meetProposalButton
            // 
            this.meetProposalButton.Location = new System.Drawing.Point(204, 11);
            this.meetProposalButton.Name = "meetProposalButton";
            this.meetProposalButton.Size = new System.Drawing.Size(75, 23);
            this.meetProposalButton.TabIndex = 1;
            this.meetProposalButton.Text = "Meet";
            this.meetProposalButton.UseVisualStyleBackColor = true;
            this.meetProposalButton.Click += new System.EventHandler(this.meetProposalButton_Click);
            // 
            // tcpStuffTextBox
            // 
            this.tcpStuffTextBox.Location = new System.Drawing.Point(531, 13);
            this.tcpStuffTextBox.Name = "tcpStuffTextBox";
            this.tcpStuffTextBox.Size = new System.Drawing.Size(257, 22);
            this.tcpStuffTextBox.TabIndex = 2;
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(450, 12);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(75, 23);
            this.joinButton.TabIndex = 3;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(531, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // slotsNumberBox
            // 
            this.slotsNumberBox.Location = new System.Drawing.Point(12, 41);
            this.slotsNumberBox.Name = "slotsNumberBox";
            this.slotsNumberBox.Size = new System.Drawing.Size(120, 22);
            this.slotsNumberBox.TabIndex = 5;
            // 
            // locationsTextBox
            // 
            this.locationsTextBox.Location = new System.Drawing.Point(12, 70);
            this.locationsTextBox.Multiline = true;
            this.locationsTextBox.Name = "locationsTextBox";
            this.locationsTextBox.Size = new System.Drawing.Size(186, 368);
            this.locationsTextBox.TabIndex = 6;
            // 
            // parserButton
            // 
            this.parserButton.Location = new System.Drawing.Point(701, 415);
            this.parserButton.Name = "parserButton";
            this.parserButton.Size = new System.Drawing.Size(96, 23);
            this.parserButton.TabIndex = 7;
            this.parserButton.Text = "Script Client";
            this.parserButton.UseVisualStyleBackColor = true;
            this.parserButton.Click += new System.EventHandler(this.parserButton_Click);
            // 
            // meetingsListTextBox
            // 
            this.meetingsListTextBox.Location = new System.Drawing.Point(279, 70);
            this.meetingsListTextBox.Multiline = true;
            this.meetingsListTextBox.Name = "meetingsListTextBox";
            this.meetingsListTextBox.Size = new System.Drawing.Size(170, 339);
            this.meetingsListTextBox.TabIndex = 8;
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(279, 415);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(170, 23);
            this.listButton.TabIndex = 9;
            this.listButton.Text = "List";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // closeMeetButton
            // 
            this.closeMeetButton.Location = new System.Drawing.Point(286, 11);
            this.closeMeetButton.Name = "closeMeetButton";
            this.closeMeetButton.Size = new System.Drawing.Size(75, 23);
            this.closeMeetButton.TabIndex = 10;
            this.closeMeetButton.Text = "Close";
            this.closeMeetButton.UseVisualStyleBackColor = true;
            this.closeMeetButton.Click += new System.EventHandler(this.closeMeetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeMeetButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.meetingsListTextBox);
            this.Controls.Add(this.parserButton);
            this.Controls.Add(this.locationsTextBox);
            this.Controls.Add(this.slotsNumberBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.tcpStuffTextBox);
            this.Controls.Add(this.meetProposalButton);
            this.Controls.Add(this.topicTextBox);
            this.Name = "Form1";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.slotsNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.Button meetProposalButton;
        private System.Windows.Forms.TextBox tcpStuffTextBox;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown slotsNumberBox;
        private System.Windows.Forms.TextBox locationsTextBox;
        private System.Windows.Forms.Button parserButton;
        private System.Windows.Forms.TextBox meetingsListTextBox;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button closeMeetButton;
    }
}