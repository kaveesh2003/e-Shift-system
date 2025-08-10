using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift
{
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            Data.LoadTableToGrid("Customers", dgvManageCustomer);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string[] columnsToSearch = { "FullName", "Mobile", "NIC", "Email" };

            DataTable result = Data.SearchMultipleColumns("Customers", columnsToSearch, searchText);
            dgvManageCustomer.DataSource = result;
        }

        private void dgvManageCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var mapping = new Dictionary<TextBox, string>
            {
                { txtUserId, "UserID" },
                { txtFullName, "FullName" },
                { txtNic, "NIC" },
                { txtEmail, "Email" },
                { txtMobile, "Mobile" },
                { txtAddress, "Address" },
                { txtCity, "City" },
                { txtAge, "Age" }
            };

            Data.FillTextBoxesFromGrid(dgvManageCustomer, e.RowIndex, mapping);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "FullName", txtFullName.Text },
                { "NIC", txtNic.Text },
                { "Email", txtEmail.Text },
                { "Mobile", txtMobile.Text },
                { "Address", txtAddress.Text },
                { "City", txtCity.Text },
                { "Age", int.Parse(txtAge.Text) }
            };

            // Call the common update method
            Data.UpdateRecord("Customers", "UserID", int.Parse(txtUserId.Text), data);

            LoadCustomerData();

            MessageBox.Show("Customer details updated successfully.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvManageCustomer.SelectedRows.Count > 0)
            {
                // Get the selected UserID
                int userId = Convert.ToInt32(dgvManageCustomer.SelectedRows[0].Cells["UserID"].Value);

                // Confirm before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Call the common delete method
                    Data.DeleteById("Customers", "UserID", userId);
                    Data.DeleteById("Users", "UserID", userId);

                    MessageBox.Show("Customer deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCustomerData(); 
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadCustomerData()
        {
            string query = @"
                SELECT 
                    u.UserID,
                    u.Username,
                    c.FullName,
                    c.NIC,
                    c.Email,
                    c.Mobile,
                    c.Address,
                    c.City,
                    c.Age
                FROM Users u
                INNER JOIN Customers c ON u.UserID = c.UserID
                WHERE u.Role = 'Customer'";

            Data.LoadDataToGrid(query, dgvManageCustomer);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadCustomerData(); 
            }
        }
    }
}
