namespace Cinnova.Forms
{
    partial class UpdateProductForm
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
            txtQuantity = new TextBox();
            txtProductCode = new TextBox();
            cmbUnit = new ComboBox();
            cmbCategory = new ComboBox();
            dtProductionDate = new DateTimePicker();
            dtpExpireDate = new DateTimePicker();
            lblTitle = new Label();
            lblProductCode = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblUnit = new Label();
            lblUnitPrice = new Label();
            lblProductionDate = new Label();
            lblExpireDate = new Label();
            txtUnitPrice = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(192, 180);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(182, 31);
            txtQuantity.TabIndex = 0;
            txtQuantity.TextChanged += Control_ValueChanged;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(192, 96);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.ReadOnly = true;
            txtProductCode.Size = new Size(180, 31);
            txtProductCode.TabIndex = 1;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Items.AddRange(new object[] { "Kg", "L" });
            cmbUnit.Location = new Point(192, 224);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(182, 33);
            cmbUnit.TabIndex = 2;
            cmbUnit.SelectedIndexChanged += Control_ValueChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Cinnamon Sticks", "", "Cinnamon Powder", "", "Cinnamon Oil" });
            cmbCategory.Location = new Point(192, 141);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(182, 33);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += Control_ValueChanged;
            // 
            // dtProductionDate
            // 
            dtProductionDate.Format = DateTimePickerFormat.Short;
            dtProductionDate.Location = new Point(192, 319);
            dtProductionDate.Name = "dtProductionDate";
            dtProductionDate.Size = new Size(217, 31);
            dtProductionDate.TabIndex = 4;
            dtProductionDate.ValueChanged += Control_ValueChanged;
            // 
            // dtpExpireDate
            // 
            dtpExpireDate.Format = DateTimePickerFormat.Short;
            dtpExpireDate.Location = new Point(192, 369);
            dtpExpireDate.Name = "dtpExpireDate";
            dtpExpireDate.Size = new Size(217, 31);
            dtpExpireDate.TabIndex = 5;
            dtpExpireDate.ValueChanged += Control_ValueChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(78, 36, 16);
            lblTitle.Location = new Point(111, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 32);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Update Product";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(26, 99);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(121, 25);
            lblProductCode.TabIndex = 7;
            lblProductCode.Text = "Product Code";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(29, 139);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 25);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(26, 183);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(80, 25);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(29, 227);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(44, 25);
            lblUnit.TabIndex = 10;
            lblUnit.Text = "Unit";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(29, 270);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(81, 25);
            lblUnitPrice.TabIndex = 11;
            lblUnitPrice.Text = "UnitPrice";
            // 
            // lblProductionDate
            // 
            lblProductionDate.AutoSize = true;
            lblProductionDate.Location = new Point(26, 319);
            lblProductionDate.Name = "lblProductionDate";
            lblProductionDate.Size = new Size(141, 25);
            lblProductionDate.TabIndex = 12;
            lblProductionDate.Text = "Production Date";
            // 
            // lblExpireDate
            // 
            lblExpireDate.AutoSize = true;
            lblExpireDate.Location = new Point(26, 373);
            lblExpireDate.Name = "lblExpireDate";
            lblExpireDate.Size = new Size(101, 25);
            lblExpireDate.TabIndex = 13;
            lblExpireDate.Text = "Expire Date";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(192, 270);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(182, 31);
            txtUnitPrice.TabIndex = 14;
            txtUnitPrice.TextChanged += Control_ValueChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(78, 36, 16);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(192, 436);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(171, 40);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Firebrick;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(29, 436);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 16;
            btnClose.Text = " Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(427, 502);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblExpireDate);
            Controls.Add(lblProductionDate);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblUnit);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategory);
            Controls.Add(lblProductCode);
            Controls.Add(lblTitle);
            Controls.Add(dtpExpireDate);
            Controls.Add(dtProductionDate);
            Controls.Add(cmbCategory);
            Controls.Add(cmbUnit);
            Controls.Add(txtProductCode);
            Controls.Add(txtQuantity);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateProductForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuantity;
        private TextBox txtProductCode;
        private ComboBox cmbUnit;
        private ComboBox cmbCategory;
        private DateTimePicker dtProductionDate;
        private DateTimePicker dtpExpireDate;
        private Label lblTitle;
        private Label lblProductCode;
        private Label lblCategory;
        private Label lblQuantity;
        private Label lblUnit;
        private Label lblUnitPrice;
        private Label lblProductionDate;
        private Label lblExpireDate;
        private TextBox txtUnitPrice;
        private Button btnSave;
        private Button btnClose;
    }
}