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
    public partial class ManageAssistant : Form
    {
        public ManageAssistant()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO Assistants 
                   (FullName, NICNumber, Email, MobileNumber, Availability) 
                   VALUES (@FullName, @NICNumber, @Email, @MobileNumber, @Availability)";

            SqlParameter[] parameters = {
                new SqlParameter("@FullName", txtFullName.Text),
                new SqlParameter("@NICNumber", txtNic.Text),
                new SqlParameter("@Email", txtEmail.Text),
                new SqlParameter("@MobileNumber", txtMobile.Text),
                new SqlParameter("@Availability", cmbAvailability.Text)
            };

            Data.ExecuteNonQuery(sql, parameters);
            MessageBox.Show("Assistant registered successfully!");

            LoadAssistants(); 
            ClearFields();
        }

        private void LoadAssistants()
        {
            string query = "SELECT AssistantID, FullName, NICNumber, Email, MobileNumber, Availability FROM Assistants";
            Data.LoadDataToGrid(query, dgvAssistants);
        }

        private void ClearFields()
        {
            txtAssistantId.Clear();
            txtFullName.Clear();
            txtNic.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            cmbAvailability.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtAssistantId.Text);

            var updatedData = new Dictionary<string, object>
            {
                { "FullName", txtFullName.Text },
                { "NICNumber", txtNic.Text },
                { "Email", txtEmail.Text },
                { "MobileNumber", txtMobile.Text },
                { "Availability", cmbAvailability.Text }
            };

            Data.UpdateRecord("Assistants", "AssistantID", id, updatedData);
            MessageBox.Show("Assistant details updated successfully!");

            ClearFields();
            LoadAssistants();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtAssistantId.Text);

            var result = MessageBox.Show("Are you sure you want to delete this assistant?",
                                         "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.DeleteById("Assistants", "AssistantID", id);
                MessageBox.Show("Assistant deleted successfully!");

                LoadAssistants();
                ClearFields();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            string[] cols = { "FullName", "NICNumber", "Availability" };

            dgvAssistants.DataSource = Data.SearchMultipleColumns("Assistants", cols, search);
        }

        private void dgvAssistants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var map = new Dictionary<TextBox, string>
            {
                { txtAssistantId, "AssistantID" },
                { txtFullName, "FullName" },
                { txtNic, "NICNumber" },
                { txtEmail, "Email" },
                { txtMobile, "MobileNumber" }
            };

            Data.FillTextBoxesFromGrid(dgvAssistants, e.RowIndex, map);

            // ComboBox manual set
            if (e.RowIndex >= 0 && e.RowIndex < dgvAssistants.Rows.Count)
            {
                cmbAvailability.Text = dgvAssistants.Rows[e.RowIndex].Cells["Availability"].Value?.ToString();
            }
        }

        private void ManageAssistant_Load(object sender, EventArgs e)
        {
            Data.LoadTableToGrid("Assistants", dgvAssistants);
            AvailabilityCombo();
        }

        private void AvailabilityCombo()
        {
            cmbAvailability.Items.Clear();
            cmbAvailability.Items.Add("Available");
            cmbAvailability.Items.Add("On Job");
            cmbAvailability.Items.Add("Unavailable");
        }

        private void cmbAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
