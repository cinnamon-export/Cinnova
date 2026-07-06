using Cinnova.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MaterialSkin.Controls;

namespace Cinnova.Forms
{
    public partial class UserManagementForm : MaterialForm
    {
        public UserManagementForm()
        {
            InitializeComponent();
            //1.This guarantees the data loads before the window even opens!
            Cinnova.Services.UserService userService = new Cinnova.Services.UserService();
            dgvUsers.DataSource = userService.GetAllUsers();

            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (ValidateInput() == true)
            {
                // 1. Package the typed data into our User model
                Cinnova.Models.User newUser = new Cinnova.Models.User();
                newUser.EmployeeName = txtFullName.Text;
                newUser.Username = txtUsername.Text;
                newUser.Password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
                newUser.JobRole = cmbRole.Text;

                // 2. Send it to the database using our Service
                Cinnova.Services.UserService userService = new Cinnova.Services.UserService();
                bool isSuccess = userService.AddUser(newUser);

                // 3. Tell the user if it worked!
                if (isSuccess)
                {
                    MessageBox.Show("User registered successfully!");

                    // Refresh the grid to show the new user immediately
                    dgvUsers.DataSource = userService.GetAllUsers();

                    // Clean up the UI by emptying the text boxes for the next entry
                    txtFullName.SelectedIndex = -1;
                    txtUsername.Clear();
                    txtPassword.Clear();
                    cmbRole.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("Failed to register user. Check database connection.");
                }
            }
        }



        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if there is actually a row active
            if (dgvUsers.CurrentRow != null)
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this user?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Use CurrentRow instead of SelectedRows[0]
                    int selectedUserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);

                    Cinnova.Services.UserService userService = new Cinnova.Services.UserService();
                    if (userService.DeleteUser(selectedUserId))
                    {
                        MessageBox.Show("User deleted successfully!");
                        dgvUsers.DataSource = userService.GetAllUsers();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user in the table to delete.");
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Make sure the user clicked an actual row, not the header
            if (e.RowIndex >= 0 && dgvUsers.CurrentRow != null)
            {
                // Copy the data from the selected row into the text boxes
                txtFullName.Text = dgvUsers.CurrentRow.Cells["EmployeeName"].Value?.ToString() ?? string.Empty;
                txtUsername.Text = dgvUsers.CurrentRow.Cells["Username"].Value?.ToString() ?? string.Empty;
                txtPassword.Clear();
                cmbRole.Text = dgvUsers.CurrentRow.Cells["JobRole"].Value?.ToString() ?? string.Empty;

            }
        }

        private bool ValidateInput()
        {
            // Check if any of the essential boxes are empty or just contain spaces
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                // Warn the user
                MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validation failed
            }

            return true; // Validation passed!
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                // 1. Get the ID of the user we are modifying
                int selectedUserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);

                // 2. Package the modified details from the text boxes
                Cinnova.Models.User updatedUser = new Cinnova.Models.User();
                updatedUser.UserID = selectedUserId;
                updatedUser.EmployeeName = txtFullName.Text;
                updatedUser.Username = txtUsername.Text;
                updatedUser.Password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
                updatedUser.JobRole = cmbRole.Text;

                // 3. Send it to the database
                Cinnova.Services.UserService userService = new Cinnova.Services.UserService();
                if (userService.UpdateUser(updatedUser))
                {
                    MessageBox.Show("User updated successfully!");

                    // 4. Refresh the grid and clear the boxes
                    dgvUsers.DataSource = userService.GetAllUsers();
                    txtFullName.SelectedIndex = -1;
                    txtUsername.Clear();
                    txtPassword.Clear();
                    cmbRole.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void btnTestLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // 1. Basic validation to make sure fields aren't empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both a username and password to test.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Instantiate your service layer
                UserService userService = new UserService();

                // 3. Call your new BCrypt authentication engine
                bool isLoginSuccessful = userService.AuthenticateUser(username, password);

                // 4. Show the result
                if (isLoginSuccessful)
                {
                    MessageBox.Show("Login Successful! BCrypt successfully verified the password matching the database hash.", "Authentication Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login Failed! Incorrect username or password. BCrypt rejected the match.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during testing: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {

            
            // 1. Instantiate your service
            UserService userService = new UserService();

            // 2. Feed whatever is typed into the search box directly to your backend engine
            dgvUsers.DataSource = userService.SearchUsers(txtSearch.Text);



            
        }
        

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            // Force the search box to listen to your text changed method
            txtSearch.TextChanged += txtSearch_TextChanged;


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sidebarControl1_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
