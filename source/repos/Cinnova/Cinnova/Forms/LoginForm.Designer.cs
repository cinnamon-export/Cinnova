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
            panelcard = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            cmbrole = new MaterialSkin.Controls.MaterialComboBox();
            txtpassword = new MaterialSkin.Controls.MaterialTextBox2();
            txtusername = new MaterialSkin.Controls.MaterialTextBox2();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            panelcard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelcard
            // 
            panelcard.Controls.Add(pictureBox2);
            panelcard.Controls.Add(label1);
            panelcard.Controls.Add(materialLabel2);
            panelcard.Controls.Add(cmbrole);
            panelcard.Controls.Add(txtpassword);
            panelcard.Controls.Add(txtusername);
            panelcard.Controls.Add(materialButton1);
            panelcard.Font = new Font("Segoe UI", 10F);
            panelcard.Location = new Point(276, 110);
            panelcard.Name = "panelcard";
            panelcard.Size = new Size(425, 520);
            panelcard.TabIndex = 3;
            panelcard.Paint += panelcard_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(359, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(99, 149);
            label1.Name = "label1";
            label1.Size = new Size(221, 41);
            label1.TabIndex = 16;
            label1.Text = "Welcome Back";
            label1.Click += label1_Click_1;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel2.Location = new Point(20, 208);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(382, 19);
            materialLabel2.TabIndex = 15;
            materialLabel2.Text = "Enter your credentials to access the export dashboard.";
            materialLabel2.Click += materialLabel2_Click;
            // 
            // cmbrole
            // 
            cmbrole.AutoResize = false;
            cmbrole.BackColor = Color.FromArgb(255, 255, 255);
            cmbrole.Depth = 0;
            cmbrole.DrawMode = DrawMode.OwnerDrawVariable;
            cmbrole.DropDownHeight = 118;
            cmbrole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbrole.DropDownWidth = 121;
            cmbrole.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbrole.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbrole.FormattingEnabled = true;
            cmbrole.Hint = "Role";
            cmbrole.IntegralHeight = false;
            cmbrole.ItemHeight = 29;
            cmbrole.Items.AddRange(new object[] { "Owner", "Manager", "Staff" });
            cmbrole.Location = new Point(61, 385);
            cmbrole.MaxDropDownItems = 4;
            cmbrole.MouseState = MaterialSkin.MouseState.OUT;
            cmbrole.Name = "cmbrole";
            cmbrole.Size = new Size(287, 35);
            cmbrole.StartIndex = 0;
            cmbrole.TabIndex = 13;
            cmbrole.UseTallSize = false;
            cmbrole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtpassword
            // 
            txtpassword.AnimateReadOnly = false;
            txtpassword.BackgroundImageLayout = ImageLayout.None;
            txtpassword.CharacterCasing = CharacterCasing.Normal;
            txtpassword.Depth = 0;
            txtpassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.HideSelection = true;
            txtpassword.Hint = "Password";
            txtpassword.LeadingIcon = (Image)resources.GetObject("txtpassword.LeadingIcon");
            txtpassword.Location = new Point(61, 317);
            txtpassword.MaxLength = 32767;
            txtpassword.MouseState = MaterialSkin.MouseState.OUT;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '\0';
            txtpassword.PrefixSuffixText = null;
            txtpassword.ReadOnly = false;
            txtpassword.RightToLeft = RightToLeft.No;
            txtpassword.SelectedText = "";
            txtpassword.SelectionLength = 0;
            txtpassword.SelectionStart = 0;
            txtpassword.ShortcutsEnabled = true;
            txtpassword.Size = new Size(287, 36);
            txtpassword.TabIndex = 12;
            txtpassword.TabStop = false;
            txtpassword.TextAlign = HorizontalAlignment.Left;
            txtpassword.TrailingIcon = null;
            txtpassword.UseSystemPasswordChar = false;
            txtpassword.UseTallSize = false;
            txtpassword.Click += txtpassword_TextChanged;
            // 
            // txtusername
            // 
            txtusername.AnimateReadOnly = false;
            txtusername.BackgroundImageLayout = ImageLayout.None;
            txtusername.CharacterCasing = CharacterCasing.Normal;
            txtusername.Depth = 0;
            txtusername.Font = new Font("Segoe UI", 9F);
            txtusername.HideSelection = true;
            txtusername.Hint = "Username";
            txtusername.LeadingIcon = (Image)resources.GetObject("txtusername.LeadingIcon");
            txtusername.Location = new Point(61, 263);
            txtusername.MaxLength = 32767;
            txtusername.MouseState = MaterialSkin.MouseState.OUT;
            txtusername.Name = "txtusername";
            txtusername.PasswordChar = '\0';
            txtusername.PrefixSuffixText = null;
            txtusername.ReadOnly = false;
            txtusername.RightToLeft = RightToLeft.No;
            txtusername.SelectedText = "";
            txtusername.SelectionLength = 0;
            txtusername.SelectionStart = 0;
            txtusername.ShortcutsEnabled = true;
            txtusername.Size = new Size(287, 36);
            txtusername.TabIndex = 12;
            txtusername.TabStop = false;
            txtusername.TextAlign = HorizontalAlignment.Left;
            txtusername.TrailingIcon = null;
            txtusername.UseSystemPasswordChar = false;
            txtusername.UseTallSize = false;
            txtusername.Click += txtusername_TextChanged;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.BackColor = Color.SaddleBrown;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Segoe UI", 10F);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(164, 444);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(68, 36);
            materialButton1.TabIndex = 11;
            materialButton1.Text = "Log in";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = false;
            materialButton1.Click += btnsignin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(966, 602);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(972, 669);
            Controls.Add(panelcard);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cinnova-Login";
            Load += LoginForm_Load;
            Resize += LoginForm_Resize;
            panelcard.ResumeLayout(false);
            panelcard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelcard;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 txtusername;
        private MaterialSkin.Controls.MaterialTextBox2 txtpassword;
        private MaterialSkin.Controls.MaterialComboBox cmbrole;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Label label1;
    }
}
    
