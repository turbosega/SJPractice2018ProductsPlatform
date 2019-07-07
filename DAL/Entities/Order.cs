using System;
using System.Collections.Generic;

namespace WebAPI.DAL.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreateTime { get; set; }
        public string OrderStatus { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string DeliveryAddress { get; set; }
        public virtual ICollection<OrderProduct> OrderProductses { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
    }
}
