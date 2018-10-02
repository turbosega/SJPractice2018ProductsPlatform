using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities 
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required, StringLength(255)]
        public string FullName { get; set; }

        [Required, StringLength(255)]
        public string Gender { get; set; }

        [Required, Column(TypeName = "date")]
        public DateTime BirthDay { get; set; }

        [Required, StringLength(255)]
        public string Address { get; set; }

        [StringLength(32)]
        public string PhoneNumber { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}