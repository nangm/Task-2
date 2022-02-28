using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Details { get; set; }
        public double Total { get; set; }
        public string OrderStatus { get; set; }
        public string CartID { get; set; }

    }
}
