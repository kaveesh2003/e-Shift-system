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
    public partial class TransportUnit : Form
    {
        private int currentTransportUnitId = 0;

        public TransportUnit()
        {
            InitializeComponent();
        }

        private void btnMngDriver_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Admin Dashboard
            ManageDrivers manageDrivers = new ManageDrivers();
            manageDrivers.FormClosed += (s, args) => this.Show(); 
            manageDrivers.Show();
        }

        private void btnMngAssistant_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Admin Dashboard
            ManageAssistant manageAssistant = new ManageAssistant();
            manageAssistant.FormClosed += (s, args) => this.Show(); 
            manageAssistant.Show();
        }

        private void btnmngLorries_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Admin Dashboard
            ManageLorries manageLorries = new ManageLorries();
            manageLorries.FormClosed += (s, args) => this.Show();
            manageLorries.Show();
        }

        private void btnMngContainers_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Admin Dashboard
            ManageContainer manageContainer = new ManageContainer();
            manageContainer.FormClosed += (s, args) => this.Show();
            manageContainer.Show();
        }

        private void TransportUnit_Load(object sender, EventArgs e)
        {
            // Load Load IDs (status = 'Pending')
            string loadQuery = @"
                SELECT LoadID, LoadID AS DisplayLoadID
                FROM Loads
                WHERE Status = 'Pending'";
            Data.FillComboBox(loadQuery, cmbLoadID, "DisplayLoadID", "LoadID");

            // Load Lorry numbers (status = 'Available')
            string lorryQuery = @"
                SELECT LorryID, PlateNumber
                FROM Lorries
                WHERE Availability = 'Available'";
            Data.FillComboBox(lorryQuery, cmbLorryNo, "PlateNumber", "LorryID");

            // Load Drivers (status = 'Available')
            string driverQuery = @"
                SELECT DriverID, FullName
                FROM Drivers
                WHERE Availability = 'Available'";
            Data.FillComboBox(driverQuery, cmbDriver, "FullName", "DriverID");

            // Load Assistants (status = 'Available')
            string assistantQuery = @"
                SELECT AssistantID, FullName
                FROM Assistants
                WHERE Availability = 'Available'";
            Data.FillComboBox(assistantQuery, cmbAssistant, "FullName", "AssistantID");

            // Load Containers (status = 'Available')
            string containerQuery = @"
                SELECT ContainerID, ContainerCode
                FROM Containers
                WHERE Availability = 'Available'";
            Data.FillComboBox(containerQuery, cmbContainer, "ContainerCode", "ContainerID");

            // Load TransportUnits table into grid
            LoadTransportUnitsToGrid();
        }

        private void cmbLoadID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoadID.SelectedValue == null || cmbLoadID.SelectedValue is DataRowView)
                return;

            int loadId = Convert.ToInt32(cmbLoadID.SelectedValue);

            using (SqlConnection con = new SqlConnection(Data.cs))
            {
                con.Open();
                string query = @"
                    SELECT j.RequestedDate
                    FROM Loads l
                    INNER JOIN Jobs j ON l.JobID = j.JobID
                    WHERE l.LoadID = @loadId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@loadId", loadId);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    DateTime requestedDate = Convert.ToDateTime(result);

                    // First set limits
                    dtpPickup.MaxDate = requestedDate;
                    dtpDelivery.MaxDate = requestedDate;

                    // Then set values
                    DateTime today = DateTime.Today;
                    dtpPickup.Value = today <= requestedDate ? today : requestedDate;
                    dtpDelivery.Value = requestedDate;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbLoadID.SelectedItem == null || cmbLorryNo.SelectedItem == null ||
                cmbDriver.SelectedItem == null || cmbAssistant.SelectedItem == null ||
                cmbContainer.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            int loadId = Convert.ToInt32(cmbLoadID.SelectedValue);
            int lorryId = Convert.ToInt32(cmbLorryNo.SelectedValue);
            int driverId = Convert.ToInt32(cmbDriver.SelectedValue);
            int assistantId = Convert.ToInt32(cmbAssistant.SelectedValue);
            int containerId = Convert.ToInt32(cmbContainer.SelectedValue);
            DateTime pickupDate = dtpPickup.Value;
            DateTime deliveryDate = dtpDelivery.Value;

            int jobId;
            DateTime requestedDate;

            using (SqlConnection con = new SqlConnection(Data.cs))
            {
                con.Open();

                // Get JobID & RequestedDate
                using (SqlCommand cmd = new SqlCommand(@"
            SELECT l.JobID, j.RequestedDate
            FROM Loads l
            INNER JOIN Jobs j ON l.JobID = j.JobID
            WHERE l.LoadID = @loadId", con))
                {
                    cmd.Parameters.AddWithValue("@loadId", loadId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            jobId = Convert.ToInt32(reader["JobID"]);
                            requestedDate = Convert.ToDateTime(reader["RequestedDate"]);
                        }
                        else
                        {
                            MessageBox.Show("Unable to retrieve job details.");
                            return;
                        }
                    }
                }

                // Validate pickup/delivery
                if (pickupDate > requestedDate)
                {
                    MessageBox.Show("Pickup date must be on or before the customer's requested date.");
                    return;
                }
                if (deliveryDate > requestedDate)
                {
                    MessageBox.Show("Delivery date must be on or before the customer's requested date.");
                    return;
                }

                // TRANSACTION START
                using (SqlTransaction tran = con.BeginTransaction())
                {
                    try
                    {
                        // Insert into TransportUnits
                        using (SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO TransportUnits
                    (LoadID, JobID, LorryID, DriverID, AssistantID, ContainerID, PickUpDateTime, DeliveryDateTime)
                    VALUES (@loadId, @jobId, @lorryId, @driverId, @assistantId, @containerId, @pickupDate, @deliveryDate)", con, tran))
                        {
                            cmd.Parameters.AddWithValue("@loadId", loadId);
                            cmd.Parameters.AddWithValue("@jobId", jobId);
                            cmd.Parameters.AddWithValue("@lorryId", lorryId);
                            cmd.Parameters.AddWithValue("@driverId", driverId);
                            cmd.Parameters.AddWithValue("@assistantId", assistantId);
                            cmd.Parameters.AddWithValue("@containerId", containerId);
                            cmd.Parameters.AddWithValue("@pickupDate", pickupDate);
                            cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
                            cmd.ExecuteNonQuery();
                        }

                        // Update statuses
                        string updateSql = @"
                    UPDATE Loads SET Status = 'In Transit' WHERE LoadID = @loadId;
                    UPDATE Lorries SET Availability = 'On Job' WHERE LorryID = @lorryId;
                    UPDATE Drivers SET Availability = 'On Job' WHERE DriverID = @driverId;
                    UPDATE Assistants SET Availability = 'On Job' WHERE AssistantID = @assistantId;
                    UPDATE Containers SET Availability = 'On Job' WHERE ContainerID = @containerId;
                    UPDATE Jobs SET Status = 'In Transit' WHERE JobID = @jobId;";

                        using (SqlCommand cmd = new SqlCommand(updateSql, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@loadId", loadId);
                            cmd.Parameters.AddWithValue("@lorryId", lorryId);
                            cmd.Parameters.AddWithValue("@driverId", driverId);
                            cmd.Parameters.AddWithValue("@assistantId", assistantId);
                            cmd.Parameters.AddWithValue("@containerId", containerId);
                            cmd.Parameters.AddWithValue("@jobId", jobId);
                            cmd.ExecuteNonQuery();
                        }

                        // Commit transaction
                        tran.Commit();

                        MessageBox.Show("Transport Unit assigned and statuses updated successfully!");

                        // Refresh grid
                        LoadTransportUnitsToGrid();
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void ClearForm()
        {
            cmbLoadID.SelectedIndex = -1;
            cmbLorryNo.SelectedIndex = -1;
            cmbDriver.SelectedIndex = -1;
            cmbAssistant.SelectedIndex = -1;
            cmbContainer.SelectedIndex = -1;
            dtpPickup.Value = DateTime.Now;
            dtpDelivery.Value = DateTime.Now;
        }

        private void LoadTransportUnitsToGrid()
        {
            string query = @"
        SELECT 
            tu.TransportUnitID,
            l.LoadID,
            lo.LorryID,
            
            d.DriverID,
            
            a.AssistantID,
            
            c.ContainerID,
            
            tu.PickUpDateTime,
            tu.DeliveryDateTime
        FROM TransportUnits tu
        INNER JOIN Loads l ON tu.LoadID = l.LoadID
        INNER JOIN Lorries lo ON tu.LorryID = lo.LorryID
        INNER JOIN Drivers d ON tu.DriverID = d.DriverID
        INNER JOIN Assistants a ON tu.AssistantID = a.AssistantID
        INNER JOIN Containers c ON tu.ContainerID = c.ContainerID
    ";

            Data.LoadDataToGridView(query, dgvTransportUnit);
        }

        private void dgvTransportUnit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransportUnit.CurrentRow == null) return;

            var row = dgvTransportUnit.CurrentRow;

            SetComboBoxSelectedValue(cmbLoadID, row.Cells["LoadID"].Value);
            SetComboBoxSelectedValue(cmbLorryNo, row.Cells["LorryID"].Value);
            SetComboBoxSelectedValue(cmbDriver, row.Cells["DriverID"].Value);
            SetComboBoxSelectedValue(cmbAssistant, row.Cells["AssistantID"].Value);
            SetComboBoxSelectedValue(cmbContainer, row.Cells["ContainerID"].Value);

            dtpPickup.Value = Convert.ToDateTime(row.Cells["PickUpDateTime"].Value);
            dtpDelivery.Value = Convert.ToDateTime(row.Cells["DeliveryDateTime"].Value);

            currentTransportUnitId = Convert.ToInt32(row.Cells["TransportUnitID"].Value);
        }

        void SetComboBoxSelectedValue(ComboBox cmb, object value)
        {
            if (value == null) return;
            int val = Convert.ToInt32(value);
            bool exists = cmb.Items.Cast<DataRowView>().Any(dr => Convert.ToInt32(dr[cmb.ValueMember]) == val);
            if (exists)
            {
                cmb.SelectedValue = val;
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentTransportUnitId == 0)
            {
                MessageBox.Show("Please select a Transport Unit to edit.");
                return;
            }

            // New selected values from form
            int newLoadId = Convert.ToInt32(cmbLoadID.SelectedValue);
            int newLorryId = Convert.ToInt32(cmbLorryNo.SelectedValue);
            int newDriverId = Convert.ToInt32(cmbDriver.SelectedValue);
            int newAssistantId = Convert.ToInt32(cmbAssistant.SelectedValue);
            int newContainerId = Convert.ToInt32(cmbContainer.SelectedValue);
            DateTime newPickupDate = dtpPickup.Value;
            DateTime newDeliveryDate = dtpDelivery.Value;

            using (SqlConnection con = new SqlConnection(Data.cs))
            {
                con.Open();

                // Step 1: Get existing TransportUnit resource IDs
                string getOldResourcesSql = @"
            SELECT LorryID, DriverID, AssistantID, ContainerID
            FROM TransportUnits
            WHERE TransportUnitID = @transportUnitId";

                int oldLorryId = 0, oldDriverId = 0, oldAssistantId = 0, oldContainerId = 0;

                using (SqlCommand cmd = new SqlCommand(getOldResourcesSql, con))
                {
                    cmd.Parameters.AddWithValue("@transportUnitId", currentTransportUnitId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            oldLorryId = Convert.ToInt32(reader["LorryID"]);
                            oldDriverId = Convert.ToInt32(reader["DriverID"]);
                            oldAssistantId = Convert.ToInt32(reader["AssistantID"]);
                            oldContainerId = Convert.ToInt32(reader["ContainerID"]);
                        }
                        else
                        {
                            MessageBox.Show("Transport Unit not found.");
                            return;
                        }
                    }
                }

                // Step 2: Start transaction for update & availability changes
                using (SqlTransaction tran = con.BeginTransaction())
                {
                    try
                    {
                        // Step 3: Update TransportUnit record
                        string updateTransportUnitSql = @"
                    UPDATE TransportUnits
                    SET LoadID = @loadId,
                        LorryID = @lorryId,
                        DriverID = @driverId,
                        AssistantID = @assistantId,
                        ContainerID = @containerId,
                        PickUpDateTime = @pickupDate,
                        DeliveryDateTime = @deliveryDate
                    WHERE TransportUnitID = @transportUnitId";

                        using (SqlCommand cmd = new SqlCommand(updateTransportUnitSql, con, tran))
                        {
                            cmd.Parameters.AddWithValue("@loadId", newLoadId);
                            cmd.Parameters.AddWithValue("@lorryId", newLorryId);
                            cmd.Parameters.AddWithValue("@driverId", newDriverId);
                            cmd.Parameters.AddWithValue("@assistantId", newAssistantId);
                            cmd.Parameters.AddWithValue("@containerId", newContainerId);
                            cmd.Parameters.AddWithValue("@pickupDate", newPickupDate);
                            cmd.Parameters.AddWithValue("@deliveryDate", newDeliveryDate);
                            cmd.Parameters.AddWithValue("@transportUnitId", currentTransportUnitId);
                            cmd.ExecuteNonQuery();
                        }

                        // Step 4: Update availability for changed resources

                        // Helper to update availability
                        void UpdateAvailability(string tableName, string idColumn, int id, string availability)
                        {
                            string sql = $"UPDATE {tableName} SET Availability = @availability WHERE {idColumn} = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, con, tran))
                            {
                                cmd.Parameters.AddWithValue("@availability", availability);
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Compare old and new Lorry
                        if (oldLorryId != newLorryId)
                        {
                            UpdateAvailability("Lorries", "LorryID", oldLorryId, "Available");
                            UpdateAvailability("Lorries", "LorryID", newLorryId, "On Job");
                        }

                        // Compare old and new Driver
                        if (oldDriverId != newDriverId)
                        {
                            UpdateAvailability("Drivers", "DriverID", oldDriverId, "Available");
                            UpdateAvailability("Drivers", "DriverID", newDriverId, "On Job");
                        }

                        // Compare old and new Assistant
                        if (oldAssistantId != newAssistantId)
                        {
                            UpdateAvailability("Assistants", "AssistantID", oldAssistantId, "Available");
                            UpdateAvailability("Assistants", "AssistantID", newAssistantId, "On Job");
                        }

                        // Compare old and new Container
                        if (oldContainerId != newContainerId)
                        {
                            UpdateAvailability("Containers", "ContainerID", oldContainerId, "Available");
                            UpdateAvailability("Containers", "ContainerID", newContainerId, "On Job");
                        }

                        // Commit all changes
                        tran.Commit();

                        MessageBox.Show("Transport Unit updated successfully!");

                        // Refresh grid and clear form
                        LoadTransportUnitsToGrid();
                        ClearForm();

                        currentTransportUnitId = 0; // reset selection
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error updating Transport Unit: " + ex.Message);
                    }
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentTransportUnitId == 0)
            {
                MessageBox.Show("Please select a Transport Unit to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this Transport Unit?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                Data.DeleteById("TransportUnits", "TransportUnitID", currentTransportUnitId);
                MessageBox.Show("Transport Unit deleted.");

                // Refresh grid
                LoadTransportUnitsToGrid();
                ClearForm();
            }
        }
    }
}
