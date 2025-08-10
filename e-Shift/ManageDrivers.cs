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
    public partial class ManageDrivers : Form
    {
        public ManageDrivers()
        {
            InitializeComponent();

            DriverAvailabilityCombo();
            Data.LoadTableToGrid("Drivers", dgvDrivers);
        }

        private void DriverAvailabilityCombo()
        {
            cmbAvailability.Items.Clear();
            cmbAvailability.Items.Add("Available");
            cmbAvailability.Items.Add("On Job");
            cmbAvailability.Items.Add("Unavailable");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO Drivers 
                   (FullName, NICNumber, MobileNumber, LicenseNumber, Availability, Email) 
                   VALUES (@FullName, @NICNumber, @MobileNumber, @LicenseNumber, @Availability, @Email)";

            SqlParameter[] parameters = {
                new SqlParameter("@FullName", txtFullName.Text),
                new SqlParameter("@NICNumber", txtNic.Text),
                new SqlParameter("@MobileNumber", txtMobile.Text),
                new SqlParameter("@LicenseNumber", txtLicenseNo.Text),
                new SqlParameter("@Availability", cmbAvailability.Text),
                new SqlParameter("@Email", txtEmail.Text)
            };

            Data.ExecuteNonQuery(sql, parameters);
            MessageBox.Show("Driver registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            ClearTextFields();
            LoadDriverData();
        }

        private void LoadDriverData()
        {
            string sql = "SELECT DriverID, FullName, NICNumber, MobileNumber, LicenseNumber, Availability, Email FROM Drivers";
            Data.LoadDataToGrid(sql, dgvDrivers);
        }

        private void ClearTextFields()
        {
            txtDriverId.Clear();
            txtFullName.Clear();
            txtNic.Clear();
            txtMobile.Clear();
            txtLicenseNo.Clear();
            txtEmail.Clear();
            cmbAvailability.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int driverId = Convert.ToInt32(txtDriverId.Text);

            var updatedData = new Dictionary<string, object>
            {
                { "FullName", txtFullName.Text },
                { "NICNumber", txtNic.Text },
                { "MobileNumber", txtMobile.Text },
                { "LicenseNumber", txtLicenseNo.Text },
                { "Availability", cmbAvailability.Text },
                { "Email", txtEmail.Text }
            };

            Data.UpdateRecord("Drivers", "DriverID", driverId, updatedData);
            MessageBox.Show("Driver details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            ClearTextFields();
            LoadDriverData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int driverId = Convert.ToInt32(txtDriverId.Text);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this driver?",
                                                  "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Data.DeleteById("Drivers", "DriverID", driverId);
                MessageBox.Show("Driver deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                LoadDriverData();
                ClearTextFields(); 
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            string[] columns = { "FullName", "NICNumber", "Availability" };

            DataTable result = Data.SearchMultipleColumns("Drivers", columns, search);
            dgvDrivers.DataSource = result;
        }

        private void dgvDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var map = new Dictionary<TextBox, string>
            {
                { txtDriverId, "DriverID" },
                { txtFullName, "FullName" },
                { txtNic, "NICNumber" },
                { txtMobile, "MobileNumber" },
                { txtLicenseNo, "LicenseNumber" },
                { txtEmail, "Email" }
            };

            Data.FillTextBoxesFromGrid(dgvDrivers, e.RowIndex, map);

            
            if (e.RowIndex >= 0 && e.RowIndex < dgvDrivers.Rows.Count)
            {
                cmbAvailability.Text = dgvDrivers.Rows[e.RowIndex].Cells["Availability"].Value?.ToString();
            }
        }
    }
}
