using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace pro
{
    partial class Form1
    {
        private IContainer components = null;

        // Header
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblDate;
        private Label lblUser;
        private Label lblRole;
        private Panel pnlLine;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
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
            this.pnlHeader.SuspendLayout();
            this.pnlSale.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Controls.Add(this.lblRole);
            this.pnlHeader.Controls.Add(this.pnlLine);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1500, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(58)))), ((int)(((byte)(31)))));
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sales & Billing";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDate.Location = new System.Drawing.Point(1270, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "07 July 2026";
            // 
            // lblUser
            // 
          //  this.lblUser.AutoSize = true;
           // this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            //this.lblUser.Location = new System.Drawing.Point(1270, 20);
            //this.lblUser.Name = "lblUser";
            //this.lblUser.Size = new System.Drawing.Size(75, 20);
            //this.lblUser.TabIndex = 2;
            //this.lblUser.Text = "John Doe";
            // 
            // lblRole
            // 
         //   this.lblRole.AutoSize = true;
          //  this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F);
          //  this.lblRole.ForeColor = System.Drawing.Color.Gray;
          //  this.lblRole.Location = new System.Drawing.Point(1270, 45);
          //  this.lblRole.Name = "lblRole";
          //  this.lblRole.Size = new System.Drawing.Size(80, 15);
          //  this.lblRole.TabIndex = 3;
          //  this.lblRole.Text = "Administrator";
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLine.Location = new System.Drawing.Point(0, 84);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(1500, 1);
            this.pnlLine.TabIndex = 4;
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
            this.pnlSale.Location = new System.Drawing.Point(25, 110);
            this.pnlSale.Name = "pnlSale";
            this.pnlSale.Size = new System.Drawing.Size(980, 390);
            this.pnlSale.TabIndex = 1;
            // 
            // lblRecordSale
            // 
            this.lblRecordSale.AutoSize = true;
            this.lblRecordSale.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRecordSale.Location = new System.Drawing.Point(25, 20);
            this.lblRecordSale.Name = "lblRecordSale";
            this.lblRecordSale.Size = new System.Drawing.Size(186, 30);
            this.lblRecordSale.TabIndex = 0;
            this.lblRecordSale.Text = "Record New Sale";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(25, 65);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(87, 19);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(25, 87);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(180, 25);
            this.txtCustomerID.TabIndex = 2;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(26, 125);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(89, 19);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product Type";
            this.lblProduct.Click += new System.EventHandler(this.lblProduct_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Items.AddRange(new object[] {
            "Cinnamon Powder",
            "Cinnamon Sticks",
            "Cinnamon Oil"});
            this.cmbProduct.Location = new System.Drawing.Point(25, 150);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(350, 25);
            this.cmbProduct.TabIndex = 4;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Location = new System.Drawing.Point(446, 125);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(38, 19);
            this.lblSaleDate.TabIndex = 5;
            this.lblSaleDate.Text = "Date";
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(450, 147);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(350, 25);
            this.dtDate.TabIndex = 6;
            this.dtDate.Value = new System.DateTime(2026, 7, 7, 0, 0, 0, 0);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(26, 190);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(120, 19);
            this.lblQty.TabIndex = 7;
            this.lblQty.Text = "Quantity Sold (kg)";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(25, 212);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(350, 25);
            this.txtQty.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(450, 190);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(68, 19);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Unit Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(450, 212);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(350, 25);
            this.txtPrice.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(25, 255);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 19);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total Amount";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(25, 280);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(350, 25);
            this.txtTotal.TabIndex = 12;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(450, 255);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(116, 19);
            this.lblPayment.TabIndex = 13;
            this.lblPayment.Text = "Payment Method";
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.Items.AddRange(new object[] {
            "Cash",
            "Bank Transfer"});
            this.cmbPayment.Location = new System.Drawing.Point(450, 280);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(350, 25);
            this.cmbPayment.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(74)))), ((int)(((byte)(37)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(250, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save Sale";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(430, 335);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 42);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.White;
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.Controls.Add(this.pnlRevenue);
            this.pnlSummary.Location = new System.Drawing.Point(1030, 110);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(430, 390);
            this.pnlSummary.TabIndex = 2;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(58)))), ((int)(((byte)(31)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(25, 20);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(170, 30);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Daily Summary";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.pnlRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRevenue.Controls.Add(this.lblRevenueTitle);
            this.pnlRevenue.Controls.Add(this.lblRevenue);
            this.pnlRevenue.Controls.Add(this.lblRevenueDesc);
            this.pnlRevenue.Location = new System.Drawing.Point(25, 70);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(375, 230);
            this.pnlRevenue.TabIndex = 1;
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(58)))), ((int)(((byte)(31)))));
            this.lblRevenueTitle.Location = new System.Drawing.Point(25, 25);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(159, 25);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "Today\'s Revenue";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            this.lblRevenue.Location = new System.Drawing.Point(25, 80);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(169, 54);
            this.lblRevenue.TabIndex = 1;
            this.lblRevenue.Text = "Rs. 0.00";
            // 
            // lblRevenueDesc
            // 
            this.lblRevenueDesc.AutoSize = true;
            this.lblRevenueDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRevenueDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblRevenueDesc.Location = new System.Drawing.Point(30, 160);
            this.lblRevenueDesc.Name = "lblRevenueDesc";
            this.lblRevenueDesc.Size = new System.Drawing.Size(176, 19);
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
            this.pnlRecords.Location = new System.Drawing.Point(25, 520);
            this.pnlRecords.Name = "pnlRecords";
            this.pnlRecords.Size = new System.Drawing.Size(1435, 330);
            this.pnlRecords.TabIndex = 3;
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.AutoSize = true;
            this.lblRecordsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRecordsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(58)))), ((int)(((byte)(31)))));
            this.lblRecordsTitle.Location = new System.Drawing.Point(25, 20);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(186, 30);
            this.lblRecordsTitle.TabIndex = 0;
            this.lblRecordsTitle.Text = "All Sales Records";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(25, 65);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 19);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(90, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(380, 58);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 38);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(510, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Sale";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToResizeRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSales.ColumnHeadersHeight = 42;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvSales.Location = new System.Drawing.Point(25, 110);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(1380, 190);
            this.dgvSales.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSale);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlRecords);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales & Billing";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
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

        }

        #endregion
    }
}