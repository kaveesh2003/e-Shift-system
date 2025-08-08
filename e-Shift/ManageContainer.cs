using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift
{
    public partial class ManageContainer : Form
    {
        public ManageContainer()
        {
            InitializeComponent();
        }

        private void ManageContainer_Load(object sender, EventArgs e)
        {
            LoadContainers();

            cmbType.Items.AddRange(new string[] { "Small", "Medium", "Large" });
            cmbAvailability.Items.AddRange(new string[] { "Available", "On Job", "Unavailable" });

            cmbType.SelectedIndex = 0;
            cmbAvailability.SelectedIndex = 0;
        }

        private void LoadContainers()
        {
            string query = "SELECT * FROM Containers";
            Data.LoadDataToGrid(query, dgvContainers);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Containers (ContainerCode, SizeType, Availability) VALUES (@code, @size, @availability)";
            SqlParameter[] parameters = {
                new SqlParameter("@code", txtContainerCode.Text),
                new SqlParameter("@size", cmbType.SelectedItem?.ToString()),
                new SqlParameter("@availability", cmbAvailability.SelectedItem?.ToString())
            };

            try
            {
                Data.ExecuteNonQuery(sql, parameters);
                MessageBox.Show("Container saved successfully!");
                LoadContainers();
                ClearFields();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtContainerCode.Clear();
            cmbType.SelectedIndex = -1;       
            cmbAvailability.SelectedIndex = -1;   

            txtContainerCode.Focus();             
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtContainerID.Text, out int id))
            {
                var data = new Dictionary<string, object>
                {
                    { "ContainerCode", txtContainerCode.Text },
                    { "SizeType", cmbType.SelectedItem?.ToString() },
                    { "Availability", cmbAvailability.SelectedItem?.ToString() }
                };

                try
                {
                    Data.UpdateRecord("Containers", "ContainerID", id, data);
                    MessageBox.Show("Container updated successfully!");
                    LoadContainers();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid container to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtContainerID.Text, out int id))
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this container?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Data.DeleteById("Containers", "ContainerID", id);
                    MessageBox.Show("Container deleted.");
                    LoadContainers();
                }
            }
            else
            {
                MessageBox.Show("Please select a valid container to delete.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string[] columns = { "ContainerCode", "SizeType", "Availability" };

            DataTable results = Data.SearchMultipleColumns("Containers", columns, searchText);
            dgvContainers.DataSource = results;
        }

        private void dgvContainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvContainers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mapping = new Dictionary<TextBox, string>
                {
                    { txtContainerID, "ContainerID" },
                    { txtContainerCode, "ContainerCode" }
                };

                Data.FillTextBoxesFromGrid(dgvContainers, e.RowIndex, mapping);

                // Set combo boxes
                cmbType.SelectedItem = dgvContainers.Rows[e.RowIndex].Cells["SizeType"].Value?.ToString();
                cmbAvailability.SelectedItem = dgvContainers.Rows[e.RowIndex].Cells["Availability"].Value?.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadContainers();
            }
        }
    }
}
