using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace pro
{
    partial class Form1
    {
        private IContainer components = null;
        private Label lblTitle;
        private Label lblDate;

        // Record Sale Panel
        private Panel pnlSale;

        private Label lblRecordSale;
        private Label lblProduct;
        private Label lblCustomerID;
        private Label lblSaleDate;
        private Label lblQty;
        private Label lblPrice;
        private Label lblTotal;
        private Label lblPayment;

        private ComboBox cmbProduct;
        private ComboBox cmbPayment;
        private TextBox txtCustomerID;
        private TextBox txtQty;
        private TextBox txtPrice;

        private TextBox txtTotal;

        private DateTimePicker dtDate;

        private Button btnSave;
        private Button btnClear;

        //=====================
        // Daily Summary
        //=====================

        private Panel pnlSummary;

        private Label lblSummaryTitle;

        private Panel pnlRevenue;

        private Label lblRevenueTitle;

        private Label lblRevenue;

        private Label lblRevenueDesc;


        //=====================
        // Sales Records
        //=====================

        private Panel pnlRecords;

        private Label lblRecordsTitle;

        private Label lblSearch;

        private TextBox txtSearch;

        private Button btnRefresh;

        private Button btnDelete;

        private DataGridView dgvSales;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlSale = new System.Windows.Forms.Panel();
            this.lblRecordSale = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblRevenueDesc = new System.Windows.Forms.Label();
            this.pnlRecords = new System.Windows.Forms.Panel();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSale.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(38)))), ((int)(((byte)(16)))));
            this.lblTitle.Location = new System.Drawing.Point(218, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sales & Billing";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDate.Location = new System.Drawing.Point(30, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(114, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "07 July 2026";
            // 
            // pnlSale
            // 
            this.pnlSale.BackColor = System.Drawing.Color.White;
            this.pnlSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSale.Controls.Add(this.lblRecordSale);
            this.pnlSale.Controls.Add(this.lblCustomerID);
            this.pnlSale.Controls.Add(this.txtCustomerID);
            this.pnlSale.Controls.Add(this.lblProduct);
            this.pnlSale.Controls.Add(this.cmbProduct);
            this.pnlSale.Controls.Add(this.lblSaleDate);
            this.pnlSale.Controls.Add(this.dtDate);
            this.pnlSale.Controls.Add(this.lblQty);
            this.pnlSale.Controls.Add(this.txtQty);
            this.pnlSale.Controls.Add(this.lblPrice);
            this.pnlSale.Controls.Add(this.txtPrice);
            this.pnlSale.Controls.Add(this.lblTotal);
            this.pnlSale.Controls.Add(this.txtTotal);
            this.pnlSale.Controls.Add(this.lblPayment);
            this.pnlSale.Controls.Add(this.cmbPayment);
            this.pnlSale.Controls.Add(this.btnSave);
            this.pnlSale.Controls.Add(this.btnClear);
            this.pnlSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSale.Location = new System.Drawing.Point(223, 43);
            this.pnlSale.Name = "pnlSale";
            this.pnlSale.Size = new System.Drawing.Size(457, 343);
            this.pnlSale.TabIndex = 1;
            // 
            // lblRecordSale
            // 
            this.lblRecordSale.AutoSize = true;
            this.lblRecordSale.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordSale.Location = new System.Drawing.Point(18, 11);
            this.lblRecordSale.Name = "lblRecordSale";
            this.lblRecordSale.Size = new System.Drawing.Size(155, 25);
            this.lblRecordSale.TabIndex = 0;
            this.lblRecordSale.Text = "Record New Sale";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(3, 43);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(91, 20);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(8, 68);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(190, 27);
            this.txtCustomerID.TabIndex = 2;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(4, 110);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(95, 20);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product Type";
            this.lblProduct.Click += new System.EventHandler(this.lblProduct_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.Items.AddRange(new object[] {
            "Cinnamon Powder",
            "Cinnamon Sticks",
            "Cinnamon Oil"});
            this.cmbProduct.Location = new System.Drawing.Point(8, 133);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(190, 28);
            this.cmbProduct.TabIndex = 4;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleDate.Location = new System.Drawing.Point(226, 43);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(41, 20);
            this.lblSaleDate.TabIndex = 5;
            this.lblSaleDate.Text = "Date";
            // 
            // dtDate
            // 
            this.dtDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(230, 68);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(207, 27);
            this.dtDate.TabIndex = 6;
            this.dtDate.Value = new System.DateTime(2026, 7, 7, 0, 0, 0, 0);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(3, 168);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(129, 20);
            this.lblQty.TabIndex = 7;
            this.lblQty.Text = "Quantity Sold (kg)";
            this.lblQty.Click += new System.EventHandler(this.lblQty_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(8, 191);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(190, 27);
            this.txtQty.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(226, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(72, 20);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Unit Price";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(230, 134);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(207, 27);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(33, 230);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total Amount";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(37, 253);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(190, 27);
            this.txtTotal.TabIndex = 12;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(226, 168);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(121, 20);
            this.lblPayment.TabIndex = 13;
            this.lblPayment.Text = "Payment Method";
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.Items.AddRange(new object[] {
            "Cash",
            "Bank Transfer"});
            this.cmbPayment.Location = new System.Drawing.Point(230, 190);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(207, 28);
            this.cmbPayment.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(38)))), ((int)(((byte)(16)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(90, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 33);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save Sale";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(38)))), ((int)(((byte)(16)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(250, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 33);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.White;
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.Controls.Add(this.pnlRevenue);
            this.pnlSummary.Location = new System.Drawing.Point(697, 43);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(334, 343);
            this.pnlSummary.TabIndex = 2;
            this.pnlSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSummary_Paint);
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(58)))), ((int)(((byte)(31)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(11, 11);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(213, 37);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Daily Summary";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.pnlRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRevenue.Controls.Add(this.lblRevenueTitle);
            this.pnlRevenue.Controls.Add(this.lblRevenue);
            this.pnlRevenue.Controls.Add(this.lblDate);
            this.pnlRevenue.Controls.Add(this.lblRevenueDesc);
            this.pnlRevenue.Location = new System.Drawing.Point(18, 73);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(293, 232);
            this.pnlRevenue.TabIndex = 1;
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(58)))), ((int)(((byte)(31)))));
            this.lblRevenueTitle.Location = new System.Drawing.Point(16, 16);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(189, 31);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "Today\'s Revenue";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            this.lblRevenue.Location = new System.Drawing.Point(44, 112);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(86, 28);
            this.lblRevenue.TabIndex = 1;
            this.lblRevenue.Text = "Rs. 0.00";
            // 
            // lblRevenueDesc
            // 
            this.lblRevenueDesc.AutoSize = true;
            this.lblRevenueDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRevenueDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblRevenueDesc.Location = new System.Drawing.Point(31, 156);
            this.lblRevenueDesc.Name = "lblRevenueDesc";
            this.lblRevenueDesc.Size = new System.Drawing.Size(218, 23);
            this.lblRevenueDesc.TabIndex = 2;
            this.lblRevenueDesc.Text = "Total revenue earned today";
            // 
            // pnlRecords
            // 
            this.pnlRecords.BackColor = System.Drawing.Color.White;
            this.pnlRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecords.Controls.Add(this.lblRecordsTitle);
            this.pnlRecords.Controls.Add(this.lblSearch);
            this.pnlRecords.Controls.Add(this.txtSearch);
            this.pnlRecords.Controls.Add(this.btnRefresh);
            this.pnlRecords.Controls.Add(this.btnDelete);
            this.pnlRecords.Controls.Add(this.dgvSales);
            this.pnlRecords.Location = new System.Drawing.Point(223, 400);
            this.pnlRecords.Name = "pnlRecords";
            this.pnlRecords.Size = new System.Drawing.Size(808, 200);
            this.pnlRecords.TabIndex = 3;
            this.pnlRecords.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRecords_Paint);
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.AutoSize = true;
            this.lblRecordsTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(58)))), ((int)(((byte)(31)))));
            this.lblRecordsTitle.Location = new System.Drawing.Point(3, 13);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(156, 25);
            this.lblRecordsTitle.TabIndex = 0;
            this.lblRecordsTitle.Text = "All Sales Records";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(19, 54);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(78, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(228, 27);
            this.txtSearch.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(343, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 27);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(452, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Sale";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToResizeRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.ColumnHeadersHeight = 42;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvSales.Location = new System.Drawing.Point(23, 84);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(762, 93);
            this.dgvSales.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 610);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1053, 612);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSale);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlRecords);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales & Billing";
            this.pnlSale.ResumeLayout(false);
            this.pnlSale.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlRecords.ResumeLayout(false);
            this.pnlRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
    }
}