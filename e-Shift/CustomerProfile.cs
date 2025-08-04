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
    public partial class CustomerProfile : Form
    {
        private int _userId;
        public CustomerProfile(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
