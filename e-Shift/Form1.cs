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
    public partial class Signupfrm : Form
    {
        public Signupfrm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString()
            };

            // Validate password here before signup
            if (!IsValidPassword(user.Password))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain uppercase, lowercase, digit, and special character.",
                                "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = user.SignUp();

            if (result)
            {
                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registration failed. Username might already exist or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            if (password.Length < 8) return false; // Minimum 8 characters
            if (!password.Any(char.IsUpper)) return false; // At least one uppercase
            if (!password.Any(char.IsLower)) return false;
            if (!password.Any(char.IsDigit)) return false; 
            if (!password.Any(ch => "!@#$%^&*()_-+=<>?".Contains(ch))) return false; // At least one special char
            return true;
        }
    }
}
