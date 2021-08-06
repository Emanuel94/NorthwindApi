using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Models
{
    class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quatity { get; set; }
      
    }
}
