using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using Cinnova.Database;

namespace Cinnova.Forms
{
    public partial class UpdateProductForm : Form
    {
        private int productionID;
        private string productCode = "";
        private string productType = "";
        private decimal quantity;
        private string unit = "";
        private decimal unitPrice;
        private DateTime productionDate;
        private DateTime expireDate;

        private bool isChanged = false;

        // Default constructor (Designer ekata one)
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        // Data pass karana constructor
        public UpdateProductForm(
            int id,
            string code,
            string type,
            decimal qty,
            string unitName,
            decimal price,
            DateTime pDate,
            DateTime eDate)
        {
            InitializeComponent();

            productionID = id;
            productCode = code;
            productType = type;
            quantity = qty;
            unit = unitName;
            unitPrice = price;
            productionDate = pDate;
            expireDate = eDate;

            LoadFormData();
        }

        private void LoadFormData()
        {
            txtProductCode.Text = productCode;

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Cinnamon Sticks");
            cmbCategory.Items.Add("Cinnamon Powder");
            cmbCategory.Items.Add("Cinnamon Oil");
            cmbCategory.Text = productType;

            txtQuantity.Text = quantity.ToString();

            cmbUnit.Items.Clear();
            cmbUnit.Items.Add("Kg");
            cmbUnit.Items.Add("L");
            cmbUnit.Text = unit;

            txtUnitPrice.Text = unitPrice.ToString();

            dtProductionDate.Value = productionDate;
            dtpExpireDate.Value = expireDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                cmbUnit.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            string query = @"
UPDATE Production
SET ProductType=@ProductType,
    QuantityKg=@QuantityKg,
    Unit=@Unit,
    PricePerUnit=@PricePerUnit,
    ProductionDate=@ProductionDate,
    ExpireDate=@ExpireDate
WHERE ProductionID=@ProductionID";

            bool success = DatabaseHelper.ExecuteNonQuery(
                query,

                new SqlParameter("@ProductType", cmbCategory.Text),
                new SqlParameter("@QuantityKg", decimal.Parse(txtQuantity.Text)),
                new SqlParameter("@Unit", cmbUnit.Text),
                new SqlParameter("@PricePerUnit", decimal.Parse(txtUnitPrice.Text)),
                new SqlParameter("@ProductionDate", dtProductionDate.Value.Date),
                new SqlParameter("@ExpireDate", dtpExpireDate.Value.Date),
                new SqlParameter("@ProductionID", productionID)
            );

            if (success)
            {
                MessageBox.Show("Record updated successfully!");

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void Control_ValueChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!isChanged)
            {
                this.Close();
                return;
            }

            DialogResult result = MessageBox.Show(
                "You have unsaved changes.\n\nDo you want to save before closing?",
                "Unsaved Changes",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                btnSave.PerformClick();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
            // Cancel karoth mokuth wenne na.
        
    }
    }
}