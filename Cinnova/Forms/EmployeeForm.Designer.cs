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
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.txtemployeename = new System.Windows.Forms.TextBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lbljob = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvemployee = new System.Windows.Forms.DataGridView();
            this.labeltext = new System.Windows.Forms.Label();
            this.lblsubtopic = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(38)))), ((int)(((byte)(16)))));
            this.lbltitle.Location = new System.Drawing.Point(186, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(334, 41);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Employee Managment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txtsalary);
            this.groupBox1.Controls.Add(this.txtjob);
            this.groupBox1.Controls.Add(this.txtemployeename);
            this.groupBox1.Controls.Add(this.lblsalary);
            this.groupBox1.Controls.Add(this.lbljob);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(193, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 350);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(16)))));
            this.btndelete.ForeColor = System.Drawing.Color.Transparent;
            this.btndelete.Location = new System.Drawing.Point(192, 247);
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
            this.btnclear.Location = new System.Drawing.Point(286, 247);
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
            this.btnupdate.Location = new System.Drawing.Point(98, 247);
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
            this.btnadd.Location = new System.Drawing.Point(6, 247);
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
            // txtjob
            // 
            this.txtjob.Location = new System.Drawing.Point(9, 107);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(252, 22);
            this.txtjob.TabIndex = 4;
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
            this.lbljob.Location = new System.Drawing.Point(6, 88);
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
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(16)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 541);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvemployee);
            this.groupBox2.Controls.Add(this.labeltext);
            this.groupBox2.Controls.Add(this.lblsubtopic);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(579, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 398);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dgvemployee
            // 
            this.dgvemployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemployee.Location = new System.Drawing.Point(8, 67);
            this.dgvemployee.Name = "dgvemployee";
            this.dgvemployee.RowHeadersWidth = 51;
            this.dgvemployee.RowTemplate.Height = 24;
            this.dgvemployee.Size = new System.Drawing.Size(275, 313);
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
        private System.Windows.Forms.TextBox txtjob;
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
    }
}