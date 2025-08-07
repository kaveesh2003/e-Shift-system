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
    public partial class TransportUnit : Form
    {
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
    }
}
