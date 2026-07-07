namespace Cinnova.Forms
{
    partial class UserManagementForm
    {
        
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        
        // Clean up any resources being used.
        //<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            txtUsername = new MaterialSkin.Controls.MaterialTextBox2();
            cmbRole = new MaterialSkin.Controls.MaterialComboBox();
            txtFullName = new MaterialSkin.Controls.MaterialComboBox();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox2();
            label6 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
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
            label2.Click += label2_Click;
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
            btnAddUser.Location = new Point(220, 604);
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
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(457, 608);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 32);
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
            btnUpdate.Location = new Point(337, 605);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
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
            sidebarControl1.Location = new Point(3, 64);
            sidebarControl1.Margin = new Padding(4);
            sidebarControl1.Name = "sidebarControl1";
            sidebarControl1.Size = new Size(202, 606);
            sidebarControl1.TabIndex = 15;
            sidebarControl1.Load += sidebarControl1_Load;
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
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(223, 140);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(297, 447);
            materialCard1.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.HideSelection = true;
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(17, 384);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(247, 36);
            txtPassword.TabIndex = 11;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.UseTallSize = false;
            // 
            // txtUsername
            // 
            txtUsername.AnimateReadOnly = false;
            txtUsername.BackgroundImageLayout = ImageLayout.None;
            txtUsername.CharacterCasing = CharacterCasing.Normal;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.HideSelection = true;
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(17, 266);
            txtUsername.MaxLength = 32767;
            txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PrefixSuffixText = null;
            txtUsername.ReadOnly = false;
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.ShortcutsEnabled = true;
            txtUsername.Size = new Size(247, 36);
            txtUsername.TabIndex = 10;
            txtUsername.TabStop = false;
            txtUsername.TextAlign = HorizontalAlignment.Left;
            txtUsername.TrailingIcon = null;
            txtUsername.UseSystemPasswordChar = false;
            txtUsername.UseTallSize = false;
            // 
            // cmbRole
            // 
            cmbRole.AutoResize = false;
            cmbRole.BackColor = Color.FromArgb(255, 255, 255);
            cmbRole.Depth = 0;
            cmbRole.DrawMode = DrawMode.OwnerDrawVariable;
            cmbRole.DropDownHeight = 118;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.DropDownWidth = 121;
            cmbRole.Font = new Font("Segoe UI", 10F);
            cmbRole.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.IntegralHeight = false;
            cmbRole.ItemHeight = 29;
            cmbRole.Items.AddRange(new object[] { "Owner", "Manager", "Staff" });
            cmbRole.Location = new Point(17, 149);
            cmbRole.MaxDropDownItems = 4;
            cmbRole.MouseState = MaterialSkin.MouseState.OUT;
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(230, 35);
            cmbRole.StartIndex = 0;
            cmbRole.TabIndex = 9;
            cmbRole.UseTallSize = false;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged_1;
            // 
            // txtFullName
            // 
            txtFullName.AutoResize = false;
            txtFullName.BackColor = Color.FromArgb(255, 255, 255);
            txtFullName.Depth = 0;
            txtFullName.DrawMode = DrawMode.OwnerDrawVariable;
            txtFullName.DropDownHeight = 118;
            txtFullName.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFullName.DropDownWidth = 121;
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtFullName.FormattingEnabled = true;
            txtFullName.IntegralHeight = false;
            txtFullName.ItemHeight = 29;
            txtFullName.Items.AddRange(new object[] { "Nimal Perera", "Kavindi Silva", "Dinesh Fernando", "Amaya Jayasinghe", "Tharindu Wijesinghe", "Saduni Gunawardena", "Hasitha Ranasinghe", "Piyumi Senanayake" });
            txtFullName.Location = new Point(17, 48);
            txtFullName.MaxDropDownItems = 4;
            txtFullName.MouseState = MaterialSkin.MouseState.OUT;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(230, 35);
            txtFullName.StartIndex = 0;
            txtFullName.TabIndex = 8;
            txtFullName.UseTallSize = false;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(txtSearch);
            materialCard2.Controls.Add(dgvUsers);
            materialCard2.Controls.Add(label5);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(581, 126);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(651, 503);
            materialCard2.TabIndex = 18;
            // 
            // txtSearch
            // 
            txtSearch.AnimateReadOnly = false;
            txtSearch.BackgroundImageLayout = ImageLayout.None;
            txtSearch.CharacterCasing = CharacterCasing.Normal;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.HideSelection = true;
            txtSearch.Hint = "Search User";
            txtSearch.LeadingIcon = (Image)resources.GetObject("txtSearch.LeadingIcon");
            txtSearch.Location = new Point(177, 23);
            txtSearch.MaxLength = 32767;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PrefixSuffixText = null;
            txtSearch.ReadOnly = false;
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.ShortcutsEnabled = true;
            txtSearch.Size = new Size(199, 36);
            txtSearch.TabIndex = 15;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TrailingIcon = null;
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.UseTallSize = false;
            txtSearch.Click += txtSearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 247, 234);
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(76, 38, 16);
            label6.Location = new Point(223, 76);
            label6.Name = "label6";
            label6.Size = new Size(276, 41);
            label6.TabIndex = 16;
            label6.Text = "User Management";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 247, 234);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 606);
            panel1.TabIndex = 19;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Controls.Add(label6);
            Controls.Add(sidebarControl1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAddUser);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            MinimumSize = new Size(900, 580);
            Name = "UserManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserManagementForm";
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddUser;
        private DataGridView dgvUsers;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label5;
        private SidebarControl sidebarControl1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox txtFullName;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtUsername;
        private MaterialSkin.Controls.MaterialComboBox cmbRole;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearch;
        private Label label6;
        private Panel panel1;
    }
}