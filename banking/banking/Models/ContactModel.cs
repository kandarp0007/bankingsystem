using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace banking.Models
{
    public class ContactModel
    {

        [Required(ErrorMessage = "Please enter your email address")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string EmailAddress { get; set; }


        [Required(ErrorMessage = "Please enter your Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public int PhoneNumber { get; set; }


        [Required(ErrorMessage = "Please enter Message")]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
