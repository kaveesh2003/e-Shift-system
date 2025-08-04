using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace e_Shift
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Simulate profile completeness check (you can update this to query DB)
        public bool IsProfileComplete()
        {
            // Ideally, check DB fields like Mobile, City, Age etc.
            return Data.IsCustomerProfileComplete(Id);
        }
    }
}
