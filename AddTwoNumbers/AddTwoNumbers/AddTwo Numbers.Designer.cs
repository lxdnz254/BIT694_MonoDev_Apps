namespace AddTwoNumbers
{
    partial class AddTwoNumbers
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
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.GroupAddNumberdsBox = new System.Windows.Forms.GroupBox();
            this.GroupAddNumberdsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(6, 19);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(35, 20);
            this.FirstNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(66, 19);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(33, 20);
            this.SecondNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(124, 22);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(28, 13);
            this.Sum.TabIndex = 4;
            this.Sum.Text = "Sum\r\n";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(6, 71);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(87, 71);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(164, 71);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // GroupAddNumberdsBox
            // 
            this.GroupAddNumberdsBox.Controls.Add(this.Add);
            this.GroupAddNumberdsBox.Controls.Add(this.Sum);
            this.GroupAddNumberdsBox.Controls.Add(this.Clear);
            this.GroupAddNumberdsBox.Controls.Add(this.label2);
            this.GroupAddNumberdsBox.Controls.Add(this.Exit);
            this.GroupAddNumberdsBox.Controls.Add(this.SecondNumber);
            this.GroupAddNumberdsBox.Controls.Add(this.FirstNumber);
            this.GroupAddNumberdsBox.Controls.Add(this.label1);
            this.GroupAddNumberdsBox.Location = new System.Drawing.Point(24, 35);
            this.GroupAddNumberdsBox.Name = "GroupAddNumberdsBox";
            this.GroupAddNumberdsBox.Size = new System.Drawing.Size(248, 100);
            this.GroupAddNumberdsBox.TabIndex = 8;
            this.GroupAddNumberdsBox.TabStop = false;
            this.GroupAddNumberdsBox.Text = "Add Two Numbers";
            // 
            // AddTwoNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.GroupAddNumberdsBox);
            this.Name = "AddTwoNumbers";
            this.Text = "Form1";
            this.GroupAddNumberdsBox.ResumeLayout(false);
            this.GroupAddNumberdsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.GroupBox GroupAddNumberdsBox;
    }
}

