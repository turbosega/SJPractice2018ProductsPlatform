using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities 
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProductQuantity{get; set;}
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}