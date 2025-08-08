using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Shift
{
    public class LoadProduct
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal WeightPerUnit { get; set; }  // This is the weight of one item
        public decimal TotalWeight => WeightPerUnit * Quantity;
        public int JobID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int LoadID { get; set; }
    }
}
