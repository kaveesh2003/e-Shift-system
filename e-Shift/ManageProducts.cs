using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || cmbWeightClass.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields (Product Name and Weight Class).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "INSERT INTO Products (ProductName, WeightClass, Description, ProductType) VALUES (@ProductName, @WeightClass, @Description, @ProductType)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductName", txtProductName.Text),
                new SqlParameter("@WeightClass", cmbWeightClass.SelectedItem.ToString()),
                new SqlParameter("@Description", txtDescription.Text), 
                new SqlParameter("@ProductType", cmbProductType.SelectedItem.ToString())  
            };
            try
            {
                Data.ExecuteNonQuery(sql, parameters);
                MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();     
                LoadProductData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            cmbWeightClass.SelectedIndex = -1;
            txtDescription.Clear();
            cmbProductType.SelectedIndex = -1; 
        }

        private void LoadProductData()
        {
            string sql = "SELECT * FROM Products";
            DataTable dt = Data.GetDataTable(sql, new SqlParameter[0]); 
            dgvManageProducts.DataSource = dt;
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            PopulateWeightClassCombo();
            PopulateProductTypeCombo();

            Data.LoadTableToGrid("Products", dgvManageProducts);
        }

        private void PopulateWeightClassCombo()
        {
            cmbWeightClass.Items.Clear();
            cmbWeightClass.Items.Add("Light");
            cmbWeightClass.Items.Add("Medium");
            cmbWeightClass.Items.Add("Heavy");
        }

        private void PopulateProductTypeCombo()
        {
            cmbProductType.Items.Clear();

            cmbProductType.Items.Add("Furniture");
            cmbProductType.Items.Add("Appliances");
            cmbProductType.Items.Add("Electronics");
            cmbProductType.Items.Add("Kitchenware & Utensils");
            cmbProductType.Items.Add("Clothing & Personal Items");
            cmbProductType.Items.Add("Books & Documents");
            cmbProductType.Items.Add("Decor & Fragile Items");
            cmbProductType.Items.Add("Bedding & Linens");
            cmbProductType.Items.Add("Toys & Kids’ Items");
            cmbProductType.Items.Add("Outdoor & Garden Items");
            cmbProductType.Items.Add("Miscellaneous");

            cmbProductType.SelectedIndex = 0;
        }

        private void dgvManageProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvManageProducts.Rows[e.RowIndex];

                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                cmbWeightClass.SelectedItem = row.Cells["WeightClass"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                cmbProductType.SelectedItem = row.Cells["ProductType"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtProductID.Text);
            string name = txtProductName.Text;
            string weight = cmbWeightClass.SelectedItem.ToString();
            string description = txtDescription.Text;
            string type = cmbProductType.SelectedItem.ToString();

            string sql = "UPDATE Products SET ProductName = @name, WeightClass = @weight, Description = @desc, ProductType = @type WHERE ProductID = @id";

            SqlParameter[] parameters = {
                new SqlParameter("@name", name),
                new SqlParameter("@weight", weight),
                new SqlParameter("@desc", description),
                new SqlParameter("@type", type),
                new SqlParameter("@id", productId)
             };

            Data.ExecuteNonQuery(sql, parameters);
            MessageBox.Show("Product details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProductData();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int productId = int.Parse(txtProductID.Text);
                    Data.DeleteById("Products", "ProductID", productId);

                    MessageBox.Show("Product deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductData(); 
                    ClearFields();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            // Check if user entered something
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            // Define the columns to search
            string[] columnsToSearch = { "ProductName", "WeightClass", "ProductType" };

            // Call your Data class method
            DataTable result = Data.SearchMultipleColumns("Products", columnsToSearch, searchText);

            // Bind results to DataGridView
            dgvManageProducts.DataSource = result;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadProductData();
            }
        }
    }
}
