namespace Cinnova.Forms
{
    partial class UserManagementForm
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
            txtFullName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            cmbRole = new ComboBox();
            btnAddUser = new Button();
            dgvUsers = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnTestLogin = new Button();
            txtSearch = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.Location = new Point(293, 99);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(176, 30);
            txtFullName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(140, 106);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(140, 188);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(140, 231);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(140, 148);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 4;
            label4.Text = "Assign Role";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(293, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(293, 184);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(176, 27);
            txtUsername.TabIndex = 6;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Owner", "Manager", "Staff" });
            cmbRole.Location = new Point(293, 143);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(176, 28);
            cmbRole.TabIndex = 7;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Segoe UI", 10F);
            btnAddUser.Location = new Point(224, 292);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(94, 38);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Register";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(487, 12);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(537, 419);
            dgvUsers.TabIndex = 9;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.Location = new Point(224, 347);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 32);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(224, 399);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 32);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnTestLogin
            // 
            btnTestLogin.Location = new Point(69, 337);
            btnTestLogin.Name = "btnTestLogin";
            btnTestLogin.Size = new Size(94, 29);
            btnTestLogin.TabIndex = 12;
            btnTestLogin.Text = "Test login engine";
            btnTestLogin.UseVisualStyleBackColor = true;
            btnTestLogin.Click += btnTestLogin_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(224, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(146, 27);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(97, 13);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 14;
            label5.Text = "Search Users";
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 472);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(btnTestLogin);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvUsers);
            Controls.Add(btnAddUser);
            Controls.Add(cmbRole);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFullName);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private ComboBox cmbRole;
        private Button btnAddUser;
        private DataGridView dgvUsers;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnTestLogin;
        private TextBox txtSearch;
        private Label label5;
    }
}