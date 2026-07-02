namespace biliing_system
{
    partial class InvoiceForm
    {
 
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlNewInvoice = new Panel();
            lblNewInvoiceHeader = new Label();
            lblInvoiceNumber = new Label();
            lblCustomerDetails = new Label();
            lblClientName = new Label();
            cboClientName = new ComboBox();
            lblBillingAddress = new Label();
            txtBillingAddress = new TextBox();
            lblExportLicense = new Label();
            txtExportLicense = new TextBox();
            lblPaymentTerms = new Label();
            cboPaymentTerms = new ComboBox();
            lblBillingItems = new Label();
            lnkAddItem = new LinkLabel();
            dgvBillingItems = new DataGridView();
            colProductDescription = new DataGridViewTextBoxColumn();
            colGrade = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            pnlPaymentSummary = new Panel();
            lblPaymentSummaryHeader = new Label();
            lblSubtotalCaption = new Label();
            lblSubtotalValue = new Label();
            lblExportTaxCaption = new Label();
            lblExportTaxValue = new Label();
            lblShippingCaption = new Label();
            lblShippingValue = new Label();
            lblGrandTotalCaption = new Label();
            lblGrandTotalValue = new Label();
            btnGenerateBill = new Button();
            pnlRecentInvoices = new Panel();
            lblRecentInvoicesHeader = new Label();
            btnDownload = new Button();
            dgvRecentInvoices = new DataGridView();
            colInvoiceId = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlNewInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBillingItems).BeginInit();
            pnlPaymentSummary.SuspendLayout();
            pnlRecentInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentInvoices).BeginInit();
            SuspendLayout();
            
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1143, 80);
            pnlHeader.TabIndex = 0;
           
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(60, 40, 30);
            lblTitle.Location = new Point(27, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(154, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sales && Billing";
          
            pnlNewInvoice.BackColor = Color.FromArgb(253, 249, 244);
            pnlNewInvoice.BorderStyle = BorderStyle.FixedSingle;
            pnlNewInvoice.Controls.Add(lblNewInvoiceHeader);
            pnlNewInvoice.Controls.Add(lblInvoiceNumber);
            pnlNewInvoice.Controls.Add(lblCustomerDetails);
            pnlNewInvoice.Controls.Add(lblClientName);
            pnlNewInvoice.Controls.Add(cboClientName);
            pnlNewInvoice.Controls.Add(lblBillingAddress);
            pnlNewInvoice.Controls.Add(txtBillingAddress);
            pnlNewInvoice.Controls.Add(lblExportLicense);
            pnlNewInvoice.Controls.Add(txtExportLicense);
            pnlNewInvoice.Controls.Add(lblPaymentTerms);
            pnlNewInvoice.Controls.Add(cboPaymentTerms);
            pnlNewInvoice.Controls.Add(lblBillingItems);
            pnlNewInvoice.Controls.Add(lnkAddItem);
            pnlNewInvoice.Controls.Add(dgvBillingItems);
            pnlNewInvoice.Location = new Point(23, 101);
            pnlNewInvoice.Margin = new Padding(3, 4, 3, 4);
            pnlNewInvoice.Name = "pnlNewInvoice";
            pnlNewInvoice.Size = new Size(697, 559);
            pnlNewInvoice.TabIndex = 1;
           
            lblNewInvoiceHeader.AutoSize = true;
            lblNewInvoiceHeader.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblNewInvoiceHeader.Location = new Point(18, 19);
            lblNewInvoiceHeader.Name = "lblNewInvoiceHeader";
            lblNewInvoiceHeader.Size = new Size(118, 25);
            lblNewInvoiceHeader.TabIndex = 0;
            lblNewInvoiceHeader.Text = "New Invoice";
            
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.BackColor = Color.FromArgb(240, 234, 226);
            lblInvoiceNumber.Font = new Font("Segoe UI", 8F);
            lblInvoiceNumber.Location = new Point(571, 21);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Padding = new Padding(7, 4, 7, 4);
            lblInvoiceNumber.Size = new Size(122, 27);
            lblInvoiceNumber.TabIndex = 1;
            lblInvoiceNumber.Text = "INV-2023-0892";
           
            lblCustomerDetails.AutoSize = true;
            lblCustomerDetails.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCustomerDetails.ForeColor = Color.Gray;
            lblCustomerDetails.Location = new Point(18, 67);
            lblCustomerDetails.Name = "lblCustomerDetails";
            lblCustomerDetails.Size = new Size(140, 19);
            lblCustomerDetails.TabIndex = 2;
            lblCustomerDetails.Text = "CUSTOMER DETAILS";
          
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Segoe UI", 8F);
            lblClientName.Location = new Point(18, 99);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(84, 19);
            lblClientName.TabIndex = 3;
            lblClientName.Text = "Client Name";
           
            cboClientName.FlatStyle = FlatStyle.Flat;
            cboClientName.Location = new Point(18, 123);
            cboClientName.Margin = new Padding(3, 4, 3, 4);
            cboClientName.Name = "cboClientName";
            cboClientName.Size = new Size(308, 28);
            cboClientName.TabIndex = 4;
            cboClientName.Text = "Select Customer";
           
            lblBillingAddress.AutoSize = true;
            lblBillingAddress.Font = new Font("Segoe UI", 8F);
            lblBillingAddress.Location = new Point(354, 99);
            lblBillingAddress.Name = "lblBillingAddress";
            lblBillingAddress.Size = new Size(98, 19);
            lblBillingAddress.TabIndex = 5;
            lblBillingAddress.Text = "Billing Address";
           
            txtBillingAddress.Location = new Point(354, 123);
            txtBillingAddress.Margin = new Padding(3, 4, 3, 4);
            txtBillingAddress.Name = "txtBillingAddress";
            txtBillingAddress.Size = new Size(324, 27);
            txtBillingAddress.TabIndex = 6;
            txtBillingAddress.Text = "123 Export Way, Colombo";
           
            lblExportLicense.AutoSize = true;
            lblExportLicense.Font = new Font("Segoe UI", 8F);
            lblExportLicense.Location = new Point(18, 171);
            lblExportLicense.Name = "lblExportLicense";
            lblExportLicense.Size = new Size(121, 19);
            lblExportLicense.TabIndex = 7;
            lblExportLicense.Text = "Export License No.";
           
            txtExportLicense.Location = new Point(18, 195);
            txtExportLicense.Margin = new Padding(3, 4, 3, 4);
            txtExportLicense.Name = "txtExportLicense";
            txtExportLicense.Size = new Size(308, 27);
            txtExportLicense.TabIndex = 8;
            txtExportLicense.Text = "EL-99203-A";
           
            lblPaymentTerms.AutoSize = true;
            lblPaymentTerms.Font = new Font("Segoe UI", 8F);
            lblPaymentTerms.Location = new Point(354, 171);
            lblPaymentTerms.Name = "lblPaymentTerms";
            lblPaymentTerms.Size = new Size(103, 19);
            lblPaymentTerms.TabIndex = 9;
            lblPaymentTerms.Text = "Payment Terms";
          
            cboPaymentTerms.FlatStyle = FlatStyle.Flat;
            cboPaymentTerms.Location = new Point(354, 195);
            cboPaymentTerms.Margin = new Padding(3, 4, 3, 4);
            cboPaymentTerms.Name = "cboPaymentTerms";
            cboPaymentTerms.Size = new Size(324, 28);
            cboPaymentTerms.TabIndex = 10;
            cboPaymentTerms.Text = "Net 30";
           
            lblBillingItems.AutoSize = true;
            lblBillingItems.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBillingItems.ForeColor = Color.Gray;
            lblBillingItems.Location = new Point(18, 253);
            lblBillingItems.Name = "lblBillingItems";
            lblBillingItems.Size = new Size(105, 19);
            lblBillingItems.TabIndex = 11;
            lblBillingItems.Text = "BILLING ITEMS";
         
            lnkAddItem.AutoSize = true;
            lnkAddItem.LinkColor = Color.FromArgb(140, 90, 60);
            lnkAddItem.Location = new Point(571, 252);
            lnkAddItem.Name = "lnkAddItem";
            lnkAddItem.Size = new Size(85, 20);
            lnkAddItem.TabIndex = 12;
            lnkAddItem.TabStop = true;
            lnkAddItem.Text = "+ Add Item";
          
            dgvBillingItems.AllowUserToAddRows = false;
            dgvBillingItems.BackgroundColor = Color.White;
            dgvBillingItems.BorderStyle = BorderStyle.None;
            dgvBillingItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillingItems.Columns.AddRange(new DataGridViewColumn[] { colProductDescription, colGrade, colQty, colUnitPrice, colAmount });
            dgvBillingItems.Location = new Point(3, 295);
            dgvBillingItems.Margin = new Padding(3, 4, 3, 4);
            dgvBillingItems.Name = "dgvBillingItems";
            dgvBillingItems.ReadOnly = true;
            dgvBillingItems.RowHeadersVisible = false;
            dgvBillingItems.RowHeadersWidth = 51;
            dgvBillingItems.Size = new Size(529, 258);
            dgvBillingItems.TabIndex = 13;
         
            colProductDescription.HeaderText = "Product Description";
            colProductDescription.MinimumWidth = 6;
            colProductDescription.Name = "colProductDescription";
            colProductDescription.ReadOnly = true;
            colProductDescription.Width = 180;
          
            colGrade.HeaderText = "Grade";
            colGrade.MinimumWidth = 6;
            colGrade.Name = "colGrade";
            colGrade.ReadOnly = true;
            colGrade.Width = 90;
           
            colQty.HeaderText = "Qty (kg)";
            colQty.MinimumWidth = 6;
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            colQty.Width = 80;
           
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.MinimumWidth = 6;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            colUnitPrice.Width = 90;
          
            colAmount.HeaderText = "Amount";
            colAmount.MinimumWidth = 6;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = 90;
          
            pnlPaymentSummary.BackColor = Color.FromArgb(253, 249, 244);
            pnlPaymentSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlPaymentSummary.Controls.Add(lblPaymentSummaryHeader);
            pnlPaymentSummary.Controls.Add(lblSubtotalCaption);
            pnlPaymentSummary.Controls.Add(lblSubtotalValue);
            pnlPaymentSummary.Controls.Add(lblExportTaxCaption);
            pnlPaymentSummary.Controls.Add(lblExportTaxValue);
            pnlPaymentSummary.Controls.Add(lblShippingCaption);
            pnlPaymentSummary.Controls.Add(lblShippingValue);
            pnlPaymentSummary.Controls.Add(lblGrandTotalCaption);
            pnlPaymentSummary.Controls.Add(lblGrandTotalValue);
            pnlPaymentSummary.Controls.Add(btnGenerateBill);
            pnlPaymentSummary.Location = new Point(738, 101);
            pnlPaymentSummary.Margin = new Padding(3, 4, 3, 4);
            pnlPaymentSummary.Name = "pnlPaymentSummary";
            pnlPaymentSummary.Size = new Size(377, 559);
            pnlPaymentSummary.TabIndex = 2;
       
            lblPaymentSummaryHeader.AutoSize = true;
            lblPaymentSummaryHeader.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPaymentSummaryHeader.ForeColor = Color.Gray;
            lblPaymentSummaryHeader.Location = new Point(18, 21);
            lblPaymentSummaryHeader.Name = "lblPaymentSummaryHeader";
            lblPaymentSummaryHeader.Size = new Size(150, 19);
            lblPaymentSummaryHeader.TabIndex = 0;
            lblPaymentSummaryHeader.Text = "PAYMENT SUMMARY";
          
            lblSubtotalCaption.AutoSize = true;
            lblSubtotalCaption.Location = new Point(18, 67);
            lblSubtotalCaption.Name = "lblSubtotalCaption";
            lblSubtotalCaption.Size = new Size(65, 20);
            lblSubtotalCaption.TabIndex = 1;
            lblSubtotalCaption.Text = "Subtotal";
          
            lblSubtotalValue.AutoSize = true;
            lblSubtotalValue.Location = new Point(309, 67);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(79, 20);
            lblSubtotalValue.TabIndex = 2;
            lblSubtotalValue.Text = "$25,500.00";
            lblSubtotalValue.TextAlign = ContentAlignment.MiddleRight;
          
            lblExportTaxCaption.AutoSize = true;
            lblExportTaxCaption.Location = new Point(18, 104);
            lblExportTaxCaption.Name = "lblExportTaxCaption";
            lblExportTaxCaption.Size = new Size(122, 20);
            lblExportTaxCaption.TabIndex = 3;
            lblExportTaxCaption.Text = "Export Tax (2.5%)";
          
            lblExportTaxValue.AutoSize = true;
            lblExportTaxValue.Location = new Point(320, 104);
            lblExportTaxValue.Name = "lblExportTaxValue";
            lblExportTaxValue.Size = new Size(60, 20);
            lblExportTaxValue.TabIndex = 4;
            lblExportTaxValue.Text = "$637.50";
          
            lblShippingCaption.AutoSize = true;
            lblShippingCaption.Location = new Point(18, 141);
            lblShippingCaption.Name = "lblShippingCaption";
            lblShippingCaption.Size = new Size(134, 20);
            lblShippingCaption.TabIndex = 5;
            lblShippingCaption.Text = "Shipping Insurance";
         
            lblShippingValue.AutoSize = true;
            lblShippingValue.Location = new Point(320, 141);
            lblShippingValue.Name = "lblShippingValue";
            lblShippingValue.Size = new Size(60, 20);
            lblShippingValue.TabIndex = 6;
            lblShippingValue.Text = "$150.00";
           
            lblGrandTotalCaption.AutoSize = true;
            lblGrandTotalCaption.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblGrandTotalCaption.Location = new Point(18, 187);
            lblGrandTotalCaption.Name = "lblGrandTotalCaption";
            lblGrandTotalCaption.Size = new Size(67, 56);
            lblGrandTotalCaption.TabIndex = 7;
            lblGrandTotalCaption.Text = "Grand\r\nTotal";
          
            lblGrandTotalValue.AutoSize = true;
            lblGrandTotalValue.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblGrandTotalValue.ForeColor = Color.FromArgb(140, 90, 60);
            lblGrandTotalValue.Location = new Point(206, 197);
            lblGrandTotalValue.Name = "lblGrandTotalValue";
            lblGrandTotalValue.Size = new Size(137, 32);
            lblGrandTotalValue.TabIndex = 8;
            lblGrandTotalValue.Text = "$ 26,287.50";
           
            btnGenerateBill.BackColor = Color.FromArgb(90, 55, 35);
            btnGenerateBill.FlatStyle = FlatStyle.Flat;
            btnGenerateBill.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerateBill.ForeColor = Color.White;
            btnGenerateBill.Location = new Point(18, 267);
            btnGenerateBill.Margin = new Padding(3, 4, 3, 4);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(341, 53);
            btnGenerateBill.TabIndex = 9;
            btnGenerateBill.Text = "Generate Bill as a PDF";
            btnGenerateBill.UseVisualStyleBackColor = false;
          
            pnlRecentInvoices.BackColor = Color.White;
            pnlRecentInvoices.BorderStyle = BorderStyle.FixedSingle;
            pnlRecentInvoices.Controls.Add(lblRecentInvoicesHeader);
            pnlRecentInvoices.Controls.Add(btnDownload);
            pnlRecentInvoices.Controls.Add(dgvRecentInvoices);
            pnlRecentInvoices.Location = new Point(23, 680);
            pnlRecentInvoices.Margin = new Padding(3, 4, 3, 4);
            pnlRecentInvoices.Name = "pnlRecentInvoices";
            pnlRecentInvoices.Size = new Size(1092, 346);
            pnlRecentInvoices.TabIndex = 3;
           
            lblRecentInvoicesHeader.AutoSize = true;
            lblRecentInvoicesHeader.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRecentInvoicesHeader.Location = new Point(18, 19);
            lblRecentInvoicesHeader.Name = "lblRecentInvoicesHeader";
            lblRecentInvoicesHeader.Size = new Size(145, 25);
            lblRecentInvoicesHeader.TabIndex = 0;
            lblRecentInvoicesHeader.Text = "Recent Invoices";
           
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Location = new Point(921, 13);
            btnDownload.Margin = new Padding(3, 4, 3, 4);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(145, 43);
            btnDownload.TabIndex = 2;
            btnDownload.Text = "Download invoice";
            btnDownload.UseVisualStyleBackColor = true;
           
            dgvRecentInvoices.AllowUserToAddRows = false;
            dgvRecentInvoices.BackgroundColor = Color.White;
            dgvRecentInvoices.BorderStyle = BorderStyle.None;
            dgvRecentInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentInvoices.Columns.AddRange(new DataGridViewColumn[] { colInvoiceId, colCustomer, colDate, colTotalAmount, colStatus, colActions });
            dgvRecentInvoices.Location = new Point(18, 72);
            dgvRecentInvoices.Margin = new Padding(3, 4, 3, 4);
            dgvRecentInvoices.Name = "dgvRecentInvoices";
            dgvRecentInvoices.ReadOnly = true;
            dgvRecentInvoices.RowHeadersVisible = false;
            dgvRecentInvoices.RowHeadersWidth = 51;
            dgvRecentInvoices.Size = new Size(1056, 253);
            dgvRecentInvoices.TabIndex = 3;
          
            colInvoiceId.HeaderText = "INVOICE ID";
            colInvoiceId.MinimumWidth = 6;
            colInvoiceId.Name = "colInvoiceId";
            colInvoiceId.ReadOnly = true;
            colInvoiceId.Width = 140;
          
            colCustomer.HeaderText = "CUSTOMER";
            colCustomer.MinimumWidth = 6;
            colCustomer.Name = "colCustomer";
            colCustomer.ReadOnly = true;
            colCustomer.Width = 200;
          
            colDate.HeaderText = "DATE";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 130;
         
            colTotalAmount.HeaderText = "TOTAL AMOUNT";
            colTotalAmount.MinimumWidth = 6;
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            colTotalAmount.Width = 130;
           
            colStatus.HeaderText = "STATUS";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 110;
          
            colActions.HeaderText = "ACTIONS";
            colActions.MinimumWidth = 6;
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
          
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 233);
            ClientSize = new Size(1143, 1053);
            Controls.Add(pnlRecentInvoices);
            Controls.Add(pnlPaymentSummary);
            Controls.Add(pnlNewInvoice);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InvoiceForm";
            Text = "Sales & Billing - New Invoice";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlNewInvoice.ResumeLayout(false);
            pnlNewInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBillingItems).EndInit();
            pnlPaymentSummary.ResumeLayout(false);
            pnlPaymentSummary.PerformLayout();
            pnlRecentInvoices.ResumeLayout(false);
            pnlRecentInvoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentInvoices).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlNewInvoice;
        private System.Windows.Forms.Label lblNewInvoiceHeader;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.ComboBox cboClientName;
        private System.Windows.Forms.Label lblBillingAddress;
        private System.Windows.Forms.TextBox txtBillingAddress;
        private System.Windows.Forms.Label lblExportLicense;
        private System.Windows.Forms.TextBox txtExportLicense;
        private System.Windows.Forms.Label lblPaymentTerms;
        private System.Windows.Forms.ComboBox cboPaymentTerms;
        private System.Windows.Forms.Label lblBillingItems;
        private System.Windows.Forms.LinkLabel lnkAddItem;
        private System.Windows.Forms.DataGridView dgvBillingItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;

        private System.Windows.Forms.Panel pnlPaymentSummary;
        private System.Windows.Forms.Label lblPaymentSummaryHeader;
        private System.Windows.Forms.Label lblSubtotalCaption;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblExportTaxCaption;
        private System.Windows.Forms.Label lblExportTaxValue;
        private System.Windows.Forms.Label lblShippingCaption;
        private System.Windows.Forms.Label lblShippingValue;
        private System.Windows.Forms.Label lblGrandTotalCaption;
        private System.Windows.Forms.Label lblGrandTotalValue;
        private System.Windows.Forms.Button btnGenerateBill;

        private System.Windows.Forms.Panel pnlRecentInvoices;
        private System.Windows.Forms.Label lblRecentInvoicesHeader;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataGridView dgvRecentInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActions;
    }
}