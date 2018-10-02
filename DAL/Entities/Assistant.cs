using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities 
{
    public class Assistant
    {
        [Key]
        public int AssistantId { get; set; }

        [Required, StringLength(255)]
        public string FullName { get; set; }

        [Required, StringLength(255)]
        public string Gender { get; set; }

        [Required, Column(TypeName = "date")]
        public DateTime BirthDay { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}