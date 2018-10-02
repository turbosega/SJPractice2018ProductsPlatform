using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities 
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, StringLength(255)]
        public string Email { get; set; }

        [Required, StringLength(255)]
        public string Password { get; set; }

        [Required, StringLength(255)]
        public string Salt { get; set; }

        [Required, Column(TypeName = "datetime2(0)")]
        public DateTime RegisteredAt { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public Customer Customer { get; set; }

        public Assistant Assistant { get; set; }

    }
}