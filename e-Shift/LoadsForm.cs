using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift
{
    public partial class LoadsForm : Form
    {
        private List<LoadProduct> tempLoadProducts = new List<LoadProduct>();

        public LoadsForm()
        {
            InitializeComponent();
            LoadLoadsToGrid();
            dgvLoadProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadsForm_Load(object sender, EventArgs e)
        {
            // Load jobs with status 'Accepted'
            string jobQuery = "SELECT JobID FROM Jobs WHERE Status IN ('Accepted')";
            Data.FillComboBox(jobQuery, cmbJobID, "JobID", "JobID");

            // Load all products
            string productQuery = "SELECT ProductID, ProductName FROM Products";
            Data.FillComboBox(productQuery, cmbAddProduct, "ProductName", "ProductID");

            txtTotalWeight.Text = "0";
            cmbLoadStatus.Text = "Pending";

            LoadLoadStatusOptions();
            


        }

        private void LoadLoadStatusOptions()
        {
            cmbLoadStatus.Items.Clear();
            cmbLoadStatus.Items.Add("Pending");
            cmbLoadStatus.Items.Add("In Transit");
            cmbLoadStatus.Items.Add("Delivered");
            cmbLoadStatus.SelectedIndex = 0; 
        }

        private void btnAddToLoad_Click(object sender, EventArgs e)
        {
            if (cmbAddProduct.SelectedItem == null ||
                !int.TryParse(txtQuantity.Text, out int quantity) ||
                !decimal.TryParse(txtItemWeight.Text, out decimal weightPerUnit))
            {
                MessageBox.Show("Please enter valid product, quantity, and item weight.");
                return;
            }

            int productId = Convert.ToInt32(cmbAddProduct.SelectedValue);
            string productName = cmbAddProduct.Text;

            // Prevent duplicate product addition
            if (tempLoadProducts.Any(p => p.ProductID == productId))
            {
                MessageBox.Show("This product is already added to this load.");
                return;
            }

            // Create new LoadProduct entry
            var product = new LoadProduct
            {
                ProductID = productId,
                ProductName = productName,
                Quantity = quantity,
                WeightPerUnit = weightPerUnit
            };

            tempLoadProducts.Add(product);
            RefreshProductGrid();
        }

        private void RefreshProductGrid()
        {
            dgvLoadProducts.DataSource = null;
            dgvLoadProducts.DataSource = tempLoadProducts;

            txtTotalWeight.Text = tempLoadProducts.Sum(p => p.TotalWeight).ToString("0.##");
        }

        private void btnSaveLoad_Click(object sender, EventArgs e)
        {
            if (cmbJobID.SelectedItem == null || string.IsNullOrWhiteSpace(txtLoadDescription.Text))
            {
                MessageBox.Show("Please select a Job and enter a description.");
                return;
            }

            if (!tempLoadProducts.Any())
            {
                MessageBox.Show("Please add at least one product to the load.");
                return;
            }

            int jobId = Convert.ToInt32(cmbJobID.SelectedValue);
            string description = txtLoadDescription.Text;
            decimal totalWeight = tempLoadProducts.Sum(p => p.TotalWeight);

            // Save Load
            string loadSql = "INSERT INTO Loads (JobID, Description, TotalWeight, Status, CreatedAt) " +
                             "VALUES (@jobId, @description, @totalWeight, 'Pending', GETDATE()); " +
                             "SELECT SCOPE_IDENTITY();";

            int loadId;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(loadSql, con);
                cmd.Parameters.AddWithValue("@jobId", jobId);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@totalWeight", totalWeight);

                loadId = Convert.ToInt32(cmd.ExecuteScalar());

                // Update the Job status to 'In Progress' for the selected JobID
                string updateJobStatusSql = "UPDATE Jobs SET Status = @status WHERE JobID = @jobId";
                SqlCommand updateCmd = new SqlCommand(updateJobStatusSql, con);
                updateCmd.Parameters.AddWithValue("@status", "In Progress");
                updateCmd.Parameters.AddWithValue("@jobId", jobId);

                updateCmd.ExecuteNonQuery();
            }

            // Save LoadProducts
            foreach (var p in tempLoadProducts)
            {
                string lpSql = "INSERT INTO LoadProducts (LoadID, ProductID, Quantity, TotalWeight) " +
                               "VALUES (@loadId, @productId, @qty, @totalWeight)";
                SqlParameter[] lpParams = new SqlParameter[]
                {
                    new SqlParameter("@loadId", loadId),
                    new SqlParameter("@productId", p.ProductID),
                    new SqlParameter("@qty", p.Quantity),
                    new SqlParameter("@totalWeight", p.TotalWeight)
                };

                Data.ExecuteNonQuery(lpSql, lpParams);
            }

            MessageBox.Show("Load Created Successfully!");
            ClearLoadForm();
        }

        private void ClearLoadForm()
        {
            cmbJobID.SelectedIndex = -1;
            cmbAddProduct.SelectedIndex = -1;
            txtLoadDescription.Clear();
            txtQuantity.Clear();
            txtItemWeight.Clear();
            tempLoadProducts.Clear();
            RefreshProductGrid();
            txtTotalWeight.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLoadProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a load to delete.");
                return;
            }

            int loadId = Convert.ToInt32(dgvLoadProducts.SelectedRows[0].Cells["LoadID"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this load?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            // First delete associated LoadProducts
            Data.DeleteById("LoadProducts", "LoadID", loadId);

            // Then delete the Load itself
            Data.DeleteById("Loads", "LoadID", loadId);

            MessageBox.Show("Load deleted successfully!");

            LoadLoadsToGrid();
            ClearLoadForm();
        }

        private void LoadLoadsToGrid()
        {
            string query = "SELECT LoadID, JobID, Description, TotalWeight, Status FROM Loads";
            Data.LoadDataToGrid(query, dgvLoadProducts);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvLoadProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoadProducts.Rows[e.RowIndex];

                cmbJobID.SelectedValue = row.Cells["JobID"].Value;
                txtLoadDescription.Text = row.Cells["Description"].Value.ToString();
                cmbLoadStatus.Text = row.Cells["Status"].Value.ToString();
                txtTotalWeight.Text = row.Cells["TotalWeight"].Value.ToString();

                // Optionally, fetch and load associated products
                int loadId = Convert.ToInt32(row.Cells["LoadID"].Value);
                LoadProductsForLoad(loadId);
            }
        }

        private void LoadProductsForLoad(int loadId)
        {
            tempLoadProducts.Clear();

            string query = @"
                SELECT 
                    lp.ProductID, 
                    p.ProductName, 
                    lp.Quantity, 
                    lp.TotalWeight,
                    l.JobID,
                    l.Description,
                    l.Status,
                    l.LoadID
                    FROM LoadProducts lp
                INNER JOIN Products p 
                ON lp.ProductID = p.ProductID
                INNER JOIN Loads l
                ON lp.LoadID = l.LoadID
                WHERE lp.LoadID = @loadId";

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString()))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@loadId", loadId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tempLoadProducts.Add(new LoadProduct
                    {
                        JobID = Convert.ToInt32(reader["JobID"]),
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        LoadID = Convert.ToInt32(reader["LoadID"]),
                        ProductName = reader["ProductName"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        WeightPerUnit = Convert.ToDecimal(reader["TotalWeight"]) / Convert.ToInt32(reader["Quantity"]),
                        Description = reader["Description"].ToString(),
                        Status = reader["Status"].ToString()
                    });
                }
            }

            RefreshProductGrid();
        }

        private void cmbLoadStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
