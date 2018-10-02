using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(64)]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}