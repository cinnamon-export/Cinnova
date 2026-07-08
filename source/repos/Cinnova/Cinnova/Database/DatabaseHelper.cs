using System;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Cinnova.Database
{
    public class DatabaseHelper
    {
       // private static string connectionString =
   // "Server=Kemeesha\\SQLEXPRESS01;Database=CinnovaDB;Integrated Security=True;Encrypt=False";

         private static string connectionString =
         "Server=localhost\\SQLEXPRESS;Database=CinnovaDB;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Query Error: " + ex.Message);
            }
            return dt;
        }
        public static bool ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        
   

    }
    }
}