using System;
using System.Collections.Generic;
using System.Text;

namespace Cinnova.Models
{
    public class User
    {
        public int UserID { get; set; }
        // The '?' makes it a nullable integer, perfect for database foreign keys
        public int? EmployeeID { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string JobRole { get; set; } = string.Empty;
    }
}
