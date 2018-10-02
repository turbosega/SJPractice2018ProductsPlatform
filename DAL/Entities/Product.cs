using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities 
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductDescription { get; set; }

        public Order Order { get; set; }
    }
}