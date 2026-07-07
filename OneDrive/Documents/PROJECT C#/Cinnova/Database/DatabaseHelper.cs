using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Cinnova.Database
{
    public class DatabaseHelper
    {
        public static SqlConnection GetConnection() 
        {
            return new SqlConnection(
                  ConfigurationManager.ConnectionStrings
                  ["CinnovaDB"].ConnectionString
                );
        }

    }
}
