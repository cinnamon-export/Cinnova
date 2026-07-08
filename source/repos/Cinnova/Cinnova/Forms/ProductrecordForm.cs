using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cinnova.Database;
using Microsoft.Data.SqlClient;

namespace Cinnova.Forms
{
    public partial class ProductrecordForm : Form
    {
        private int selectedProductionID = -1;
        public ProductrecordForm()
        {
            InitializeComponent();
            LoadProductRecords();
            LoadCategoryFilter();

        }
        private void LoadCategoryFilter()
        {
            cmbCategoryFilter.Items.Clear();

            cmbCategoryFilter.Items.Add("All");
            cmbCategoryFilter.Items.Add("Cinnamon Sticks");
            cmbCategoryFilter.Items.Add("Cinnamon Powder");
            cmbCategoryFilter.Items.Add("Cinnamon Oil");

            cmbCategoryFilter.SelectedIndex = 0;

            SearchProducts();
        }
        private void dgvProductionHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedProductionID = Convert.ToInt32(
                    dgvProductionHistory.Rows[e.RowIndex].Cells["ProductionID"].Value);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductionID == -1)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Production WHERE ProductionID = @ProductionID";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ProductionID", selectedProductionID);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Record deleted successfully.");

                selectedProductionID = -1;

                LoadProductRecords();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProductionHistory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record first.");
                return;
            }

            DataGridViewRow row = dgvProductionHistory.SelectedRows[0];

            UpdateProductForm updateForm = new UpdateProductForm(
                Convert.ToInt32(row.Cells["ProductionID"].Value),
                row.Cells["ProductCode"].Value.ToString() ?? "",
                row.Cells["ProductType"].Value.ToString() ?? "",
                Convert.ToDecimal(row.Cells["QuantityKg"].Value),
                row.Cells["Unit"].Value.ToString() ?? "",
                Convert.ToDecimal(row.Cells["PricePerUnit"].Value),
                Convert.ToDateTime(row.Cells["ProductionDate"].Value),
                Convert.ToDateTime(row.Cells["ExpireDate"].Value)
            );

            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                LoadProductRecords();
            }
        }

        private void LoadProductRecords()
        {
            string query = @"SELECT
                        ProductionID,
                        ProductCode,
                        ProductType,
                        QuantityKg,
                        Unit,
                        PricePerUnit,
                        ProductionDate,
                        ExpireDate
                     FROM Production
                     ORDER BY ProductionID DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            dgvProductionHistory.DataSource = dt;

            dgvProductionHistory.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProductionHistory.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProductionHistory.MultiSelect = false;

            dgvProductionHistory.ReadOnly = true;

            dgvProductionHistory.AllowUserToAddRows = false;

            dgvProductionHistory.Columns["ProductionID"]!.HeaderText = "ID";
            dgvProductionHistory.Columns["ProductCode"]!.HeaderText = "Code";
            dgvProductionHistory.Columns["ProductType"]!.HeaderText = "Category";
            dgvProductionHistory.Columns["QuantityKg"]!.HeaderText = "Quantity";
            dgvProductionHistory.Columns["Unit"]!.HeaderText = "Unit";
            dgvProductionHistory.Columns["PricePerUnit"]!.HeaderText = "Price";
            dgvProductionHistory.Columns["ProductionDate"]!.HeaderText = "Production Date";
            dgvProductionHistory.Columns["ExpireDate"]!.HeaderText = "Expire Date";
        }

        private void SearchProducts()
        {
            string query = @"SELECT
                        ProductionID,
                        ProductCode,
                        ProductType,
                        QuantityKg,
                        Unit,
                        PricePerUnit,
                        ProductionDate,
                        ExpireDate
                     FROM Production";

            if (cmbCategoryFilter.Text != "All")
            {
                query += " WHERE ProductType = @ProductType";
            }

            query += " ORDER BY ProductionID DESC";

            DataTable dt;

            if (cmbCategoryFilter.Text == "All")
            {
                dt = DatabaseHelper.ExecuteQuery(query);
            }
            else
            {
                dt = DatabaseHelper.ExecuteQuery(
                    query,
                    new SqlParameter("@ProductType", cmbCategoryFilter.Text));
            }

            dgvProductionHistory.DataSource = dt;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ProductManagementForm productForm = new ProductManagementForm();
            productForm.Show();
            this.Close();
        }
        private void ProductrecordForm_Load(object sender, EventArgs e)
        {
            // Constructor eke load karana nisa meka empty thiyenna puluwan.
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
    }
}
