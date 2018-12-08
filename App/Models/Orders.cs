using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int? ItemId { get; set; }
        public int? CustomerId { get; set; }

        public Customers Customer { get; set; }
        public Items Item { get; set; }
    }
}
