namespace Cinnova.Forms
{
    partial class UserManagementForm
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddUser = new Button();
            dgvUsers = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            label5 = new Label();
            sidebarControl1 = new SidebarControl();
            materialCard1 = new Panel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            cmbRole = new ComboBox();
            txtFullName = new ComboBox();
            materialCard2 = new Panel();
            txtSearch = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 1;
            label1.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(17, 218);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(17, 342);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(17, 104);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 4;
            label4.Text = "Job Role";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(76, 38, 16);
            btnAddUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(220, 602);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(94, 38);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Register";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(17, 82);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(617, 404);
            dgvUsers.TabIndex = 9;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(76, 38, 16);
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(447, 602);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(76, 38, 16);
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(332, 602);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 38);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(76, 38, 16);
            label5.Location = new Point(17, 23);
            label5.Name = "label5";
            label5.Size = new Size(137, 28);
            label5.TabIndex = 14;
            label5.Text = "System Users";
            // 
            // sidebarControl1
            // 
            sidebarControl1.BackColor = Color.FromArgb(76, 38, 16);
            sidebarControl1.Dock = DockStyle.Left;
            sidebarControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sidebarControl1.Location = new Point(0, 0);
            sidebarControl1.Margin = new Padding(4);
            sidebarControl1.Name = "sidebarControl1";
            sidebarControl1.Size = new Size(202, 673);
            sidebarControl1.TabIndex = 15;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(txtPassword);
            materialCard1.Controls.Add(txtUsername);
            materialCard1.Controls.Add(cmbRole);
            materialCard1.Controls.Add(txtFullName);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(label4);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(label3);
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(220, 107);
            materialCard1.Margin = new Padding(14);
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(297, 447);
            materialCard1.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(17, 384);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(247, 30);
            txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(17, 266);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(247, 30);
            txtUsername.TabIndex = 10;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.FromArgb(255, 255, 255);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 10F);
            cmbRole.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Owner", "Manager", "Staff" });
            cmbRole.Location = new Point(17, 149);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(230, 31);
            cmbRole.TabIndex = 9;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(255, 255, 255);
            txtFullName.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtFullName.FormattingEnabled = true;
            txtFullName.Items.AddRange(new object[] { "Nimal Perera", "Kavindi Silva", "Dinesh Fernando", "Amaya Jayasinghe", "Tharindu Wijesinghe", "Saduni Gunawardena", "Hasitha Ranasinghe", "Piyumi Senanayake" });
            txtFullName.Location = new Point(17, 48);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(230, 31);
            txtFullName.TabIndex = 8;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(txtSearch);
            materialCard2.Controls.Add(dgvUsers);
            materialCard2.Controls.Add(label5);
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(578, 107);
            materialCard2.Margin = new Padding(14);
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(651, 503);
            materialCard2.TabIndex = 18;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(177, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(199, 30);
            txtSearch.TabIndex = 15;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 247, 234);
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(76, 38, 16);
            label6.Location = new Point(220, 30);
            label6.Name = "label6";
            label6.Size = new Size(276, 41);
            label6.TabIndex = 16;
            label6.Text = "User Management";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 247, 234);
            panel1.Controls.Add(materialCard2);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(materialCard1);
            panel1.Controls.Add(btnAddUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 673);
            panel1.TabIndex = 19;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(sidebarControl1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            MinimumSize = new Size(900, 580);
            Name = "UserManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Management";
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private SidebarControl sidebarControl1;
        private System.Windows.Forms.Panel materialCard1;
        private System.Windows.Forms.ComboBox txtFullName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Panel materialCard2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}