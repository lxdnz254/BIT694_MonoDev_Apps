namespace SelectAFolder
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
            this.SelectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ListResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(83, 191);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(118, 23);
            this.SelectFolder.TabIndex = 0;
            this.SelectFolder.Text = "Select Folder\r\n";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // ListResults
            // 
            this.ListResults.FormattingEnabled = true;
            this.ListResults.Location = new System.Drawing.Point(23, 28);
            this.ListResults.Name = "ListResults";
            this.ListResults.Size = new System.Drawing.Size(249, 147);
            this.ListResults.TabIndex = 1;
            this.ListResults.SelectedIndexChanged += new System.EventHandler(this.ListResults_SelectedIndexChanged);
            this.ListResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListResults_DoubleClick);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 253);
            this.Controls.Add(this.ListResults);
            this.Controls.Add(this.SelectFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox ListResults;
    }
}

