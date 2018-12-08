using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
