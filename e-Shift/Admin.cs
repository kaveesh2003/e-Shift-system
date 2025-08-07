using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Shift
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string Username { get; set; }

        public Admin(int id, string username)
        {
            AdminID = id;
            Username = username;
        }
    }
}
