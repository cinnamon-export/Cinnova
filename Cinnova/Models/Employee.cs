using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinnova.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string JobRole { get; set; }
        public decimal Salary { get; set; }

        public Employee() { }

        public Employee(int employeeId, string fullName, string jobRole, decimal salary)
        {
            EmployeeID = employeeId;
            FullName = fullName;
            JobRole = jobRole;
            Salary = salary;
        }
    }
}

