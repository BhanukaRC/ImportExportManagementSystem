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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbairsea = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbexport = new System.Windows.Forms.RadioButton();
            this.rdbimport = new System.Windows.Forms.RadioButton();
            this.rdbfcl = new System.Windows.Forms.RadioButton();
            this.rdblcl = new System.Windows.Forms.RadioButton();
            this.lbldate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(266, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consignee Details";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shipper Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 137);
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
            this.tbJobID.TextChanged += new System.EventHandler(this.tbJobID_TextChanged);
            // 
            // tbSFName
            // 
            this.tbSFName.Location = new System.Drawing.Point(122, 112);
            this.tbSFName.Name = "tbSFName";
            this.tbSFName.Size = new System.Drawing.Size(100, 20);
            this.tbSFName.TabIndex = 8;
            this.tbSFName.TextChanged += new System.EventHandler(this.tbSFName_TextChanged);
            // 
            // tbSLName
            // 
            this.tbSLName.Location = new System.Drawing.Point(122, 138);
            this.tbSLName.Name = "tbSLName";
            this.tbSLName.Size = new System.Drawing.Size(100, 20);
            this.tbSLName.TabIndex = 9;
            this.tbSLName.TextChanged += new System.EventHandler(this.tbSLName_TextChanged);
            // 
            // tbCFName
            // 
            this.tbCFName.Location = new System.Drawing.Point(375, 112);
            this.tbCFName.Name = "tbCFName";
            this.tbCFName.Size = new System.Drawing.Size(100, 20);
            this.tbCFName.TabIndex = 10;
            this.tbCFName.TextChanged += new System.EventHandler(this.tbCFName_TextChanged);
            // 
            // tbCLName
            // 
            this.tbCLName.Location = new System.Drawing.Point(375, 138);
            this.tbCLName.Name = "tbCLName";
            this.tbCLName.Size = new System.Drawing.Size(100, 20);
            this.tbCLName.TabIndex = 11;
            this.tbCLName.TextChanged += new System.EventHandler(this.tbCLName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Air/Sea";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Import/Export";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cmbairsea
            // 
            this.cmbairsea.AutoCompleteCustomSource.AddRange(new string[] {
            "Air",
            "Sea"});
            this.cmbairsea.FormattingEnabled = true;
            this.cmbairsea.Items.AddRange(new object[] {
            "Air",
            "Sea"});
            this.cmbairsea.Location = new System.Drawing.Point(122, 219);
            this.cmbairsea.Name = "cmbairsea";
            this.cmbairsea.Size = new System.Drawing.Size(100, 21);
            this.cmbairsea.TabIndex = 21;
            this.cmbairsea.SelectedIndexChanged += new System.EventHandler(this.cmbairsea_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Type";
            // 
            // cmbtype
            // 
            this.cmbtype.AutoCompleteCustomSource.AddRange(new string[] {
            "Air",
            "Sea"});
            this.cmbtype.Enabled = false;
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Location = new System.Drawing.Point(122, 257);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(100, 21);
            this.cmbtype.TabIndex = 25;
            this.cmbtype.SelectedIndexChanged += new System.EventHandler(this.cmbtype_SelectedIndexChanged);
            // 
            // btnnext
            // 
            this.btnnext.Enabled = false;
            this.btnnext.Location = new System.Drawing.Point(400, 301);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 26;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbexport);
            this.panel1.Controls.Add(this.rdbimport);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-2, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 39);
            this.panel1.TabIndex = 27;
            // 
            // rdbexport
            // 
            this.rdbexport.AutoSize = true;
            this.rdbexport.Location = new System.Drawing.Point(271, 7);
            this.rdbexport.Name = "rdbexport";
            this.rdbexport.Size = new System.Drawing.Size(55, 17);
            this.rdbexport.TabIndex = 22;
            this.rdbexport.TabStop = true;
            this.rdbexport.Text = "Export";
            this.rdbexport.UseVisualStyleBackColor = true;
            this.rdbexport.CheckedChanged += new System.EventHandler(this.rdbexport_CheckedChanged);
            // 
            // rdbimport
            // 
            this.rdbimport.AutoSize = true;
            this.rdbimport.Location = new System.Drawing.Point(127, 7);
            this.rdbimport.Name = "rdbimport";
            this.rdbimport.Size = new System.Drawing.Size(54, 17);
            this.rdbimport.TabIndex = 21;
            this.rdbimport.TabStop = true;
            this.rdbimport.Text = "Import";
            this.rdbimport.UseVisualStyleBackColor = true;
            this.rdbimport.CheckedChanged += new System.EventHandler(this.rdbimport_CheckedChanged);
            // 
            // rdbfcl
            // 
            this.rdbfcl.AutoSize = true;
            this.rdbfcl.Enabled = false;
            this.rdbfcl.Location = new System.Drawing.Point(269, 222);
            this.rdbfcl.Name = "rdbfcl";
            this.rdbfcl.Size = new System.Drawing.Size(44, 17);
            this.rdbfcl.TabIndex = 23;
            this.rdbfcl.TabStop = true;
            this.rdbfcl.Text = "FCL";
            this.rdbfcl.UseVisualStyleBackColor = true;
            this.rdbfcl.CheckedChanged += new System.EventHandler(this.rdbfcl_CheckedChanged);
            // 
            // rdblcl
            // 
            this.rdblcl.AutoSize = true;
            this.rdblcl.Enabled = false;
            this.rdblcl.Location = new System.Drawing.Point(375, 222);
            this.rdblcl.Name = "rdblcl";
            this.rdblcl.Size = new System.Drawing.Size(44, 17);
            this.rdblcl.TabIndex = 28;
            this.rdblcl.TabStop = true;
            this.rdblcl.Text = "LCL";
            this.rdblcl.UseVisualStyleBackColor = true;
            this.rdblcl.CheckedChanged += new System.EventHandler(this.rdblcl_CheckedChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(122, 57);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 13);
            this.lbldate.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 336);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.rdblcl);
            this.Controls.Add(this.rdbfcl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbairsea);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            this.Text = "Job Card";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbairsea;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbexport;
        private System.Windows.Forms.RadioButton rdbimport;
        private System.Windows.Forms.RadioButton rdbfcl;
        private System.Windows.Forms.RadioButton rdblcl;
        private System.Windows.Forms.Label lbldate;
    }
}

