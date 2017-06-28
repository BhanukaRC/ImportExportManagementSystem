namespace ImportExportManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbJobID = new System.Windows.Forms.TextBox();
            this.tbSFName = new System.Windows.Forms.TextBox();
            this.tbSLName = new System.Windows.Forms.TextBox();
            this.tbCFName = new System.Windows.Forms.TextBox();
            this.tbCLName = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "JobID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consignee Details";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shipper Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Last Name";
            // 
            // tbJobID
            // 
            this.tbJobID.Location = new System.Drawing.Point(125, 28);
            this.tbJobID.Name = "tbJobID";
            this.tbJobID.Size = new System.Drawing.Size(100, 20);
            this.tbJobID.TabIndex = 7;
            // 
            // tbSFName
            // 
            this.tbSFName.Location = new System.Drawing.Point(125, 91);
            this.tbSFName.Name = "tbSFName";
            this.tbSFName.Size = new System.Drawing.Size(100, 20);
            this.tbSFName.TabIndex = 8;
            // 
            // tbSLName
            // 
            this.tbSLName.Location = new System.Drawing.Point(125, 117);
            this.tbSLName.Name = "tbSLName";
            this.tbSLName.Size = new System.Drawing.Size(100, 20);
            this.tbSLName.TabIndex = 9;
            // 
            // tbCFName
            // 
            this.tbCFName.Location = new System.Drawing.Point(395, 91);
            this.tbCFName.Name = "tbCFName";
            this.tbCFName.Size = new System.Drawing.Size(100, 20);
            this.tbCFName.TabIndex = 10;
            // 
            // tbCLName
            // 
            this.tbCLName.Location = new System.Drawing.Point(395, 117);
            this.tbCLName.Name = "tbCLName";
            this.tbCLName.Size = new System.Drawing.Size(100, 20);
            this.tbCLName.TabIndex = 11;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(410, 197);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 239);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.tbCLName);
            this.Controls.Add(this.tbCFName);
            this.Controls.Add(this.tbSLName);
            this.Controls.Add(this.tbSFName);
            this.Controls.Add(this.tbJobID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbJobID;
        private System.Windows.Forms.TextBox tbSFName;
        private System.Windows.Forms.TextBox tbSLName;
        private System.Windows.Forms.TextBox tbCFName;
        private System.Windows.Forms.TextBox tbCLName;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox textBox1;
    }
}

