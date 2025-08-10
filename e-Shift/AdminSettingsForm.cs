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
    public partial class AdminSettingsForm : Form
    {
        private User _adminUser;

        public AdminSettingsForm(User adminUser)
        {
            InitializeComponent();
            _adminUser = adminUser;
            LoadAdminDetails();
        }

        private void LoadAdminDetails()
        {
            txtUsername.Text = _adminUser.Username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                MessageBox.Show("Username and old password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txtNewPassword.Text) && txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("New passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verify old password
            string sqlVerify = "SELECT COUNT(*) FROM Users WHERE UserID=@id AND Password=@oldPass";
            SqlParameter[] verifyParams =
            {
                new SqlParameter("@id", _adminUser.UserID),
                new SqlParameter("@oldPass", txtOldPassword.Text.Trim())
            };

            DataTable result = Data.GetDataTable(sqlVerify, verifyParams);
            if (Convert.ToInt32(result.Rows[0][0]) == 0)
            {
                MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Build update query
            string sqlUpdate;
            SqlParameter[] updateParams;
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                sqlUpdate = "UPDATE Users SET Username=@uname WHERE UserID=@id";
                updateParams = new SqlParameter[]
                {
                    new SqlParameter("@uname", txtUsername.Text.Trim()),
                    new SqlParameter("@id", _adminUser.UserID)
                };
            }
            else
            {
                sqlUpdate = "UPDATE Users SET Username=@uname, Password=@newPass WHERE UserID=@id";
                updateParams = new SqlParameter[]
                {
                    new SqlParameter("@uname", txtUsername.Text.Trim()),
                    new SqlParameter("@newPass", txtNewPassword.Text.Trim()),
                    new SqlParameter("@id", _adminUser.UserID)
                };
            }

            // Execute update
            Data.ExecuteQuery(sqlUpdate, updateParams);
            MessageBox.Show("Admin details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update the User object in memory
            _adminUser.Username = txtUsername.Text.Trim();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminSettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
