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

namespace Cinnova.Forms
{
    public partial class LoginForm : Form
    {

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private const int EM_SETMARGINS = 0xD3;
        private const int EC_LEFTMARGIN = 0x1;

        private void SetTextBoxLeftPadding(TextBox tb, int leftPadding)
        {
            SendMessage(tb.Handle, EM_SETMARGINS, EC_LEFTMARGIN, leftPadding);
        }
        public LoginForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Resize += new System.EventHandler(this.LoginForm_Resize);
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            



            RoundPanel(panelcard, 18);
            RoundButton(btnsignin, 10);

            cmbrole.Items.Clear();
            cmbrole.Items.Add("Owner");
            cmbrole.Items.Add("Manager");
            cmbrole.Items.Add("Staff");
            cmbrole.SelectedIndex = 0;

            txtpassword.UseSystemPasswordChar = true;
            SetTextBoxLeftPadding(txtusername, 28);
            SetTextBoxLeftPadding(txtusername, 28);

            txtpassword.GotFocus += (s, ev) => SetTextBoxLeftPadding(txtpassword, 28);
            txtusername.GotFocus += (s, ev) => SetTextBoxLeftPadding(txtusername, 28);
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
            string password = txtpassword.Text.Trim();
            MessageBox.Show($"Username: '{username}'\nPassword: '{password}'",
        "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string query = $@"SELECT * FROM Users 
                      WHERE Username = '{username}' 
                      AND Password = '{password}'";




            try
            {
                var result = DatabaseHelper.ExecuteQuery(query);

                MessageBox.Show($"Rows found: {result.Rows.Count}",
                    "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result.Rows.Count > 0)
                {
                    string dbrole = result.Rows[0]["Role"].ToString();
                    MessageBox.Show($"Login OK! Role: {dbrole}", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //DashboardForm dashboard = new DashboardForm(username, dbrole);
                    // dashboard.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.Please try again.,",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Clear();
                    txtpassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelcard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            
        }
        
        
    }
}
