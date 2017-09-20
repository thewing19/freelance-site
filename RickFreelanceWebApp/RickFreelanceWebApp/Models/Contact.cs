using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickFreelanceWebApp.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

        public int AddressID { get; set; }

        public virtual Address Address { get; set; }
    }
}
