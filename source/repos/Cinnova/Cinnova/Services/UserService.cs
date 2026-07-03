using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Cinnova.Models;
using Cinnova.Database;

namespace Cinnova.Services
{
    public class UserService
    {

        public List<User> SearchUsers(string searchTerm)
        {
            List<User> filteredUsers = new List<User>();

            using (Microsoft.Data.SqlClient.SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // The LIKE keyword combined with % wildcards allows us to find partial matches
                string query = "SELECT UserID, FullName, Username, Role FROM Users WHERE FullName LIKE @Search OR Username LIKE @Search";

                using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    // Adding "%" before and after means "find this text anywhere inside the column"
                    cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");

                    using (Microsoft.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                FullName = reader["FullName"].ToString() ?? string.Empty,
                                Username = reader["Username"].ToString() ?? string.Empty,

                                // We intentionally leave Password blank here. We don't want to display hashes in the search grid!
                                Password = string.Empty,

                                Role = reader["Role"].ToString() ?? string.Empty
                            };
                            filteredUsers.Add(user);
                        }
                    }
                }
            }

            return filteredUsers;
        }
        public bool AddUser(User newUser)
        {
            try
            {
                // 1. Open the connection using your DatabaseHelper
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    // 2. Write the SQL query to insert data
                    // 1. Updated SQL query to include EmployeeID
                    string query = "INSERT INTO Users (FullName, Username, Password, Role, EmployeeID) VALUES (@FullName, @Username, @Password, @Role, @EmployeeID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Existing parameters
                        cmd.Parameters.AddWithValue("@FullName", newUser.FullName);
                        cmd.Parameters.AddWithValue("@Username", newUser.Username);
                        cmd.Parameters.AddWithValue("@Password", newUser.Password);
                        cmd.Parameters.AddWithValue("@Role", newUser.Role);

                        // 2. The New Bridge: Safely add the EmployeeID
                        if (newUser.EmployeeID.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@EmployeeID", newUser.EmployeeID.Value);
                        }
                        else
                        {
                            // DBNull.Value tells SQL Server to safely leave this field blank if no employee is selected
                            cmd.Parameters.AddWithValue("@EmployeeID", DBNull.Value);
                        }

                        // 4. Execute the command
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        

                        // If rowsAffected is greater than 0, the user was saved successfully
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // If anything goes wrong, this catches the error so the app doesn't crash
                System.Windows.Forms.MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        }


        public bool AuthenticateUser(string username, string typedPassword)
        {
            using (Microsoft.Data.SqlClient.SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // We only want to look up the secure hash for the specific username
                string query = "SELECT Password FROM Users WHERE Username = @Username";

                using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    // ExecuteScalar is perfect here because we only want ONE specific piece of data (the hash)
                    object result = cmd.ExecuteScalar();

                    // If result is NOT null, it means the username exists in the database
                    if (result != null)
                    {
                        string storedHash = result?.ToString() ?? string.Empty;

                        // The Magic Step: BCrypt safely compares the typed password against the scrambled hash
                        bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(typedPassword, storedHash);

                        return isPasswordCorrect; // Will return true if they match, false if they don't
                    }
                }
            }

            // If we get here, it means the username didn't exist at all
            return false;
        }
        public List<User> GetAllUsers()
        {
            List<User> userList = new List<User>();
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT UserID, FullName, Username, Password, Role FROM Users";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // This loop reads every row from the database, one by one
                            while (reader.Read())
                            {
                                User u = new User();
                                u.UserID = Convert.ToInt32(reader["UserID"]);
                                u.FullName = reader["FullName"]?.ToString() ?? string.Empty;
                                u.Username = reader["Username"]?.ToString() ?? string.Empty;
                                u.Password = reader["Password"]?.ToString() ?? string.Empty;
                                u.Role = reader["Role"]?.ToString() ?? string.Empty;
                                // Add this user to our list
                                userList.Add(u);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error loading users: " + ex.Message);
            }
            return userList;
        }

        public bool DeleteUser(int userId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        public bool UpdateUser(Cinnova.Models.User user)
        {
            // Look here: No more "System.Data.SqlClient." forcing!
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Users SET FullName = @FullName, Username = @Username, Password = @Password, Role = @Role WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.Parameters.AddWithValue("@UserID", user.UserID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}