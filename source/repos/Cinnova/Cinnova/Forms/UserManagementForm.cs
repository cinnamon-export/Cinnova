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
    public partial class UserManagementForm : Form
    {
        // This is our safety lock to prevent events from firing automatically
        private bool isLoadingData = false;

        public UserManagementForm()
        {
            InitializeComponent();
            //To load data even before windows open.
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
                // Package the typed data into our User model
                Cinnova.Models.User newUser = new Cinnova.Models.User();
                newUser.EmployeeName = txtFullName.Text;
                newUser.Username = txtUsername.Text;
                newUser.Password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
                newUser.JobRole = cmbRole.Text;

                // Send it to the database using our Service
                Cinnova.Services.UserService userService = new Cinnova.Services.UserService();
                bool isSuccess = userService.AddUser(newUser);

                // Tell the user if it worked
                if (isSuccess)
                {
                    MessageBox.Show("User registered successfully!");

                    // Refresh data grid to show the new user immediately
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
            if (isLoadingData) return;
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



        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            if (isLoadingData) return;

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

        private void cmbRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (isLoadingData) return;
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure we actually clicked a valid row (not the header at the top)
            if (e.RowIndex >= 0)
            {
                //  Grab the specific row that was clicked
                DataGridViewRow row = this.dgvUsers.Rows[e.RowIndex];

                // Pull the data directly from the grid cells and put it into your form controls.


                txtFullName.Text = row.Cells["EmployeeName"].Value?.ToString();
                cmbRole.Text = row.Cells["JobRole"].Value?.ToString();
                txtUsername.Text = row.Cells["Username"].Value?.ToString();

                // Keep the password blank for security!
                txtPassword.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

