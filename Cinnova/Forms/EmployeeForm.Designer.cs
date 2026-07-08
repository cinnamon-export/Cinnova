namespace Cinnova.Forms
{
    partial class EmployeeForm
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbjobrole = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtemployeename = new System.Windows.Forms.TextBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lbljob = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvemployee = new System.Windows.Forms.DataGridView();
            this.labeltext = new System.Windows.Forms.Label();
            this.lblsubtopic = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(38)))), ((int)(((byte)(16)))));
            this.lbltitle.Location = new System.Drawing.Point(206, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(334, 41);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Employee Managment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbjobrole);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txtsalary);
            this.groupBox1.Controls.Add(this.txtemployeename);
            this.groupBox1.Controls.Add(this.lblsalary);
            this.groupBox1.Controls.Add(this.lbljob);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(213, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbjobrole
            // 
            this.cmbjobrole.FormattingEnabled = true;
            this.cmbjobrole.Items.AddRange(new object[] {
            "Owner",
            "Manager",
            "Staff"});
            this.cmbjobrole.Location = new System.Drawing.Point(9, 98);
            this.cmbjobrole.Name = "cmbjobrole";
            this.cmbjobrole.Size = new System.Drawing.Size(251, 24);
            this.cmbjobrole.TabIndex = 10;
            this.cmbjobrole.SelectedIndexChanged += new System.EventHandler(this.cmbjobrole_SelectedIndexChanged);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(16)))));
            this.btndelete.ForeColor = System.Drawing.Color.Transparent;
            this.btndelete.Location = new System.Drawing.Point(332, 128);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(88, 36);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(16)))));
            this.btnclear.ForeColor = System.Drawing.Color.Transparent;
            this.btnclear.Location = new System.Drawing.Point(332, 177);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(88, 36);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(16)))));
            this.btnupdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnupdate.Location = new System.Drawing.Point(332, 79);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(88, 36);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(16)))));
            this.btnadd.ForeColor = System.Drawing.Color.Transparent;
            this.btnadd.Location = new System.Drawing.Point(332, 23);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(88, 36);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(9, 177);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(252, 22);
            this.txtsalary.TabIndex = 5;
            // 
            // txtemployeename
            // 
            this.txtemployeename.Location = new System.Drawing.Point(9, 37);
            this.txtemployeename.Name = "txtemployeename";
            this.txtemployeename.Size = new System.Drawing.Size(252, 22);
            this.txtemployeename.TabIndex = 3;
            this.txtemployeename.TextChanged += new System.EventHandler(this.txtemployeename_TextChanged);
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.ForeColor = System.Drawing.Color.Black;
            this.lblsalary.Location = new System.Drawing.Point(6, 158);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(46, 16);
            this.lblsalary.TabIndex = 2;
            this.lblsalary.Text = "Salary";
            // 
            // lbljob
            // 
            this.lbljob.AutoSize = true;
            this.lbljob.ForeColor = System.Drawing.Color.Black;
            this.lbljob.Location = new System.Drawing.Point(7, 79);
            this.lbljob.Name = "lbljob";
            this.lbljob.Size = new System.Drawing.Size(62, 16);
            this.lbljob.TabIndex = 1;
            this.lbljob.Text = "Job Role";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(6, 18);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(109, 16);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Employee Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 580);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "User Management";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Customer Management";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Export Orders";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inventory Management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Production Management";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Farmer Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CINNAMON EXPORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinnova";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvemployee);
            this.groupBox2.Controls.Add(this.labeltext);
            this.groupBox2.Controls.Add(this.lblsubtopic);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(213, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dgvemployee
            // 
            this.dgvemployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemployee.Location = new System.Drawing.Point(6, 60);
            this.dgvemployee.Name = "dgvemployee";
            this.dgvemployee.RowHeadersWidth = 51;
            this.dgvemployee.RowTemplate.Height = 24;
            this.dgvemployee.Size = new System.Drawing.Size(647, 147);
            this.dgvemployee.TabIndex = 2;
            this.dgvemployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvemployee_CellContentClick);
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.Location = new System.Drawing.Point(7, 41);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(267, 16);
            this.labeltext.TabIndex = 1;
            this.labeltext.Text = "Manage and monitor your activity workforce.";
            this.labeltext.Click += new System.EventHandler(this.labeltext_Click);
            // 
            // lblsubtopic
            // 
            this.lblsubtopic.AutoSize = true;
            this.lblsubtopic.BackColor = System.Drawing.Color.Transparent;
            this.lblsubtopic.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(16)))));
            this.lblsubtopic.Location = new System.Drawing.Point(6, 18);
            this.lblsubtopic.Name = "lblsubtopic";
            this.lblsubtopic.Size = new System.Drawing.Size(158, 23);
            this.lblsubtopic.TabIndex = 0;
            this.lblsubtopic.Text = "Employee Directory";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(44, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Logout";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sales and Billing";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "Report and Analytics";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "Employee Management";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltitle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtemployeename;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lbljob;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblsubtopic;
        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.DataGridView dgvemployee;
        private System.Windows.Forms.ComboBox cmbjobrole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}