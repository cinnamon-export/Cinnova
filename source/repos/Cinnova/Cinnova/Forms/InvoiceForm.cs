using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Cinnova.Database;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biliing_system
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
            LoadData();
            WireEvents();
        }

        private void LoadData()
        {
            // Attempt to load from database and fall back to sample data on failure
            try
            {
                if (!LoadDataFromDatabase())
                {
                    LoadSampleData();
                }
            }
            catch
            {
                LoadSampleData();
            }
        }

        private bool LoadDataFromDatabase()
        {
            try
            {
                // Clear existing rows/items
                dgvBillingItems.Rows.Clear();
                dgvRecentInvoices.Rows.Clear();
                cboClientName.Items.Clear();

                // Payment terms (keep the existing static options)
                cboPaymentTerms.Items.Clear();
                cboPaymentTerms.Items.AddRange(new object[] { "Net 15", "Net 30", "Net 60", "Due on Receipt" });

                // Load clients
                DataTable clients = DatabaseHelper.ExecuteQuery("SELECT Name FROM Clients");
                if (clients != null && clients.Rows.Count > 0)
                {
                    foreach (DataRow row in clients.Rows)
                    {
                        var name = row["Name"]?.ToString();
                        if (!string.IsNullOrEmpty(name))
                            cboClientName.Items.Add(name);
                    }
                }

                // Load recent invoices
                DataTable invoices = DatabaseHelper.ExecuteQuery(
                    "SELECT TOP (10) InvoiceNumber, ClientName, InvoiceDate, TotalAmount, Status FROM Invoices ORDER BY InvoiceDate DESC");

                if (invoices != null && invoices.Rows.Count > 0)
                {
                    foreach (DataRow row in invoices.Rows)
                    {
                        string inv = row["InvoiceNumber"]?.ToString() ?? string.Empty;
                        string client = row["ClientName"]?.ToString() ?? string.Empty;
                        string dateStr = string.Empty;
                        if (row["InvoiceDate"] != DBNull.Value && DateTime.TryParse(row["InvoiceDate"].ToString(), out DateTime dt))
                            dateStr = dt.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
                        string total = row["TotalAmount"]?.ToString() ?? string.Empty;
                        string status = row["Status"]?.ToString() ?? string.Empty;

                        dgvRecentInvoices.Rows.Add(inv, client, dateStr, total, status, "⋮");
                    }
                }

                // If no clients or invoices found, indicate failure to let caller fallback
                return true;
            }
            catch (Exception ex)
            {
                // Log and indicate failure so the caller can use sample data
                Console.WriteLine("DB load failed: " + ex.Message);
                return false;
            }
        }

        private void LoadSampleData()
        {
            // Billing items grid (matches "Alba Cinnamon Sticks" / "C4 Grade Quills" rows)
            dgvBillingItems.Rows.Add("Alba Cinnamon Sticks", "PREMIUM", "250", "$45.00", "$11,250.00");
            dgvBillingItems.Rows.Add("C4 Grade Quills", "STANDARD", "500", "$28.50", "$14,250.00");

            // Recent invoices grid
            dgvRecentInvoices.Rows.Add("#INV-2023-0891", "Amsterdam Trading Co.", "24 Oct 2023", "$18,400.00", "PAID", "⋮");
            dgvRecentInvoices.Rows.Add("#INV-2023-0890", "London Spice Emporium", "22 Oct 2023", "$4,200.00", "PENDING", "⋮");

            // Payment terms options
            cboPaymentTerms.Items.AddRange(new object[] { "Net 15", "Net 30", "Net 60", "Due on Receipt" });

            // Client dropdown placeholder
            cboClientName.Items.AddRange(new object[] { "Amsterdam Trading Co.", "London Spice Emporium" });
        }

        private void WireEvents()
        {
            btnGenerateBill.Click += BtnGenerateBill_Click;
            btnPrintDraft.Click += BtnPrintDraft_Click;
            lnkAddItem.LinkClicked += LnkAddItem_LinkClicked;
        }

        private void BtnGenerateBill_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Bill generated and finalized.", "Sales & Billing",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnPrintDraft_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Printing draft invoice...", "Sales & Billing",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LnkAddItem_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvBillingItems.Rows.Add("New Product", "STANDARD", "0", "$0.00", "$0.00");
        }
    }
}