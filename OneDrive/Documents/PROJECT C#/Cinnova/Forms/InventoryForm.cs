using Cinnova.Models;
using Cinnova.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinnova.Forms
{
    public partial class InventoryForm : Form
    {
        private InventoryService service = new InventoryService();
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
        
            
            lblTitle.Text = "Raw Material Inventory";
            this.Text = "Raw Material Inventory";
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtItemID.Text.Trim(), out int itemId))
            {
                MessageBox.Show("Please enter a valid numeric Item ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validate and safely parse Quantity
            if (!int.TryParse(txtQuantityKg.Text.Trim(), out int quantity))
            {
                MessageBox.Show("Please enter a valid numeric Quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Safely parse Min Stock (default to 0 if empty)
            int minStock = 0;
            if (!string.IsNullOrWhiteSpace(txtMinStock.Text))
            {
                if (!int.TryParse(txtMinStock.Text.Trim(), out minStock))
                {
                    MessageBox.Show("Please enter a valid numeric Min Stock.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                Inventory item = new Inventory();
                item.ItemId = itemId;
                item.Quantity = quantity;
                item.MinStock = minStock;
                item.LastUpdated = DateTime.Now;

                // STATUS LOGIC
                if (item.Quantity == 0)
                {
                    item.Status = "Out of Stock";
                }
                else if (item.Quantity <= item.MinStock)
                {
                    item.Status = "Low Stock";
                }
                else
                {
                    item.Status = "In Stock";
                }

                service.Update(item);
                MessageBox.Show("Item Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh DataGridView and totals after updating
                LoadInventoryData();
                UpdateTotalStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void grpProductDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemID.Text))
            {
                MessageBox.Show("Please enter an Item ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtQuantityKg.Text))
            {
                MessageBox.Show("Please enter a Quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Inventory item = new Inventory();

                item.ItemId = int.Parse(txtItemID.Text.Trim());
                item.Quantity = int.Parse(txtQuantityKg.Text.Trim());
                item.LastUpdated = DateTime.Now;

                item.MinStock = string.IsNullOrWhiteSpace(txtMinStock.Text) ? 0 : int.Parse(txtMinStock.Text.Trim());

                // STATUS LOGIC
                if (item.Quantity == 0)
                {
                    item.Status = "Out of Stock";
                }
                else if (item.Quantity <= item.MinStock)
                {
                    item.Status = "Low Stock";
                }
                else
                {
                    item.Status = "In Stock";
                }
                service.Add(item);
                MessageBox.Show("Item Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadInventoryData(); // <-- Call your method that fetches data from 'service' and assigns it to dataGridView1.DataSource
                ClearInputFields();
                UpdateTotalStock();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("This Item ID already exists! Please use a unique ID.",
                                    "Duplicate Entry Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("A database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure Item ID, Quantity, and Min Stock are valid whole numbers.",
                                "Input Format Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
        private void LoadInventoryData()
        {
            // Fetch updated data from your service layer and bind it to the grid
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = service.GetAll();
            // Replace 'GetAll()' with your actual service method name

            if (dgvInventory.Columns["Category"] != null) dgvInventory.Columns["Category"].Visible = false;
            if (dgvInventory.Columns["Unit"] != null) dgvInventory.Columns["Unit"].Visible = false;
        }
        private void ClearInputFields()
        {
            txtItemID.Clear();
            txtQuantityKg.Clear();
            txtMinStock.Clear();
        }


        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void lblAlert_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txtQuantityKg.Text);
            int min = int.Parse(txtMinStock.Text);

            if (qty <= min)
            {

                lblAlert.Visible = true;
                lblAlert.Text = "⚠️ Low Stock Alert!";
            }
            else
            {
                lblAlert.Visible = false;
            }
        }
        private void UpdateTotalStock()
        {
            double totalStock = 0;

            //  Calculate the sum from  DataGridView rows
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.Cells["Quantity"].Value != null)
                {
                    if (double.TryParse(row.Cells["Quantity"].Value.ToString(), out double qty))
                    {
                        // Optional: If you support multiple units (e.g., grams), convert them here
                        // For now, assuming values are recorded in kg
                        totalStock += qty;
                    }
                }
            }

            //  Display the total in new TextBox
            txtTotalStock.Text = totalStock.ToString("0.##") + " kg";

            //  Check if the stock drops below the 20kg threshold
            if (totalStock < 20)
            {
                MessageBox.Show($"Warning: Critical Stock Level! Total stock is currently {totalStock} kg, which is below the 20 kg minimum threshold.",
                                "Low Stock Alert",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null || dgvInventory.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select an item from the table list to delete.",
                                "Selection Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this item?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //  Extract the unique ItemId from the active DataGridView row
                    // Note: Change "ItemId" to match your actual column grid layout property name if different
                    int selectedItemId = Convert.ToInt32(dgvInventory.CurrentRow.Cells["ItemId"].Value);

                    // Call your service to execute the DELETE query
                    service.Delete(selectedItemId); // Adjust this line if your method name differs 

                    MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Trigger the View Button code automatically to refresh the grid layout
                    btnView_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the record: " + ex.Message,
                                    "Database Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            LoadInventoryData();
            UpdateTotalStock();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
         
            txtItemID.Clear();
            txtQuantityKg.Clear();
            txtTotalStock.Clear();

            dtpDate.Value = DateTime.Now;
            txtItemID.Focus();

            
        }

        private void dgvInventory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string rowNumber = (e.RowIndex + 1).ToString();
            using (SolidBrush brush = new SolidBrush(dgvInventory.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(rowNumber, this.Font, brush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantityKg.Text))
            {
                txtTotalStock.Text = "0 kg";
                return;
            }
            if (int.TryParse(txtQuantityKg.Text, out int quantity))
            {
                // Assuming Total Stock is equal to quantity for this entry, 
                // or calculated from your database/existing records.
                int totalStock = quantity;
                int minStock = 20; 

                txtTotalStock.Text = $"{totalStock} kg";

                // 3. Only show the alert if the quantity is greater than 0 AND below the threshold
                if (totalStock > 0 && totalStock < minStock)
                {
                    MessageBox.Show($"Warning: Critical Stock Level! Total stock is currently {totalStock} kg, which is below the {minStock} kg minimum threshold.",
                                    "Low Stock Alert",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private void txtMinStock_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }
    


