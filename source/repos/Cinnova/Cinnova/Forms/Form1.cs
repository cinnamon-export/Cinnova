using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pro
{
    public partial class Form1 : Form
    {
        // CHANGE THIS TO YOUR SQL SERVER
        private string connectionString =
            @"Server=.\SQLEXPRESS;Database=CinnamonPOS;Trusted_Connection=True;TrustServerCertificate=True;";

        private SqlConnection con;

        public Form1()
        {
            InitializeComponent();

            con = new SqlConnection(connectionString);

            this.Load += Form1_Load;

            txtQty.TextChanged += CalculateTotal;
            txtPrice.TextChanged += CalculateTotal;

            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnRefresh.Click += btnRefresh_Click;

            txtSearch.TextChanged += txtSearch_TextChanged;

            dtDate.Value = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSales();
            LoadRevenue();
        }

        //=====================================
        // LOAD SALES
        //=====================================

        private void LoadSales()
        {
            try
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(
                    @"SELECT
    SaleID,
    CustomerID,
    ProductType,
    Quantity,
    UnitPrice,
    TotalAmount,
    PaymentMethod,
    SaleDate
FROM Sales",
                    con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvSales.DataSource = dt;

                dgvSales.Columns["SaleID"].Visible = false;


                dgvSales.Columns["CustomerID"].HeaderText = "Customer ID";
                dgvSales.Columns["ProductType"].HeaderText = "Product";
                dgvSales.Columns["Quantity"].HeaderText = "Quantity";
                dgvSales.Columns["UnitPrice"].HeaderText = "Unit Price";
                dgvSales.Columns["TotalAmount"].HeaderText = "Total";
                dgvSales.Columns["PaymentMethod"].HeaderText = "Payment";
                dgvSales.Columns["SaleDate"].HeaderText = "Date";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //=====================================
        // LOAD DAILY REVENUE
        //=====================================

        private void LoadRevenue()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT ISNULL(SUM(TotalAmount),0)
                      FROM Sales
                      WHERE SaleDate = CAST(GETDATE() AS DATE)",
                    con);

                con.Open();

                decimal total =
                    Convert.ToDecimal(cmd.ExecuteScalar());

                con.Close();

                lblRevenue.Text = "Rs. " + total.ToString("N2");
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        //=====================================
        // AUTO TOTAL
        //=====================================

        private void CalculateTotal(object sender, EventArgs e)
        {
            decimal qty = 0;
            decimal price = 0;

            decimal.TryParse(txtQty.Text, out qty);
            decimal.TryParse(txtPrice.Text, out price);

            txtTotal.Text = (qty * price).ToString("0.00");
        }

        //=====================================
        // CLEAR
        //=====================================

        private void ClearFields()
        {
            cmbProduct.SelectedIndex = -1;
            cmbPayment.SelectedIndex = -1;

            txtQty.Clear();
            txtPrice.Clear();
            txtTotal.Clear();

            dtDate.Value = DateTime.Today;

            txtQty.Focus();
        }

        //=====================================
        // SAVE SALE
        //=====================================

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (cmbPayment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            decimal qty, price, total;

            if (!decimal.TryParse(txtQty.Text, out qty))
            {
                MessageBox.Show("Invalid quantity.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid unit price.");
                return;
            }

            total = qty * price;

            try
            {
                SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Sales
(
    CustomerID,
    ProductType,
    Quantity,
    UnitPrice,
    TotalAmount,
    PaymentMethod,
    SaleDate
)
VALUES
(
    @CustomerID,
    @Product,
    @Qty,
    @Price,
    @Total,
    @Payment,
    @Date
)", con);

                cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(txtCustomerID.Text));
                cmd.Parameters.AddWithValue("@Product", cmbProduct.Text);
                cmd.Parameters.AddWithValue("@Qty", qty);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Total", total);
                cmd.Parameters.AddWithValue("@Payment", cmbPayment.Text);
                cmd.Parameters.AddWithValue("@Date", dtDate.Value.Date);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Sale saved successfully.");

                LoadSales();
                LoadRevenue();
                ClearFields();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                MessageBox.Show(ex.Message);
            }
        }

        //=====================================
        // DELETE SALE
        //=====================================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a sale first.");
                return;
            }

            int id =
                Convert.ToInt32(
                dgvSales.SelectedRows[0].Cells["SaleID"].Value);

            DialogResult result =
                MessageBox.Show(
                "Delete this sale?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                SqlCommand cmd =
                    new SqlCommand(
                    "DELETE FROM Sales WHERE SaleID=@id",
                    con);

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                LoadSales();
                LoadRevenue();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                MessageBox.Show(ex.Message);
            }
        }

        //=====================================
        // REFRESH
        //=====================================

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            LoadSales();

            LoadRevenue();
        }

        //=====================================
        // SEARCH
        //=====================================

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(
                    @"SELECT *
                      FROM Sales
                      WHERE ProductType LIKE @Search
                         OR PaymentMethod LIKE @Search",
                    con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@Search",
                    "%" + txtSearch.Text + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvSales.DataSource = dt;

                if (dgvSales.Columns.Contains("SaleID"))
                    dgvSales.Columns["SaleID"].Visible = false;
            }
            catch
            {

            }
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {

        }
    }
}