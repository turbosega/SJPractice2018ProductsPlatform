using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class OrderProduct
    {
        public ICollection<Product> Products { get; set; }
        public ICollection<Order> Orders { get; set; }
        public string Adress { get; set; }
        public int ProductQuantity{get; set;}

    }
}
