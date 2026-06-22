namespace Cinnova.Forms
{
    partial class Dashboardform
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
            pnltopbar = new Panel();
            lblappname = new Label();
            lblleaf = new Label();
            lblwelcome = new Label();
            btnlogout = new Button();
            pnlsidebar = new Panel();
            dtndashboard = new Button();
            pnltopbar.SuspendLayout();
            pnlsidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnltopbar
            // 
            pnltopbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnltopbar.BackColor = Color.FromArgb(65, 36, 2);
            pnltopbar.Controls.Add(btnlogout);
            pnltopbar.Controls.Add(lblwelcome);
            pnltopbar.Controls.Add(lblleaf);
            pnltopbar.Controls.Add(lblappname);
            pnltopbar.Location = new Point(0, 0);
            pnltopbar.Name = "pnltopbar";
            pnltopbar.Size = new Size(900, 50);
            pnltopbar.TabIndex = 0;
            // 
            // lblappname
            // 
            lblappname.AutoSize = true;
            lblappname.BackColor = Color.FromArgb(65, 36, 2);
            lblappname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblappname.ForeColor = Color.FromArgb(250, 238, 218);
            lblappname.Location = new Point(32, 15);
            lblappname.Name = "lblappname";
            lblappname.Size = new Size(101, 31);
            lblappname.TabIndex = 1;
            lblappname.Text = "Cinnova";
            // 
            // lblleaf
            // 
            lblleaf.AutoSize = true;
            lblleaf.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblleaf.ForeColor = Color.Chartreuse;
            lblleaf.Location = new Point(1, 19);
            lblleaf.Name = "lblleaf";
            lblleaf.Size = new Size(37, 25);
            lblleaf.TabIndex = 2;
            lblleaf.Text = "🌿";
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.ForeColor = Color.FromArgb(250, 199, 117);
            lblwelcome.Location = new Point(620, 16);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(122, 20);
            lblwelcome.TabIndex = 3;
            lblwelcome.Text = "Welcome, Admin";
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(133, 79, 11);
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.ForeColor = Color.FromArgb(250, 238, 218);
            btnlogout.Location = new Point(795, 10);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(80, 30);
            btnlogout.TabIndex = 1;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // pnlsidebar
            // 
            pnlsidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlsidebar.BackColor = Color.FromArgb(250, 238, 218);
            pnlsidebar.Controls.Add(dtndashboard);
            pnlsidebar.Location = new Point(0, 50);
            pnlsidebar.Name = "pnlsidebar";
            pnlsidebar.Size = new Size(160, 550);
            pnlsidebar.TabIndex = 1;
            // 
            // dtndashboard
            // 
            dtndashboard.FlatStyle = FlatStyle.Flat;
            dtndashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtndashboard.ForeColor = Color.FromArgb(133, 79, 11);
            dtndashboard.Location = new Point(0, 10);
            dtndashboard.Name = "dtndashboard";
            dtndashboard.Size = new Size(160, 42);
            dtndashboard.TabIndex = 0;
            dtndashboard.Text = "Dashboard";
            dtndashboard.TextAlign = ContentAlignment.MiddleLeft;
            dtndashboard.UseVisualStyleBackColor = true;
            // 
            // Dashboardform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 240);
            ClientSize = new Size(882, 553);
            Controls.Add(pnlsidebar);
            Controls.Add(pnltopbar);
            Name = "Dashboardform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cinnova - Dashboardform";
            Load += Dashboardform_Load;
            pnltopbar.ResumeLayout(false);
            pnltopbar.PerformLayout();
            pnlsidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnltopbar;
        private Label lblappname;
        private Label lblleaf;
        private Button btnlogout;
        private Label lblwelcome;
        private Panel pnlsidebar;
        private Button dtndashboard;
    }
}