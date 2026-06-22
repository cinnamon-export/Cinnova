namespace Cinnova.Forms
{
    partial class LoginForm
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
            pnlHeader = new Panel();
            lblleaf = new Label();
            lblsubtitle = new Label();
            lblname = new Label();
            lblusername = new Label();
            lblpassword = new Label();
            lblrole = new Label();
            cmbrole = new ComboBox();
            btnlogin = new Button();
            pnlusername = new Panel();
            txtusername = new TextBox();
            lblusericon = new Label();
            pnlpassword = new Panel();
            txtpassword = new TextBox();
            lblpasswordicon = new Label();
            pnlHeader.SuspendLayout();
            pnlusername.SuspendLayout();
            pnlpassword.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.FromArgb(65, 36, 2);
            pnlHeader.Controls.Add(lblleaf);
            pnlHeader.Controls.Add(lblsubtitle);
            pnlHeader.Controls.Add(lblname);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(400, 120);
            pnlHeader.TabIndex = 0;
            // 
            // lblleaf
            // 
            lblleaf.AutoSize = true;
            lblleaf.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblleaf.ForeColor = Color.YellowGreen;
            lblleaf.Location = new Point(166, 10);
            lblleaf.Name = "lblleaf";
            lblleaf.Size = new Size(78, 54);
            lblleaf.TabIndex = 2;
            lblleaf.Text = "🌿";
            // 
            // lblsubtitle
            // 
            lblsubtitle.AutoSize = true;
            lblsubtitle.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsubtitle.ForeColor = Color.FromArgb(250, 199, 117);
            lblsubtitle.Location = new Point(115, 95);
            lblsubtitle.Name = "lblsubtitle";
            lblsubtitle.Size = new Size(182, 17);
            lblsubtitle.TabIndex = 1;
            lblsubtitle.Text = "Cinnamon Export Managment";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.ForeColor = Color.FromArgb(250, 238, 218);
            lblname.Location = new Point(142, 57);
            lblname.Name = "lblname";
            lblname.Size = new Size(123, 38);
            lblname.TabIndex = 0;
            lblname.Text = "Cinnova";
            lblname.Click += lblname_Click;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.FromArgb(133, 79, 11);
            lblusername.Location = new Point(40, 150);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(101, 23);
            lblusername.TabIndex = 1;
            lblusername.Text = "Username :";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            lblpassword.ForeColor = Color.FromArgb(133, 79, 11);
            lblpassword.Location = new Point(40, 225);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(94, 23);
            lblpassword.TabIndex = 3;
            lblpassword.Text = "Password :";
            // 
            // lblrole
            // 
            lblrole.AutoSize = true;
            lblrole.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            lblrole.ForeColor = Color.FromArgb(133, 79, 11);
            lblrole.Location = new Point(40, 313);
            lblrole.Name = "lblrole";
            lblrole.Size = new Size(56, 23);
            lblrole.TabIndex = 5;
            lblrole.Text = "Role :";
            // 
            // cmbrole
            // 
            cmbrole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbrole.BackColor = Color.FromArgb(250, 238, 218);
            cmbrole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbrole.ForeColor = Color.FromArgb(65, 36, 2);
            cmbrole.FormattingEnabled = true;
            cmbrole.Items.AddRange(new object[] { "Admin", "Manager", "Staff" });
            cmbrole.Location = new Point(39, 351);
            cmbrole.Name = "cmbrole";
            cmbrole.Size = new Size(310, 28);
            cmbrole.TabIndex = 6;
            // 
            // btnlogin
            // 
            btnlogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnlogin.BackColor = Color.FromArgb(99, 56, 6);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.FromArgb(250, 238, 218);
            btnlogin.Location = new Point(40, 460);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(264, 40);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "Sign In";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // pnlusername
            // 
            pnlusername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlusername.BackColor = Color.FromArgb(250, 238, 218);
            pnlusername.BorderStyle = BorderStyle.FixedSingle;
            pnlusername.Controls.Add(txtusername);
            pnlusername.Controls.Add(lblusericon);
            pnlusername.Location = new Point(40, 182);
            pnlusername.Name = "pnlusername";
            pnlusername.Size = new Size(305, 30);
            pnlusername.TabIndex = 9;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(250, 238, 218);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(48, 5);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(255, 23);
            txtusername.TabIndex = 1;
            txtusername.Text = "Enter Username";
            txtusername.TextChanged += txtusername_TextChanged;
            txtusername.Enter += txtusername_Enter;
            txtusername.Leave += txtusername_Leave;
            // 
            // lblusericon
            // 
            lblusericon.AutoSize = true;
            lblusericon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusericon.Location = new Point(3, 2);
            lblusericon.Name = "lblusericon";
            lblusericon.Size = new Size(33, 23);
            lblusericon.TabIndex = 0;
            lblusericon.Text = "👤";
            // 
            // pnlpassword
            // 
            pnlpassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlpassword.BackColor = Color.FromArgb(250, 238, 218);
            pnlpassword.BorderStyle = BorderStyle.FixedSingle;
            pnlpassword.Controls.Add(txtpassword);
            pnlpassword.Controls.Add(lblpasswordicon);
            pnlpassword.Location = new Point(40, 258);
            pnlpassword.Name = "pnlpassword";
            pnlpassword.Size = new Size(305, 30);
            pnlpassword.TabIndex = 11;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(250, 238, 218);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(48, 5);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(255, 23);
            txtpassword.TabIndex = 2;
            txtpassword.Text = "Enter Password";
            txtpassword.Enter += txtpassword_Enter;
            txtpassword.Leave += txtpassword_Leave;
            // 
            // lblpasswordicon
            // 
            lblpasswordicon.AutoSize = true;
            lblpasswordicon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpasswordicon.Location = new Point(-1, 2);
            lblpasswordicon.Name = "lblpasswordicon";
            lblpasswordicon.Size = new Size(38, 23);
            lblpasswordicon.TabIndex = 12;
            lblpasswordicon.Text = " 🔒";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 240);
            ClientSize = new Size(382, 513);
            Controls.Add(pnlpassword);
            Controls.Add(pnlusername);
            Controls.Add(btnlogin);
            Controls.Add(cmbrole);
            Controls.Add(lblrole);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cinnova-Login";
            Load += LoginForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlusername.ResumeLayout(false);
            pnlusername.PerformLayout();
            pnlpassword.ResumeLayout(false);
            pnlpassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblname;
        private Label lblsubtitle;
        private Label lblusername;
        private Label lblpassword;
        private Label lblrole;
        private ComboBox cmbrole;
        private Button btnlogin;
        private Label lblleaf;
        private Panel pnlusername;
        private Label lblusericon;
        private Panel pnlpassword;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label lblpasswordicon;
    }
}