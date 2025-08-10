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
    public partial class ManageLorries : Form
    {
        public ManageLorries()
        {
            InitializeComponent();
        }

        private void ManageLorries_Load(object sender, EventArgs e)
        {
            string query = "SELECT TypeID, TypeName FROM LorryTypes";
            Data.FillComboBox(query, cmbLorryType, "TypeName", "TypeID");

            cmbAvailability.Items.AddRange(new string[] { "Available", "On Job", "Unavailable" });

            LoadLorries();
        }

        private void LoadLorries()
        {
            string query = @"
                SELECT L.LorryID, 
                    L.PlateNumber, 
                    L.Availability, 
                    LT.TypeName 
                FROM Lorries L
                INNER JOIN LorryTypes LT ON L.TypeID = LT.TypeID";

            DataTable dt = Data.GetData(query);
            dgvLorries.DataSource = dt;

            // Adjust headers for clarity
            dgvLorries.Columns["LorryID"].HeaderText = "Lorry ID";
            dgvLorries.Columns["PlateNumber"].HeaderText = "Plate Number";
            dgvLorries.Columns["Availability"].HeaderText = "Status";
            dgvLorries.Columns["TypeName"].HeaderText = "Lorry Type";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbLorryType.SelectedIndex == -1 || cmbAvailability.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid lorry type and availability.");
                return;
            }

            string sql = @"INSERT INTO Lorries (PlateNumber, Availability, TypeID)
                   VALUES (@PlateNumber, @Availability, @TypeID)";

            SqlParameter[] parameters = {
                new SqlParameter("@PlateNumber", txtNoPlate.Text),
                new SqlParameter("@Availability", cmbAvailability.Text),
                new SqlParameter("@TypeID", cmbLorryType.SelectedValue)
            };

            Data.ExecuteNonQuery(sql, parameters);
            MessageBox.Show("Lorry saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            LoadLorries(); 
            ClearForm();
        }

        private void dgvLorries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLorries.Rows.Count)
            {
                DataGridViewRow row = dgvLorries.Rows[e.RowIndex];

                txtLorryId.Text = row.Cells["LorryID"].Value?.ToString();
                txtNoPlate.Text = row.Cells["PlateNumber"].Value?.ToString();
                cmbAvailability.Text = row.Cells["Availability"].Value?.ToString();

                // Match selected lorry type by text (optional alternative: store TypeID in hidden column)
                string selectedType = row.Cells["TypeName"].Value?.ToString();
                cmbLorryType.SelectedIndex = cmbLorryType.FindStringExact(selectedType);
            }
        }

        private void ClearForm()
        {
            txtLorryId.Clear();
            txtNoPlate.Clear();
            cmbLorryType.SelectedIndex = -1;
            cmbAvailability.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvLorries.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvLorries.SelectedRows[0].Cells["LorryID"].Value);

                if (cmbLorryType.SelectedValue == null || !int.TryParse(cmbLorryType.SelectedValue.ToString(), out int typeId))
                {
                    MessageBox.Show("Invalid lorry type selected.");
                    return;
                }

                Dictionary<string, object> updateData = new Dictionary<string, object>
                {
                    { "PlateNumber", txtNoPlate.Text },
                    { "TypeID", typeId },
                    { "Availability", cmbAvailability.SelectedItem?.ToString() }
                };

                Data.UpdateRecord("Lorries", "LorryID", selectedId, updateData);
                MessageBox.Show("Lorry details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                LoadLorries();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLorries.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvLorries.SelectedRows[0].Cells["LorryID"].Value);

                var confirm = MessageBox.Show("Are you sure you want to delete this lorry?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Data.DeleteById("Lorries", "LorryID", selectedId);
                    MessageBox.Show("Lorry deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadLorries();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            string sql = @"
                SELECT l.LorryID, l.PlateNumber, l.Availability, t.TypeName, t.UnitPrice
                FROM Lorries l
                INNER JOIN LorryTypes t ON l.TypeID = t.TypeID
                WHERE l.PlateNumber LIKE @search
                    OR l.Availability LIKE @search
                OR t.TypeName LIKE @search";

            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@search", "%" + searchText + "%")
            };

            dgvLorries.DataSource = Data.GetDataTable(sql, parameters);
        }

        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadLorries(); 
            }
        }

        public int GetTypeIDByName(string typeName)
        {
            string query = "SELECT TypeID FROM LorryTypes WHERE TypeName = @name";
            SqlParameter[] parameters = {
                new SqlParameter("@name", typeName)
            };

            DataTable dt = Data.GetData(query, parameters);

            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0]["TypeID"]);

            return -1; // or throw error
        }
    }
}
