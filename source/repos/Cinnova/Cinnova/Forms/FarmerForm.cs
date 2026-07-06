using Cinnova.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinnova.Forms
{
    public partial class FarmerForm : Form
    {

        public FarmerForm()
        {
            InitializeComponent();

            LoadFarmers();
            LoadFarmerCombo();
            LoadPurchases();
            StyleFarmerGrid();
            StylePurchaseGrid();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblPurchaseDetails_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }




        private void btnSavePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO Purchases (FarmerID, QuantityKg, PricePerKg, TotalCost, PurchaseDate) VALUES (@farmerID, @qty, @price, @total, @date)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@farmerID", 1);
                    cmd.Parameters.AddWithValue("@qty", Convert.ToDecimal(txtQuantityKg.Text));
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPriceKg.Text));
                    cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtCost.Text));
                    cmd.Parameters.AddWithValue("@date", dateTimePicker2.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Purchase saved successfully!");
                    LoadPurchases();
                    ClearPurchaseFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }











        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double quantity = Convert.ToDouble(txtQuantityKg.Text);
            double price = Convert.ToDouble(txtPriceKg.Text);

            double total = quantity * price;

            txtCost.Text = total.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO Farmers (FullName, ContactNumber, Location, DateAdded) VALUES (@name, @contact, @location, @date)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@contact", textBox2.Text);
                    cmd.Parameters.AddWithValue("@location", textBox3.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Farmer added successfully!");
                    LoadFarmers();
                    LoadFarmerCombo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFarmers.SelectedRows.Count > 0)
                {
                    int farmerId = Convert.ToInt32(dgvFarmers.SelectedRows[0].Cells["FarmerID"].Value);

                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        string query = "DELETE FROM Farmers WHERE FarmerID = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@id", farmerId);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Farmer deleted successfully!");

                        LoadFarmers();
                        LoadFarmerCombo();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a farmer row first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadFarmers()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"
SELECT
    ROW_NUMBER() OVER (ORDER BY FarmerID) AS No,
    FarmerID,
    FullName,
    ContactNumber,
    Location,
    DateAdded
FROM Farmers";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvFarmers.DataSource = dt;
                dgvFarmers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvFarmers.ScrollBars = ScrollBars.Both;

                if (dgvFarmers.Columns.Contains("No"))
                    dgvFarmers.Columns["No"].HeaderText = "No";

                if (dgvFarmers.Columns.Contains("FarmerID"))
                    dgvFarmers.Columns["FarmerID"].HeaderText = "Farmer ID";

                if (dgvFarmers.Columns.Contains("FullName"))
                    dgvFarmers.Columns["FullName"].HeaderText = "Full Name";

                if (dgvFarmers.Columns.Contains("ContactNumber"))
                    dgvFarmers.Columns["ContactNumber"].HeaderText = "Tel.";

                if (dgvFarmers.Columns.Contains("Location"))
                    dgvFarmers.Columns["Location"].HeaderText = "Area";

                if (dgvFarmers.Columns.Contains("DateAdded"))
                    dgvFarmers.Columns["DateAdded"].HeaderText = "Date";
                lblTotalNumber.Text = dt.Rows.Count.ToString();
                dgvFarmers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 38, 16);
                dgvFarmers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvFarmers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 235, 225);
                dgvFarmers.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgvFarmers.ClearSelection();
                dgvFarmers.CurrentCell = null;
            }
        }
        private void LoadFarmerCombo()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT FarmerID, FullName FROM Farmers";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                combofarmer.DataSource = dt;
                combofarmer.DisplayMember = "FullName";
                combofarmer.ValueMember = "FarmerID";
            }
        }

        private void combofarmer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadPurchases()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Purchases";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvPurchases.DataSource = dt;
                UpdatePurchaseCount();

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {


        }
        private void StyleFarmerGrid()
        {
            dgvFarmers.EnableHeadersVisualStyles = false;

            dgvFarmers.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(76, 38, 16);

            dgvFarmers.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvFarmers.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dgvFarmers.DefaultCellStyle.Font =
                new Font("Segoe UI", 9);

            dgvFarmers.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(245, 232, 218);

            dgvFarmers.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvFarmers.RowHeadersVisible = false;

            dgvFarmers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
        private void UpdatePurchaseCount()
        {
            lblTotalPurchases.Text =
                dgvPurchases.Rows.Count.ToString();
        }

        private void btnLogoutFarmer_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
        private void ClearPurchaseFields()
        {
            txtQuantityKg.Clear();
            txtPriceKg.Clear();
            txtCost.Clear();

            combofarmer.SelectedIndex = -1;
        }
        private void StylePurchaseGrid()
        {
            dgvPurchases.EnableHeadersVisualStyles = false;

            dgvPurchases.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(76, 38, 16);

            dgvPurchases.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvPurchases.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dgvPurchases.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvPurchases.RowHeadersVisible = false;
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pnlBanner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pnlTotalFarmers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalNumber_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFarmer_Click(object sender, EventArgs e)
        {
            if (dgvFarmers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a farmer to delete.");
                return;
            }

            int farmerId = Convert.ToInt32(dgvFarmers.SelectedRows[0].Cells["FarmerID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this farmer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    string query = "DELETE FROM Farmers WHERE FarmerID = @FarmerID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FarmerID", farmerId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Farmer deleted successfully.");

                LoadFarmers();
            }
        }

        private void dgvFarmers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_3(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dgvPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFarmer_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FarmerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintFarmers_Click(object sender, EventArgs e)
        {
            printDocumentFarmers.Print();
        }

        private void printDocumentFarmers_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dgvFarmers.Width, dgvFarmers.Height);
            dgvFarmers.DrawToBitmap(bmp, new Rectangle(0, 0, dgvFarmers.Width, dgvFarmers.Height));
            e.Graphics.DrawImage(bmp, 50, 100);
        }
    }
}


    
