namespace Downloader
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
            this.DownloadButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Link = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.ToolsTitle = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(352, 495);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(194, 69);
            this.DownloadButton.TabIndex = 1;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPanel.Controls.Add(this.LinkLabel);
            this.MainPanel.Controls.Add(this.ToolsTitle);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Controls.Add(this.Link);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.progressBar1);
            this.MainPanel.Controls.Add(this.button3);
            this.MainPanel.Controls.Add(this.AddButton);
            this.MainPanel.Controls.Add(this.label);
            this.MainPanel.Controls.Add(this.comboBox);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(891, 465);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 17;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(286, 80);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(248, 22);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 38);
            this.button3.TabIndex = 8;
            this.button3.Text = "Select folder for download";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(768, 217);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(84, 32);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(38, 74);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 20);
            this.label.TabIndex = 6;
            this.label.Click += new System.EventHandler(this.Label1_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownHeight = 150;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.IntegralHeight = false;
            this.comboBox.ItemHeight = 20;
            this.comboBox.Location = new System.Drawing.Point(40, 18);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(494, 28);
            this.comboBox.TabIndex = 5;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(600, 495);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(218, 24);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "Delete images after install";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(600, 540);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(186, 24);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "Install after download";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.FolderBrowserDialog1_HelpRequest);
            // 
            // Link
            // 
            this.Link.Location = new System.Drawing.Point(684, 174);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(168, 26);
            this.Link.TabIndex = 18;
            this.Link.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(684, 132);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(167, 26);
            this.Title.TabIndex = 19;
            this.Title.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ToolsTitle
            // 
            this.ToolsTitle.AutoSize = true;
            this.ToolsTitle.Location = new System.Drawing.Point(584, 135);
            this.ToolsTitle.Name = "ToolsTitle";
            this.ToolsTitle.Size = new System.Drawing.Size(80, 20);
            this.ToolsTitle.TabIndex = 20;
            this.ToolsTitle.Text = "Tools Title";
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(584, 177);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(80, 20);
            this.LinkLabel.TabIndex = 21;
            this.LinkLabel.Text = "Tools Link";
            this.LinkLabel.Click += new System.EventHandler(this.LinkLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 577);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Name = "Form1";
            this.Text = "Downloader";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.Label ToolsTitle;
    }
}

