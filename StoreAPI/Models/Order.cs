using System;

namespace StoreAPI.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public Product Product { get; set; }
    }
}
