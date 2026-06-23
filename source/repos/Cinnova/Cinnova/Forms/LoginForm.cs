using Cinnova.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cinnova.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtusername.ForeColor = Color.FromArgb(186, 117, 23);
            txtusername.Text = "Enter username";

            txtpassword.ForeColor = Color.FromArgb(186, 117, 23);
            txtpassword.Text = "Enter Password";
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "Enter username")
            {
                txtusername.Text = "";
                txtusername.ForeColor = Color.FromArgb(65, 36, 2);
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Enter username";
                txtusername.ForeColor = Color.FromArgb(186, 117, 23);
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Enter Password")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.FromArgb(65, 36, 2);
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Enter Password";
                txtpassword.ForeColor = Color.FromArgb(186, 117, 23);
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (username == "" || username == "Enter Username") 
            {
                MessageBox.Show("Please enter your username.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password == "" || password == "Enter Password") 
            {
                MessageBox.Show("Please enter your password.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
                DataTable result = DatabaseHelper.ExecuteQuery(query,
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password));
                if (result.Rows.Count > 0)
                {
                    string role = result.Rows[0]["Role"].ToString();

                    MessageBox.Show("Welcome," + username + "\nRole" + role,
                        "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   // DashboardForm dashboard = new DashboardForm(username, role);
                    //dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
