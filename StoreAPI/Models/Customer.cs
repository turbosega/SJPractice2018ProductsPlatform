using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
