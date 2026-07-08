namespace Cinnova.Forms
{
    partial class ProductrecordForm
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
            pnlhead = new Panel();
            lblProductHistory = new Label();
            btnBack = new Button();
            dgvProductionHistory = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExportPDF = new Button();
            lblcategorysrch = new Label();
            cmbCategoryFilter = new ComboBox();
            btnSearch = new Button();
            pnlhead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductionHistory).BeginInit();
            SuspendLayout();
            // 
            // pnlhead
            // 
            pnlhead.BackColor = Color.FromArgb(78, 36, 16);
            pnlhead.Controls.Add(lblProductHistory);
            pnlhead.Controls.Add(btnBack);
            pnlhead.Location = new Point(0, 0);
            pnlhead.Name = "pnlhead";
            pnlhead.Size = new Size(876, 78);
            pnlhead.TabIndex = 0;
            // 
            // lblProductHistory
            // 
            lblProductHistory.AutoSize = true;
            lblProductHistory.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductHistory.ForeColor = Color.White;
            lblProductHistory.Location = new Point(308, 18);
            lblProductHistory.Name = "lblProductHistory";
            lblProductHistory.Size = new Size(315, 45);
            lblProductHistory.TabIndex = 1;
            lblProductHistory.Text = "Production Records";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(78, 36, 16);
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 0;
            btnBack.Text = "<< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvProductionHistory
            // 
            dgvProductionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductionHistory.Location = new Point(24, 157);
            dgvProductionHistory.Name = "dgvProductionHistory";
            dgvProductionHistory.ReadOnly = true;
            dgvProductionHistory.RowHeadersWidth = 62;
            dgvProductionHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductionHistory.Size = new Size(830, 300);
            dgvProductionHistory.TabIndex = 2;
            dgvProductionHistory.CellClick += dgvProductionHistory_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.AccessibleName = "btnDelete";
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(138, 477);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(78, 36, 16);
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(308, 481);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += this.btnUpdate_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.DarkGoldenrod;
            btnExportPDF.Location = new Point(663, 475);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(153, 40);
            btnExportPDF.TabIndex = 5;
            btnExportPDF.Text = "Export PDF >>";
            btnExportPDF.UseVisualStyleBackColor = false;
            // 
            // lblcategorysrch
            // 
            lblcategorysrch.AutoSize = true;
            lblcategorysrch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcategorysrch.Location = new Point(169, 118);
            lblcategorysrch.Name = "lblcategorysrch";
            lblcategorysrch.Size = new Size(98, 28);
            lblcategorysrch.TabIndex = 7;
            lblcategorysrch.Text = "Category";
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Items.AddRange(new object[] { "All", "Cinnamon Sticks", "Cinnamon Powder", "Cinnamon Oil" });
            cmbCategoryFilter.Location = new Point(294, 118);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(180, 33);
            cmbCategoryFilter.TabIndex = 9;
            cmbCategoryFilter.SelectedIndexChanged += cmbCategoryFilter_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(540, 115);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ProductrecordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 524);
            Controls.Add(btnSearch);
            Controls.Add(cmbCategoryFilter);
            Controls.Add(lblcategorysrch);
            Controls.Add(btnExportPDF);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvProductionHistory);
            Controls.Add(pnlhead);
            Name = "ProductrecordForm";
            Text = "ProductecordForm";
            Load += ProductrecordForm_Load;
            pnlhead.ResumeLayout(false);
            pnlhead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductionHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlhead;
        private Label lblProductHistory;
        private Button btnBack;
        private DataGridView dgvProductionHistory;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExportPDF;
        private Label lblcategorysrch;
        private ComboBox cmbCategoryFilter;
        private Button btnSearch;
    }
}