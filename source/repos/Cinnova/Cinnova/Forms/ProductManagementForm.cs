using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cinnova.Database;

namespace Cinnova.Forms
{
    public partial class ProductManagementForm : Form
    {
        public ProductManagementForm()
        {
            InitializeComponent();
            LoadCategories();

            dtpProductionDate.Value = DateTime.Today;
            dtpExpireDate.Value = DateTime.Today.AddMonths(12);

            cmbUnit.SelectedIndex = -1;
        }
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("Cinnamon Sticks");
            cmbCategory.Items.Add("Cinnamon Powder");
            cmbCategory.Items.Add("Cinnamon Oil");
        }
        private string GenerateProductCode(string productType)
        {
            string prefix = "";

            switch (productType)
            {
                case "Cinnamon Sticks":
                    prefix = "S";
                    break;

                case "Cinnamon Powder":
                    prefix = "P";
                    break;

                case "Cinnamon Oil":
                    prefix = "O";
                    break;
            }

            string query = @"SELECT TOP 1 ProductCode
                     FROM Production
                     WHERE ProductType = @ProductType
                     ORDER BY ProductionID DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ProductType", productType));

            if (dt.Rows.Count == 0)
                return prefix + "_001";

            string lastCode = dt.Rows[0]["ProductCode"]?.ToString() ?? "";

            int number = 0;

            if (lastCode.Contains("_"))
            {
                int.TryParse(lastCode.Split('_')[1], out number);
            }

            number++;

            return prefix + "_" + number.ToString("000");
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex != -1)
            {
                txtProductCode.Text = GenerateProductCode(cmbCategory.Text);
            }
        }
        private bool ValidateInputs()
        {
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product category.");
                cmbCategory.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter quantity.");
                txtQuantity.Focus();
                return false;
            }

            if (!decimal.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Quantity must be a valid number.");
                txtQuantity.Focus();
                return false;
            }

            if (cmbUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a unit.");
                cmbUnit.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                MessageBox.Show("Please enter unit price.");
                txtUnitPrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out _))
            {
                MessageBox.Show("Unit price must be a valid number.");
                txtUnitPrice.Focus();
                return false;
            }

            if (dtpExpireDate.Value <= dtpProductionDate.Value)
            {
                MessageBox.Show("Expire date must be greater than Production Date.");
                dtpExpireDate.Focus();
                return false;
            }

            return true;
        }
        private void ClearInputs()
        {
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtProductCode.Clear();

            cmbCategory.SelectedIndex = -1;
            cmbUnit.SelectedIndex = -1;

            dtpProductionDate.Value = DateTime.Today;
            dtpExpireDate.Value = DateTime.Today.AddMonths(12);
        }
        private bool SaveProduct()
        {
            try
            {
                string query = @"INSERT INTO Production
                        (ProductCode,
                         ProductType,
                         QuantityKg,
                         Unit,
                         PricePerUnit,
                         ProductionDate,
                         ExpireDate)

                         VALUES

                        (@ProductCode,
                         @ProductType,
                         @QuantityKg,
                         @Unit,
                         @PricePerUnit,
                         @ProductionDate,
                         @ExpireDate)";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text);
                    cmd.Parameters.AddWithValue("@ProductType", cmbCategory.Text);
                    cmd.Parameters.AddWithValue("@QuantityKg", Convert.ToDecimal(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@Unit", cmbUnit.Text);
                    cmd.Parameters.AddWithValue("@PricePerUnit", Convert.ToDecimal(txtUnitPrice.Text));
                    cmd.Parameters.AddWithValue("@ProductionDate", dtpProductionDate.Value.Date);
                    cmd.Parameters.AddWithValue("@ExpireDate", dtpExpireDate.Value.Date);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Product saved successfully!");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void lblUnitPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            ProductrecordForm recordForm = new ProductrecordForm();
            recordForm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (SaveProduct())
            {
                MessageBox.Show("Product Saved Successfully.");

                ClearInputs();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();

        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            pnlNotification.BringToFront();

            if (!pnlNotification.Visible)
            {
                LoadNotifications();
            }

            pnlNotification.Visible = !pnlNotification.Visible;


        }

        private void lblNotificationList_Click(object sender, EventArgs e)
        {
            // Empty method
        }

        private void LoadNotifications()
        {
            string query = @"
    SELECT ProductCode, ProductType, ExpireDate
    FROM Production
    WHERE ExpireDate <= DATEADD(DAY, 7, GETDATE())
    ORDER BY ExpireDate ASC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            lblNotificationList.Text = "";

            if (dt.Rows.Count == 0)
            {
                lblNotificationList.Text = "✅ No notifications.";
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                string code = row["ProductCode"].ToString();
                string type = row["ProductType"].ToString();
                DateTime expire = Convert.ToDateTime(row["ExpireDate"]);

                string status;

                if (expire.Date < DateTime.Today)
                    status = "❌ Already Expired";
                else if (expire.Date == DateTime.Today)
                    status = "⚠️ Expires Today";
                else
                {
                    int days = (expire.Date - DateTime.Today).Days;
                    status = $"⚠️ Expires in {days} day(s)";
                }

                lblNotificationList.Text +=
                    $"{code} - {type}\r\n{status}\r\n\r\n";
            }
        }
        

    }
}
