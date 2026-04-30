namespace FileCountReporter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblPath = new Label();
            lblResultsTitle = new Label();
            lblFiles = new Label();
            lblFolders = new Label();
            lblTypesTitle = new Label();
            txtPath = new TextBox();
            btnBrowse = new Button();
            btnScan = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(239, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(255, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "File Type Analyzer";
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(32, 95);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(175, 41);
            lblPath.TabIndex = 1;
            lblPath.Text = "Folder Path:";
            // 
            // lblResultsTitle
            // 
            lblResultsTitle.AutoSize = true;
            lblResultsTitle.Location = new Point(32, 172);
            lblResultsTitle.Name = "lblResultsTitle";
            lblResultsTitle.Size = new Size(111, 41);
            lblResultsTitle.TabIndex = 2;
            lblResultsTitle.Text = "Results";
            // 
            // lblFiles
            // 
            lblFiles.AutoSize = true;
            lblFiles.Location = new Point(32, 245);
            lblFiles.Name = "lblFiles";
            lblFiles.Size = new Size(178, 41);
            lblFiles.TabIndex = 3;
            lblFiles.Text = "Total Files: 0";
            // 
            // lblFolders
            // 
            lblFolders.AutoSize = true;
            lblFolders.Location = new Point(32, 311);
            lblFolders.Name = "lblFolders";
            lblFolders.Size = new Size(217, 41);
            lblFolders.TabIndex = 4;
            lblFolders.Text = "Total Folders: 0";
            // 
            // lblTypesTitle
            // 
            lblTypesTitle.AutoSize = true;
            lblTypesTitle.Location = new Point(32, 373);
            lblTypesTitle.Name = "lblTypesTitle";
            lblTypesTitle.Size = new Size(147, 41);
            lblTypesTitle.TabIndex = 5;
            lblTypesTitle.Text = "File Types";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(239, 95);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(250, 47);
            txtPath.TabIndex = 6;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(567, 89);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(188, 58);
            btnBrowse.TabIndex = 7;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            btnScan.Location = new Point(325, 202);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(188, 58);
            btnScan.TabIndex = 8;
            btnScan.Text = "Scan Folder";
            btnScan.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(336, 340);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(188, 58);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnScan);
            Controls.Add(btnBrowse);
            Controls.Add(txtPath);
            Controls.Add(lblTypesTitle);
            Controls.Add(lblFolders);
            Controls.Add(lblFiles);
            Controls.Add(lblResultsTitle);
            Controls.Add(lblPath);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPath;
        private Label lblResultsTitle;
        private Label lblFiles;
        private Label lblFolders;
        private Label lblTypesTitle;
        private TextBox txtPath;
        private Button btnBrowse;
        private Button btnScan;
        private Button btnExit;
    }
}
