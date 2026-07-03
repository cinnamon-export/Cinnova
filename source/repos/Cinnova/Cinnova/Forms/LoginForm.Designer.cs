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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblleaf = new Label();
            lbltitle = new Label();
            lblsubtitle = new Label();
            panelcard = new Panel();
            btnsignin = new Button();
            cmbrole = new ComboBox();
            cmbrolde = new Label();
            lbliconpassword = new Label();
            lbliconname = new Label();
            lblpassword = new Label();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            lblusername = new Label();
            lbldesc = new Label();
            lblwelcome = new Label();
            panelcard.SuspendLayout();
            SuspendLayout();
            // 
            // lblleaf
            // 
            lblleaf.AutoSize = true;
            lblleaf.BackColor = Color.Transparent;
            lblleaf.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblleaf.ForeColor = Color.LightGreen;
            lblleaf.Location = new Point(431, 0);
            lblleaf.Name = "lblleaf";
            lblleaf.Size = new Size(73, 50);
            lblleaf.TabIndex = 0;
            lblleaf.Text = "🌿";
            lblleaf.Click += lblleaf_Click;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.BackColor = Color.Transparent;
            lbltitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.Wheat;
            lbltitle.Location = new Point(383, 46);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(162, 50);
            lbltitle.TabIndex = 1;
            lbltitle.Text = "Cinnova";
            lbltitle.Click += label1_Click;
            // 
            // lblsubtitle
            // 
            lblsubtitle.AutoSize = true;
            lblsubtitle.BackColor = Color.Transparent;
            lblsubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsubtitle.ForeColor = Color.Wheat;
            lblsubtitle.Location = new Point(340, 94);
            lblsubtitle.Name = "lblsubtitle";
            lblsubtitle.Size = new Size(262, 20);
            lblsubtitle.TabIndex = 2;
            lblsubtitle.Text = "CINNAMON EXPORT MANAGMENT";
            lblsubtitle.Click += lblsubtitle_Click;
            // 
            // panelcard
            // 
            panelcard.Controls.Add(btnsignin);
            panelcard.Controls.Add(cmbrole);
            panelcard.Controls.Add(cmbrolde);
            panelcard.Controls.Add(lbliconpassword);
            panelcard.Controls.Add(lbliconname);
            panelcard.Controls.Add(lblpassword);
            panelcard.Controls.Add(txtpassword);
            panelcard.Controls.Add(txtusername);
            panelcard.Controls.Add(lblusername);
            panelcard.Controls.Add(lbldesc);
            panelcard.Controls.Add(lblwelcome);
            panelcard.Location = new Point(269, 124);
            panelcard.Name = "panelcard";
            panelcard.Size = new Size(388, 387);
            panelcard.TabIndex = 3;
            panelcard.Paint += panelcard_Paint;
            // 
            // btnsignin
            // 
            btnsignin.BackColor = Color.FromArgb(120, 54, 22);
            btnsignin.FlatStyle = FlatStyle.Flat;
            btnsignin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsignin.ForeColor = Color.White;
            btnsignin.Location = new Point(111, 326);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(157, 40);
            btnsignin.TabIndex = 10;
            btnsignin.Text = "Sign In";
            btnsignin.UseVisualStyleBackColor = false;
            btnsignin.Click += btnsignin_Click;
            // 
            // cmbrole
            // 
            cmbrole.FormattingEnabled = true;
            cmbrole.Items.AddRange(new object[] { "Owner", "Manager", "Staff" });
            cmbrole.Location = new Point(14, 263);
            cmbrole.Name = "cmbrole";
            cmbrole.Size = new Size(287, 28);
            cmbrole.TabIndex = 9;
            cmbrole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbrolde
            // 
            cmbrolde.AutoSize = true;
            cmbrolde.Location = new Point(14, 228);
            cmbrolde.Name = "cmbrolde";
            cmbrolde.Size = new Size(39, 20);
            cmbrolde.TabIndex = 8;
            cmbrolde.Text = "Role";
            // 
            // lbliconpassword
            // 
            lbliconpassword.AutoSize = true;
            lbliconpassword.BackColor = Color.FromArgb(250, 238, 218);
            lbliconpassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbliconpassword.Location = new Point(15, 186);
            lbliconpassword.Name = "lbliconpassword";
            lbliconpassword.Size = new Size(26, 17);
            lbliconpassword.TabIndex = 7;
            lbliconpassword.Text = "🔒";
            // 
            // lbliconname
            // 
            lbliconname.AutoSize = true;
            lbliconname.BackColor = Color.FromArgb(250, 238, 218);
            lbliconname.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbliconname.Location = new Point(15, 114);
            lbliconname.Name = "lbliconname";
            lbliconname.Size = new Size(26, 17);
            lbliconname.TabIndex = 6;
            lbliconname.Text = "👤";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(14, 155);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(70, 20);
            lblpassword.TabIndex = 5;
            lblpassword.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(250, 238, 218);
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(14, 180);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '.';
            txtpassword.PlaceholderText = "          Enter password";
            txtpassword.Size = new Size(287, 30);
            txtpassword.TabIndex = 4;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(250, 238, 218);
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(14, 107);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "         Enter username";
            txtusername.Size = new Size(287, 30);
            txtusername.TabIndex = 3;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(14, 79);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(75, 20);
            lblusername.TabIndex = 2;
            lblusername.Text = "Username";
            // 
            // lbldesc
            // 
            lbldesc.AutoSize = true;
            lbldesc.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldesc.ForeColor = Color.Gray;
            lbldesc.Location = new Point(8, 40);
            lbldesc.Name = "lbldesc";
            lbldesc.Size = new Size(328, 17);
            lbldesc.TabIndex = 1;
            lbldesc.Text = "Enter your credentials to access the export dashboard.";
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.ForeColor = Color.FromArgb(128, 64, 64);
            lblwelcome.Location = new Point(4, 3);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(208, 38);
            lblwelcome.TabIndex = 0;
            lblwelcome.Text = "Welcome Back";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 533);
            Controls.Add(lblsubtitle);
            Controls.Add(panelcard);
            Controls.Add(lbltitle);
            Controls.Add(lblleaf);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cinnova-Login";
            Load += LoginForm_Load;
            Resize += LoginForm_Resize;
            panelcard.ResumeLayout(false);
            panelcard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblleaf;
        private Label lbltitle;
        private Label lblsubtitle;
        private Panel panelcard;
        private Label lbldesc;
        private Label lblwelcome;
        private TextBox txtusername;
        private Label lblusername;
        private Label lbliconpassword;
        private Label lbliconname;
        private Label lblpassword;
        private TextBox txtpassword;
        private ComboBox cmbrole;
        private Label cmbrolde;
        private Button btnsignin;
    }
}