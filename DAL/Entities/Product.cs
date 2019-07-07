using System.Collections.Generic;

namespace WebAPI.DAL.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductDescription { get; set; }
        public virtual ICollection<OrderProduct> OrderProductses { get; set; }
    }
}
