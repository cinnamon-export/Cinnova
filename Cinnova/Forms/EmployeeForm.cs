using Cinnova.Models;
using Cinnova.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinnova.Serveices;

namespace Cinnova.Forms
{
    public partial class EmployeeForm : Form
    {
        private Employeeservice service = new Employeeservice();
        public EmployeeForm()
        {
            InitializeComponent();
        }
    

        private void LoadEmployees()
        {
            dgvemployee.DataSource = null;
            dgvemployee.DataSource = service.GetAllEmployees();
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void labeltext_Click(object sender, EventArgs e)
        {

        }

        private void txtemployeename_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            emp.FullName = txtemployeename.Text;
            emp.JobRole = txtjob.Text;
            emp.Salary = decimal.Parse(txtsalary.Text);

            bool result = service.AddEmployee(emp);

            if (result)
            {
                MessageBox.Show("Employee added successfully!");

                LoadEmployees();

                txtemployeename.Clear();
                txtjob.Clear();
                txtsalary.Clear();

                txtemployeename.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add employee.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                Employee emp = new Employee();
                emp.EmployeeID = int.Parse(this.Tag.ToString());
                emp.FullName = txtemployeename.Text;
                emp.JobRole = txtjob.Text;
                emp.Salary = decimal.Parse(txtsalary.Text);

                if (service.UpdateEmployee(emp))
                {
                    MessageBox.Show("Employee updated!");
                    LoadEmployees();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                int id = int.Parse(this.Tag.ToString());
                if (service.DeleteEmployee(id))
                {
                    MessageBox.Show("Employee deleted!");
                    LoadEmployees();
                    btnclear_Click(sender, e);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtemployeename.Clear();
            txtjob.Clear();
            txtsalary.Clear();

            txtemployeename.Focus();
        }

        private void dgvemployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvemployee.Rows[e.RowIndex];

                txtemployeename.Text = row.Cells["FullName"].Value.ToString();
                txtjob.Text = row.Cells["JobRole"].Value.ToString();
                txtsalary.Text = row.Cells["Salary"].Value.ToString();

                this.Tag = row.Cells["EmployeeID"].Value.ToString();
            }
        }
    }
}
