using Cinnova.Database;
using Cinnova.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinnova.Serveices
{
    public class Employeeservice
    {
        
            private readonly DatabaseHelper _dbHelper;

            public Employeeservice()
            {
                _dbHelper = new DatabaseHelper();
            }

            public List<Employee> GetAllEmployees()
            {
                List<Employee> employees = new List<Employee>();
                string query = "SELECT EmployeeID, FullName, JobRole, Salary FROM Employees";

                DataTable table = _dbHelper.ExecuteQuery(query);

                foreach (DataRow row in table.Rows)
                {
                    employees.Add(new Employee
                    {
                        EmployeeID = Convert.ToInt32(row["EmployeeID"]),
                        FullName = row["FullName"].ToString(),
                        JobRole = row["JobRole"].ToString(),
                        Salary = Convert.ToDecimal(row["Salary"])
                    });
                }
                return employees;
            }

            public bool AddEmployee(Employee emp)
            {
                string query = "INSERT INTO Employees (FullName, JobRole, Salary) VALUES (@FullName, @JobRole, @Salary)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@FullName", emp.FullName),
                new SqlParameter("@JobRole", emp.JobRole),
                new SqlParameter("@Salary", emp.Salary)
                };
                int rowsAffected = _dbHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }

            public bool UpdateEmployee(Employee emp)
            {
                string query = "UPDATE Employees SET FullName = @FullName, JobRole = @JobRole, Salary = @Salary WHERE EmployeeID = @EmployeeID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@FullName", emp.FullName),
                new SqlParameter("@JobRole", emp.JobRole),
                new SqlParameter("@Salary", emp.Salary),
                new SqlParameter("@EmployeeID", emp.EmployeeID)
                };
                int rowsAffected = _dbHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            public bool DeleteEmployee(int employeeId)
            {
                string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@EmployeeID", employeeId)
                };

                int rowsAffected = _dbHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
        }
    }





