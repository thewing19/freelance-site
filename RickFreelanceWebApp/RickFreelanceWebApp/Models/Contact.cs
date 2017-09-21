using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RickFreelanceWebApp.Models
{
    public class Contact
    {
        public int ContactID { get; set; }

        [Required]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string LastName { get; set; }
        [Required]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Not a valid email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Required(ErrorMessage = "Enter a Valid 5 Digit Zip Code")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
    }
}
