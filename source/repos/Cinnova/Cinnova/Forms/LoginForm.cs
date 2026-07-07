using Cinnova.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Cinnova.Forms
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private const int EM_SETMARGINS = 0xD3;
        private const int EC_LEFTMARGIN = 0x1;



        public LoginForm()
        {
            InitializeComponent();
            // Kill the Material action bar and control box
            this.FormStyle = FormStyles.ActionBar_None;
            pictureBox2.Parent = pictureBox1;
            this.ControlBox = false;
            this.Text = "";

            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Resize += new System.EventHandler(this.LoginForm_Resize);

            // Initialize MaterialSkinManager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Set your brand colors for Cinnova
            materialSkinManager.ColorScheme = new ColorScheme(

                Primary.Brown800,  
                Primary.Brown900,  
                Primary.Brown500,  
                Accent.Orange700,  
                TextShade.WHITE    
            );





        }

        private void picbackground_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblleaf_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblsubtitle_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object? sender, EventArgs e)
        {
            // Force the logo into the card
            pictureBox2.Parent = panelcard;
            pictureBox2.BackColor = Color.White;

            //  Mathematically center the logo horizontally!
            int logoX = (panelcard.Width - pictureBox2.Width) / 2;
            pictureBox2.Location = new Point(logoX, 15);

            //  Force the Font to be HUGE and Brown (Overrides the framework)
            label1.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;

            //  Center the "Welcome Back" text under the logo
            int labelX = (panelcard.Width - label1.Width) / 2;
            label1.Location = new Point(labelX, pictureBox2.Bottom + 15);

        }
        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = RoundedRect(panel.ClientRectangle, radius);
            panel.Region = new Region(path);
        }
        private void RoundButton(Button btn, int radius)
        {
            GraphicsPath path = RoundedRect(btn.ClientRectangle, radius);
            btn.Region = new Region(path);

        }
        private GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text;

            // Query ONLY by username using your variable
            string query = $"SELECT * FROM Users WHERE Username = '{username}'";

            try
            {
                var result = DatabaseHelper.ExecuteQuery(query);

                if (result.Rows.Count > 0)
                {
                    //  Get the scrambled hash from the database
                    string? storedHash = result.Rows[0]["Password"].ToString();

                    // Get the role from the database
                    string? dbrole = result.Rows[0]["JobRole"].ToString();

                    //  Let BCrypt compare the typed password against the hidden hash
                    if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                    {
                        // IT MATCHES! Check authorization...
                        if (dbrole == "Owner" || dbrole == "Manager" || dbrole == "Staff")
                        {
                            MessageBox.Show($"Login OK! Welcome {dbrole}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            UserManagementForm adminForm = new UserManagementForm();
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show($"Access Denied. Role '{dbrole}' is not authorized to access this system.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtpassword.Clear();
                            txtpassword.Focus();
                        }
                    }
                    else
                    {
                        // Password was wrong
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpassword.Clear();
                        txtpassword.Focus();
                    }
                }
                else
                {
                    // Username wasn't found in the database at all
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Clear();
                    txtpassword.Focus();
                }
            }
            catch (Exception ex)
            {
                // Safety net for database connection crashes
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }











        private void panelcard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Resize(object? sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void cmbrolde_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {
        }

        private void lbldesc_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }





}
