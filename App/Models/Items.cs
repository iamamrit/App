using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Items
    {
        public Items()
        {
            Orders = new HashSet<Orders>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int? ItemCost { get; set; }
        public int? ItemType { get; set; }
        public string VendorName { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
