namespace Cinnova.Forms
{
    partial class FarmerForm
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
            tabPage2 = new TabPage();
            pnlPurchasePrint = new Panel();
            btnPrintPurchase = new Button();
            picPurchasePrint = new PictureBox();
            panel5 = new Panel();
            label13 = new Label();
            label2 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label12 = new Label();
            pnlTotalPurchases = new Panel();
            lblTotalPurchases = new Label();
            label6 = new Label();
            dgvPurchases = new DataGridView();
            pnlPurchaseCard = new Panel();
            Delete = new Button();
            btnSavePurchase = new Button();
            btnCalculate = new Button();
            dateTimePicker2 = new DateTimePicker();
            txtCost = new TextBox();
            txtPriceKg = new TextBox();
            txtQuantityKg = new TextBox();
            combofarmer = new ComboBox();
            cmbFarmer = new Label();
            dtpPurchaseDate = new Label();
            txtTotal = new Label();
            txtPrice = new Label();
            txtQuantity = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnDelete = new Button();
            btnAdd = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            dtpDateAdded = new Label();
            textBox1 = new TextBox();
            txtLocation = new Label();
            txtContact = new Label();
            txtFullName = new Label();
            dgvFarmers = new DataGridView();
            label4 = new Label();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            picPrint = new PictureBox();
            btnPrintFarmers = new Button();
            panel2 = new Panel();
            label9 = new Label();
            label10 = new Label();
            pnlBanner = new Panel();
            label8 = new Label();
            label7 = new Label();
            pnlTotalFarmers = new Panel();
            lblTotalNumber = new Label();
            label5 = new Label();
            tabControl1 = new TabControl();
            sidebarControl1 = new SidebarControl();
            printDocumentFarmers = new System.Drawing.Printing.PrintDocument();
            printDocumentPurchases = new System.Drawing.Printing.PrintDocument();
            tabPage2.SuspendLayout();
            pnlPurchasePrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPurchasePrint).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            pnlTotalPurchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchases).BeginInit();
            pnlPurchaseCard.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFarmers).BeginInit();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPrint).BeginInit();
            panel2.SuspendLayout();
            pnlBanner.SuspendLayout();
            pnlTotalFarmers.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 247, 237);
            tabPage2.Controls.Add(pnlPurchasePrint);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(pnlTotalPurchases);
            tabPage2.Controls.Add(dgvPurchases);
            tabPage2.Controls.Add(pnlPurchaseCard);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(692, 552);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Purchases";
            // 
            // pnlPurchasePrint
            // 
            pnlPurchasePrint.BackColor = Color.White;
            pnlPurchasePrint.Controls.Add(btnPrintPurchase);
            pnlPurchasePrint.Controls.Add(picPurchasePrint);
            pnlPurchasePrint.Location = new Point(265, 135);
            pnlPurchasePrint.Name = "pnlPurchasePrint";
            pnlPurchasePrint.Size = new Size(185, 35);
            pnlPurchasePrint.TabIndex = 22;
            // 
            // btnPrintPurchase
            // 
            btnPrintPurchase.BackColor = Color.FromArgb(78, 36, 16);
            btnPrintPurchase.FlatStyle = FlatStyle.Flat;
            btnPrintPurchase.ForeColor = Color.White;
            btnPrintPurchase.Location = new Point(63, 5);
            btnPrintPurchase.Name = "btnPrintPurchase";
            btnPrintPurchase.Size = new Size(75, 23);
            btnPrintPurchase.TabIndex = 1;
            btnPrintPurchase.Text = "Print";
            btnPrintPurchase.UseVisualStyleBackColor = false;
            btnPrintPurchase.Click += btnPrintPurchase_Click;
            // 
            // picPurchasePrint
            // 
            picPurchasePrint.Image = Properties.Resources.photo_2026_07_05_20_52_40__2_2;
            picPurchasePrint.Location = new Point(21, 8);
            picPurchasePrint.Name = "picPurchasePrint";
            picPurchasePrint.Size = new Size(20, 20);
            picPurchasePrint.SizeMode = PictureBoxSizeMode.Zoom;
            picPurchasePrint.TabIndex = 0;
            picPurchasePrint.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(76, 38, 16);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(465, 33);
            panel5.Name = "panel5";
            panel5.Size = new Size(187, 98);
            panel5.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 24F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(27, 7);
            label13.Name = "label13";
            label13.Size = new Size(37, 45);
            label13.TabIndex = 23;
            label13.Text = "1";
            label13.Click += label13_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 52);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 22;
            label2.Text = "Total Purchases";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F);
            label11.ForeColor = Color.FromArgb(78, 36, 16);
            label11.Location = new Point(6, 0);
            label11.Name = "label11";
            label11.Size = new Size(234, 30);
            label11.TabIndex = 17;
            label11.Text = "Purchase Management";
            label11.Click += label11_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(3, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(447, 98);
            panel4.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(78, 36, 16);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(308, 32);
            label3.TabIndex = 19;
            label3.Text = "Purchase Tracking System";
            label3.Click += label3_Click_3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(6, 41);
            label12.Name = "label12";
            label12.Size = new Size(310, 30);
            label12.TabIndex = 18;
            label12.Text = "Manage and record cinnamon purchases from registered \r\nfarmers across the Southern Province.";
            label12.Click += label12_Click;
            // 
            // pnlTotalPurchases
            // 
            pnlTotalPurchases.BackColor = Color.FromArgb(76, 38, 16);
            pnlTotalPurchases.Controls.Add(lblTotalPurchases);
            pnlTotalPurchases.Controls.Add(label6);
            pnlTotalPurchases.Location = new Point(760, 70);
            pnlTotalPurchases.Name = "pnlTotalPurchases";
            pnlTotalPurchases.Size = new Size(180, 100);
            pnlTotalPurchases.TabIndex = 16;
            // 
            // lblTotalPurchases
            // 
            lblTotalPurchases.AutoSize = true;
            lblTotalPurchases.Font = new Font("Segoe UI", 22F);
            lblTotalPurchases.ForeColor = Color.White;
            lblTotalPurchases.Location = new Point(20, 15);
            lblTotalPurchases.Name = "lblTotalPurchases";
            lblTotalPurchases.Size = new Size(34, 41);
            lblTotalPurchases.TabIndex = 17;
            lblTotalPurchases.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 65);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 17;
            label6.Text = "TOTAL PURCHASES";
            // 
            // dgvPurchases
            // 
            dgvPurchases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchases.BackgroundColor = Color.White;
            dgvPurchases.BorderStyle = BorderStyle.None;
            dgvPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchases.Location = new Point(265, 173);
            dgvPurchases.Name = "dgvPurchases";
            dgvPurchases.ReadOnly = true;
            dgvPurchases.RowHeadersVisible = false;
            dgvPurchases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPurchases.Size = new Size(403, 332);
            dgvPurchases.TabIndex = 13;
            dgvPurchases.CellContentClick += dgvPurchases_CellContentClick;
            // 
            // pnlPurchaseCard
            // 
            pnlPurchaseCard.BackColor = Color.White;
            pnlPurchaseCard.BorderStyle = BorderStyle.FixedSingle;
            pnlPurchaseCard.Controls.Add(Delete);
            pnlPurchaseCard.Controls.Add(btnSavePurchase);
            pnlPurchaseCard.Controls.Add(btnCalculate);
            pnlPurchaseCard.Controls.Add(dateTimePicker2);
            pnlPurchaseCard.Controls.Add(txtCost);
            pnlPurchaseCard.Controls.Add(txtPriceKg);
            pnlPurchaseCard.Controls.Add(txtQuantityKg);
            pnlPurchaseCard.Controls.Add(combofarmer);
            pnlPurchaseCard.Controls.Add(cmbFarmer);
            pnlPurchaseCard.Controls.Add(dtpPurchaseDate);
            pnlPurchaseCard.Controls.Add(txtTotal);
            pnlPurchaseCard.Controls.Add(txtPrice);
            pnlPurchaseCard.Controls.Add(txtQuantity);
            pnlPurchaseCard.Controls.Add(label1);
            pnlPurchaseCard.Location = new Point(3, 137);
            pnlPurchaseCard.Name = "pnlPurchaseCard";
            pnlPurchaseCard.Size = new Size(256, 367);
            pnlPurchaseCard.TabIndex = 14;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(78, 36, 16);
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.ForeColor = Color.White;
            Delete.Location = new Point(184, 307);
            Delete.Name = "Delete";
            Delete.Size = new Size(59, 23);
            Delete.TabIndex = 26;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // btnSavePurchase
            // 
            btnSavePurchase.BackColor = Color.FromArgb(78, 36, 16);
            btnSavePurchase.FlatStyle = FlatStyle.Flat;
            btnSavePurchase.ForeColor = Color.White;
            btnSavePurchase.Location = new Point(83, 307);
            btnSavePurchase.Name = "btnSavePurchase";
            btnSavePurchase.Size = new Size(95, 23);
            btnSavePurchase.TabIndex = 25;
            btnSavePurchase.Text = "Save Purchase";
            btnSavePurchase.UseVisualStyleBackColor = false;
            btnSavePurchase.Click += btnSavePurchase_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(78, 36, 16);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 9F);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(2, 307);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 21;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(22, 257);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(214, 23);
            dateTimePicker2.TabIndex = 23;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(22, 202);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(166, 23);
            txtCost.TabIndex = 22;
            // 
            // txtPriceKg
            // 
            txtPriceKg.Location = new Point(22, 142);
            txtPriceKg.Name = "txtPriceKg";
            txtPriceKg.Size = new Size(169, 23);
            txtPriceKg.TabIndex = 21;
            // 
            // txtQuantityKg
            // 
            txtQuantityKg.Location = new Point(22, 89);
            txtQuantityKg.Name = "txtQuantityKg";
            txtQuantityKg.Size = new Size(169, 23);
            txtQuantityKg.TabIndex = 20;
            // 
            // combofarmer
            // 
            combofarmer.FormattingEnabled = true;
            combofarmer.Location = new Point(22, 35);
            combofarmer.Name = "combofarmer";
            combofarmer.Size = new Size(169, 23);
            combofarmer.TabIndex = 19;
            // 
            // cmbFarmer
            // 
            cmbFarmer.AutoSize = true;
            cmbFarmer.Location = new Point(22, 17);
            cmbFarmer.Name = "cmbFarmer";
            cmbFarmer.Size = new Size(78, 15);
            cmbFarmer.TabIndex = 18;
            cmbFarmer.Text = "Select Farmer";
            cmbFarmer.Click += cmbFarmer_Click;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.AutoSize = true;
            dtpPurchaseDate.Location = new Point(25, 239);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(82, 15);
            dtpPurchaseDate.TabIndex = 17;
            dtpPurchaseDate.Text = "Purchase Date";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(25, 184);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(59, 15);
            txtTotal.TabIndex = 16;
            txtTotal.Text = "Total Cost";
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Location = new Point(25, 124);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(70, 15);
            txtPrice.TabIndex = 15;
            txtPrice.Text = "Price Per Kg";
            // 
            // txtQuantity
            // 
            txtQuantity.AutoSize = true;
            txtQuantity.Location = new Point(22, 71);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(75, 15);
            txtQuantity.TabIndex = 14;
            txtQuantity.Text = "Quantity(Kg)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-6, 93);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(dtpDateAdded);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txtLocation);
            panel1.Controls.Add(txtContact);
            panel1.Controls.Add(txtFullName);
            panel1.Location = new Point(6, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 367);
            panel1.TabIndex = 24;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(78, 36, 16);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(140, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete Farmer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDeleteFarmer_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(78, 36, 16);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(20, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add Farmer";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F);
            dateTimePicker1.Location = new Point(20, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F);
            textBox3.Location = new Point(20, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 23);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F);
            textBox2.Location = new Point(20, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 23);
            textBox2.TabIndex = 17;
            // 
            // dtpDateAdded
            // 
            dtpDateAdded.AutoSize = true;
            dtpDateAdded.Font = new Font("Segoe UI", 10F);
            dtpDateAdded.Location = new Point(20, 225);
            dtpDateAdded.Name = "dtpDateAdded";
            dtpDateAdded.Size = new Size(106, 19);
            dtpDateAdded.TabIndex = 20;
            dtpDateAdded.Text = "Registered Date";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(20, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 16;
            // 
            // txtLocation
            // 
            txtLocation.AutoSize = true;
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.Location = new Point(20, 160);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(61, 19);
            txtLocation.TabIndex = 15;
            txtLocation.Text = "Location";
            // 
            // txtContact
            // 
            txtContact.AutoSize = true;
            txtContact.Font = new Font("Segoe UI", 10F);
            txtContact.Location = new Point(20, 95);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(119, 19);
            txtContact.TabIndex = 14;
            txtContact.Text = "Contact  Number ";
            // 
            // txtFullName
            // 
            txtFullName.AutoSize = true;
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.Location = new Point(20, 30);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(92, 19);
            txtFullName.TabIndex = 13;
            txtFullName.Text = "Farmer Name";
            txtFullName.Click += txtFullName_Click;
            // 
            // dgvFarmers
            // 
            dgvFarmers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFarmers.BackgroundColor = Color.White;
            dgvFarmers.BorderStyle = BorderStyle.None;
            dgvFarmers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFarmers.EnableHeadersVisualStyles = false;
            dgvFarmers.Location = new Point(292, 196);
            dgvFarmers.MultiSelect = false;
            dgvFarmers.Name = "dgvFarmers";
            dgvFarmers.ReadOnly = true;
            dgvFarmers.RowHeadersVisible = false;
            dgvFarmers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFarmers.Size = new Size(383, 324);
            dgvFarmers.TabIndex = 23;
            dgvFarmers.CellContentClick += dgvFarmers_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.FromArgb(78, 36, 16);
            label4.Location = new Point(9, 3);
            label4.Name = "label4";
            label4.Size = new Size(216, 30);
            label4.TabIndex = 0;
            label4.Text = "Farmer Management";
            label4.Click += label4_Click_2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 247, 237);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(pnlBanner);
            tabPage1.Controls.Add(pnlTotalFarmers);
            tabPage1.Controls.Add(dgvFarmers);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(692, 552);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Farmer Management";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(picPrint);
            panel3.Controls.Add(btnPrintFarmers);
            panel3.Location = new Point(524, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 52);
            panel3.TabIndex = 30;
            // 
            // picPrint
            // 
            picPrint.BackColor = Color.White;
            picPrint.Image = Properties.Resources.photo_2026_07_05_20_52_40__2_;
            picPrint.Location = new Point(12, 17);
            picPrint.Name = "picPrint";
            picPrint.Size = new Size(20, 20);
            picPrint.SizeMode = PictureBoxSizeMode.Zoom;
            picPrint.TabIndex = 31;
            picPrint.TabStop = false;
            // 
            // btnPrintFarmers
            // 
            btnPrintFarmers.BackColor = Color.FromArgb(78, 36, 16);
            btnPrintFarmers.FlatStyle = FlatStyle.Flat;
            btnPrintFarmers.ForeColor = Color.White;
            btnPrintFarmers.Location = new Point(47, 7);
            btnPrintFarmers.Name = "btnPrintFarmers";
            btnPrintFarmers.Size = new Size(75, 33);
            btnPrintFarmers.TabIndex = 23;
            btnPrintFarmers.Text = "Print";
            btnPrintFarmers.UseVisualStyleBackColor = false;
            btnPrintFarmers.Click += btnPrintFarmers_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(292, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 50);
            panel2.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.FromArgb(76, 38, 16);
            label9.Location = new Point(3, 2);
            label9.Name = "label9";
            label9.Size = new Size(127, 21);
            label9.TabIndex = 27;
            label9.Text = "Farmer Directory";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(3, 23);
            label10.Name = "label10";
            label10.Size = new Size(208, 15);
            label10.TabIndex = 28;
            label10.Text = "Showing registered cinnamon farmers";
            label10.Click += label10_Click;
            // 
            // pnlBanner
            // 
            pnlBanner.BackColor = Color.White;
            pnlBanner.Controls.Add(label8);
            pnlBanner.Controls.Add(label7);
            pnlBanner.Location = new Point(6, 36);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(447, 98);
            pnlBanner.TabIndex = 26;
            pnlBanner.Paint += pnlBanner_Paint;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 8F);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(3, 45);
            label8.Name = "label8";
            label8.Size = new Size(324, 36);
            label8.TabIndex = 30;
            label8.Text = "Manage and nurture relationships with our network of over 450 certified cinnamon farmers across the southern province.";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(76, 38, 16);
            label7.Location = new Point(3, 6);
            label7.Name = "label7";
            label7.Size = new Size(422, 39);
            label7.TabIndex = 29;
            label7.Text = "Sustainable Farmer Network";
            label7.Click += label7_Click;
            // 
            // pnlTotalFarmers
            // 
            pnlTotalFarmers.BackColor = Color.FromArgb(76, 38, 16);
            pnlTotalFarmers.Controls.Add(lblTotalNumber);
            pnlTotalFarmers.Controls.Add(label5);
            pnlTotalFarmers.Location = new Point(459, 36);
            pnlTotalFarmers.Name = "pnlTotalFarmers";
            pnlTotalFarmers.Size = new Size(187, 98);
            pnlTotalFarmers.TabIndex = 25;
            pnlTotalFarmers.Paint += pnlTotalFarmers_Paint;
            // 
            // lblTotalNumber
            // 
            lblTotalNumber.AutoSize = true;
            lblTotalNumber.Font = new Font("Segoe UI", 24F);
            lblTotalNumber.ForeColor = Color.White;
            lblTotalNumber.Location = new Point(20, 6);
            lblTotalNumber.Name = "lblTotalNumber";
            lblTotalNumber.Size = new Size(37, 45);
            lblTotalNumber.TabIndex = 28;
            lblTotalNumber.Text = "1";
            lblTotalNumber.Click += lblTotalNumber_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 62);
            label5.Name = "label5";
            label5.Size = new Size(158, 19);
            label5.TabIndex = 27;
            label5.Text = "TOTAL ACTIVE FARMERS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(200, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 580);
            tabControl1.TabIndex = 0;
            // 
            // sidebarControl1
            // 
            sidebarControl1.BackColor = Color.FromArgb(76, 38, 16);
            sidebarControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sidebarControl1.Location = new Point(-2, 0);
            sidebarControl1.Name = "sidebarControl1";
            sidebarControl1.Size = new Size(200, 580);
            sidebarControl1.TabIndex = 1;
            // 
            // printDocumentFarmers
            // 
            printDocumentFarmers.PrintPage += printDocumentFarmers_PrintPage;
            // 
            // printDocumentPurchases
            // 
            printDocumentPurchases.PrintPage += printDocumentPurchases_PrintPage;
            // 
            // FarmerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(884, 541);
            Controls.Add(sidebarControl1);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "FarmerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmer Management";
            Load += FarmerForm_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pnlPurchasePrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPurchasePrint).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnlTotalPurchases.ResumeLayout(false);
            pnlTotalPurchases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchases).EndInit();
            pnlPurchaseCard.ResumeLayout(false);
            pnlPurchaseCard.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFarmers).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPrint).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlBanner.ResumeLayout(false);
            pnlTotalFarmers.ResumeLayout(false);
            pnlTotalFarmers.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private DataGridView dgvPurchases;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private Label label4;
        private Panel panel1;
        private DataGridView dgvFarmers;
        private Button btnDelete;
        private Button btnAdd;
        private Label dtpDateAdded;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label txtLocation;
        private Label txtContact;
        private Label txtFullName;
        private Panel pnlBanner;
        private Panel pnlTotalFarmers;
        private Label label5;
        private Label lblTotalNumber;
        private Label label7;
        private Label label8;
        private Panel pnlPurchaseCard;
        private Button btnSavePurchase;
        private Button btnCalculate;
        private DateTimePicker dateTimePicker2;
        private TextBox txtCost;
        private TextBox txtPriceKg;
        private TextBox txtQuantityKg;
        private ComboBox combofarmer;
        private Label cmbFarmer;
        private Label dtpPurchaseDate;
        private Label txtTotal;
        private Label txtPrice;
        private Label txtQuantity;
        private Label label1;
        private Label label6;
        private Panel pnlTotalPurchases;
        private Label lblTotalPurchases;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private SidebarControl sidebarControl1;
        private Panel panel2;
        private Button Delete;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private Label label2;
        private Label label13;
        private Button btnPrintFarmers;
        private System.Drawing.Printing.PrintDocument printDocumentFarmers;
        private Panel panel3;
        private PictureBox picPrint;
        private Panel pnlPurchasePrint;
        private PictureBox picPurchasePrint;
        private Button btnPrintPurchase;
        private System.Drawing.Printing.PrintDocument printDocumentPurchases;
    }
}