namespace Cinnova.Forms
{
    partial class ProductManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlSidebar = new Panel();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlProductDetails = new Panel();
            lblProductManagement = new Label();
            btnNotification = new Button();
            grpProductDetails = new GroupBox();
            btnClear = new Button();
            pnlNotification = new Panel();
            lblNotifications = new Label();
            btnSave = new Button();
            dtpProductionDate = new DateTimePicker();
            dtpExpireDate = new DateTimePicker();
            lblExpireDate = new Label();
            lblProductionDate = new Label();
            lblUnitPrice = new Label();
            cmbUnit = new ComboBox();
            lblUnit = new Label();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            lblProductCode = new Label();
            txtProductCode = new TextBox();
            cmbCategory = new ComboBox();
            lblProductCategory = new Label();
            panel1 = new Panel();
            btnViewRecords = new Button();
            imageList1 = new ImageList(components);
            lblNotificationList = new Label();
            pnlSidebar.SuspendLayout();
            pnlProductDetails.SuspendLayout();
            grpProductDetails.SuspendLayout();
            pnlNotification.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(78, 36, 16);
            pnlSidebar.Controls.Add(button1);
            pnlSidebar.Controls.Add(label3);
            pnlSidebar.Controls.Add(label4);
            pnlSidebar.Controls.Add(label5);
            pnlSidebar.Controls.Add(label6);
            pnlSidebar.Controls.Add(label7);
            pnlSidebar.Controls.Add(label8);
            pnlSidebar.Controls.Add(label9);
            pnlSidebar.Controls.Add(label10);
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Controls.Add(lblSubtitle);
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 524);
            pnlSidebar.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(39, 478);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(78, 36, 16);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 160);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 1;
            label3.Text = "Product Management";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(78, 36, 16);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 200);
            label4.Name = "label4";
            label4.Size = new Size(214, 25);
            label4.TabIndex = 2;
            label4.Text = "Inventory Management";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(78, 36, 16);
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 240);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 3;
            label5.Text = "Export order";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(78, 36, 16);
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 280);
            label6.Name = "label6";
            label6.Size = new Size(211, 25);
            label6.TabIndex = 4;
            label6.Text = "Customer Management";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(78, 36, 16);
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 320);
            label7.Name = "label7";
            label7.Size = new Size(151, 25);
            label7.TabIndex = 5;
            label7.Text = "Sales and Billing";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(78, 36, 16);
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(25, 360);
            label8.Name = "label8";
            label8.Size = new Size(213, 25);
            label8.TabIndex = 6;
            label8.Text = "Employee Management";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(78, 36, 16);
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(25, 400);
            label9.Name = "label9";
            label9.Size = new Size(199, 25);
            label9.TabIndex = 7;
            label9.Text = "Reports and Analytics";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(78, 36, 16);
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(25, 440);
            label10.Name = "label10";
            label10.Size = new Size(168, 25);
            label10.TabIndex = 8;
            label10.Text = "User Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 120);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 3;
            label2.Text = "Farmer Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 80);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 2;
            label1.Text = "Dashboard";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(39, 41);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(146, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "CINNAMON EXPORT";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(49, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cinnova";
            // 
            // pnlProductDetails
            // 
            pnlProductDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlProductDetails.Controls.Add(lblProductManagement);
            pnlProductDetails.Controls.Add(btnNotification);
            pnlProductDetails.Controls.Add(grpProductDetails);
            pnlProductDetails.Location = new Point(241, 0);
            pnlProductDetails.Name = "pnlProductDetails";
            pnlProductDetails.Size = new Size(635, 465);
            pnlProductDetails.TabIndex = 1;
            pnlProductDetails.TabStop = true;
            // 
            // lblProductManagement
            // 
            lblProductManagement.AutoSize = true;
            lblProductManagement.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductManagement.ForeColor = Color.FromArgb(78, 36, 16);
            lblProductManagement.Location = new Point(122, 27);
            lblProductManagement.Name = "lblProductManagement";
            lblProductManagement.Size = new Size(367, 48);
            lblProductManagement.TabIndex = 0;
            lblProductManagement.Text = "Product Mnagement";
            // 
            // btnNotification
            // 
            btnNotification.Cursor = Cursors.Hand;
            btnNotification.FlatStyle = FlatStyle.Flat;
            btnNotification.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNotification.Location = new Point(575, 17);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(49, 56);
            btnNotification.TabIndex = 0;
            btnNotification.Text = "🔔";
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click;
            // 
            // grpProductDetails
            // 
            grpProductDetails.Controls.Add(btnClear);
            grpProductDetails.Controls.Add(pnlNotification);
            grpProductDetails.Controls.Add(btnSave);
            grpProductDetails.Controls.Add(dtpProductionDate);
            grpProductDetails.Controls.Add(dtpExpireDate);
            grpProductDetails.Controls.Add(lblExpireDate);
            grpProductDetails.Controls.Add(lblProductionDate);
            grpProductDetails.Controls.Add(lblUnitPrice);
            grpProductDetails.Controls.Add(cmbUnit);
            grpProductDetails.Controls.Add(lblUnit);
            grpProductDetails.Controls.Add(txtUnitPrice);
            grpProductDetails.Controls.Add(txtQuantity);
            grpProductDetails.Controls.Add(lblQuantity);
            grpProductDetails.Controls.Add(lblProductCode);
            grpProductDetails.Controls.Add(txtProductCode);
            grpProductDetails.Controls.Add(cmbCategory);
            grpProductDetails.Controls.Add(lblProductCategory);
            grpProductDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpProductDetails.ForeColor = Color.FromArgb(78, 36, 16);
            grpProductDetails.Location = new Point(18, 79);
            grpProductDetails.Name = "grpProductDetails";
            grpProductDetails.Size = new Size(557, 378);
            grpProductDetails.TabIndex = 0;
            grpProductDetails.TabStop = false;
            grpProductDetails.Text = "Product Details";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(72, 334);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 38);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pnlNotification
            // 
            pnlNotification.AutoScroll = true;
            pnlNotification.BorderStyle = BorderStyle.FixedSingle;
            pnlNotification.Controls.Add(lblNotificationList);
            pnlNotification.Controls.Add(lblNotifications);
            pnlNotification.Location = new Point(192, 0);
            pnlNotification.Name = "pnlNotification";
            pnlNotification.Size = new Size(420, 300);
            pnlNotification.TabIndex = 0;
            pnlNotification.Visible = false;
            // 
            // lblNotifications
            // 
            lblNotifications.AutoSize = true;
            lblNotifications.Location = new Point(160, -1);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new Size(136, 28);
            lblNotifications.TabIndex = 0;
            lblNotifications.Text = "Notifications";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(78, 36, 16);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(368, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 38);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save Product";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtpProductionDate
            // 
            dtpProductionDate.Format = DateTimePickerFormat.Short;
            dtpProductionDate.Location = new Point(268, 236);
            dtpProductionDate.Name = "dtpProductionDate";
            dtpProductionDate.Size = new Size(220, 34);
            dtpProductionDate.TabIndex = 12;
            // 
            // dtpExpireDate
            // 
            dtpExpireDate.Format = DateTimePickerFormat.Short;
            dtpExpireDate.Location = new Point(268, 285);
            dtpExpireDate.Name = "dtpExpireDate";
            dtpExpireDate.Size = new Size(220, 34);
            dtpExpireDate.TabIndex = 11;
            // 
            // lblExpireDate
            // 
            lblExpireDate.AutoSize = true;
            lblExpireDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpireDate.ForeColor = Color.Black;
            lblExpireDate.Location = new Point(61, 285);
            lblExpireDate.Name = "lblExpireDate";
            lblExpireDate.Size = new Size(111, 28);
            lblExpireDate.TabIndex = 3;
            lblExpireDate.Text = "Expire Date";
            // 
            // lblProductionDate
            // 
            lblProductionDate.AutoSize = true;
            lblProductionDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductionDate.ForeColor = Color.Black;
            lblProductionDate.Location = new Point(60, 242);
            lblProductionDate.Name = "lblProductionDate";
            lblProductionDate.Size = new Size(155, 28);
            lblProductionDate.TabIndex = 10;
            lblProductionDate.Text = "Production Date";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnitPrice.ForeColor = Color.Black;
            lblUnitPrice.Location = new Point(61, 194);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(128, 28);
            lblUnitPrice.TabIndex = 9;
            lblUnitPrice.Text = "Price Per Unit";
            lblUnitPrice.Click += lblUnitPrice_Click;
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Items.AddRange(new object[] { "Kg", "L" });
            cmbUnit.Location = new Point(402, 139);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(120, 36);
            cmbUnit.TabIndex = 8;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.BackColor = Color.White;
            lblUnit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnit.ForeColor = Color.Black;
            lblUnit.Location = new Point(347, 142);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(49, 28);
            lblUnit.TabIndex = 7;
            lblUnit.Text = "Unit";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(268, 194);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(220, 34);
            txtUnitPrice.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.White;
            txtQuantity.Location = new Point(154, 136);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(120, 34);
            txtQuantity.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(60, 136);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(88, 28);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductCode.ForeColor = Color.Black;
            lblProductCode.Location = new Point(60, 80);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(132, 28);
            lblProductCode.TabIndex = 1;
            lblProductCode.Text = "Product Code";
            // 
            // txtProductCode
            // 
            txtProductCode.BackColor = Color.White;
            txtProductCode.Location = new Point(268, 80);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.ReadOnly = true;
            txtProductCode.Size = new Size(220, 34);
            txtProductCode.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Cinnamon Sticks", "Cinnamon Powder", "Cinnamon Oil" });
            cmbCategory.Location = new Point(268, 36);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(220, 36);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductCategory.ForeColor = Color.Black;
            lblProductCategory.Location = new Point(60, 44);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(166, 28);
            lblProductCategory.TabIndex = 0;
            lblProductCategory.Text = "Product Category";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewRecords);
            panel1.Location = new Point(241, 464);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 60);
            panel1.TabIndex = 2;
            // 
            // btnViewRecords
            // 
            btnViewRecords.BackColor = Color.FromArgb(78, 36, 16);
            btnViewRecords.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewRecords.ForeColor = Color.White;
            btnViewRecords.Location = new Point(173, 14);
            btnViewRecords.Name = "btnViewRecords";
            btnViewRecords.Size = new Size(274, 34);
            btnViewRecords.TabIndex = 15;
            btnViewRecords.Text = "View Product Records >>";
            btnViewRecords.UseVisualStyleBackColor = false;
            btnViewRecords.Click += btnViewRecords_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // lblNotificationList
            // 
            lblNotificationList.Location = new Point(5, 48);
            lblNotificationList.Name = "lblNotificationList";
            lblNotificationList.Size = new Size(408, 233);
            lblNotificationList.TabIndex = 1;
            lblNotificationList.Text = "label12";
            lblNotificationList.Click += lblNotificationList_Click;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(878, 524);
            Controls.Add(panel1);
            Controls.Add(pnlProductDetails);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Management";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlProductDetails.ResumeLayout(false);
            pnlProductDetails.PerformLayout();
            grpProductDetails.ResumeLayout(false);
            grpProductDetails.PerformLayout();
            pnlNotification.ResumeLayout(false);
            pnlNotification.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblSubtitle;
        private Label lblTitle;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label10;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Panel pnlProductDetails;
        private Panel panel1;
        private GroupBox grpProductDetails;
        private Panel pnlNotification;
        private Button btnNotification;
        private Label lblProductManagement;
        private ComboBox cmbCategory;
        private Label lblProductCategory;
        private TextBox txtProductCode;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private Label lblProductCode;
        private Label lblUnit;
        private ComboBox cmbUnit;
        private Label lblUnitPrice;
        private Label lblExpireDate;
        private Label lblProductionDate;
        private ImageList imageList1;
        private DateTimePicker dtpProductionDate;
        private DateTimePicker dtpExpireDate;
        private Button btnClear;
        private Button btnSave;
        private Button btnViewRecords;
        private Label label11;
        private Button btnClose;
        private Label lblNotifications;
        private Label lblNotificationList;
    }
}