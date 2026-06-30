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
        public bool AddUser(User newUser)
        {
            try
            {
                // 1. Open the connection using your DatabaseHelper
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    // 2. Write the SQL query to insert data
                    string query = "INSERT INTO Users (FullName, Username, Password, Role) VALUES (@FullName, @Username, @Password, @Role)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // 3. Bind the C# variables to the SQL parameters
                        cmd.Parameters.AddWithValue("@FullName", newUser.FullName);
                        cmd.Parameters.AddWithValue("@Username", newUser.Username);
                        cmd.Parameters.AddWithValue("@Password", newUser.Password);
                        cmd.Parameters.AddWithValue("@Role", newUser.Role);

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