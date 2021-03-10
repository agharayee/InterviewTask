using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Web.Models
{
    public class RegisterModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string ContactAddress { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required]
        [Display(Name = "Comfirm Password")]
        [Compare (nameof(Password), ErrorMessage = "Password Mismatched")]
        [DataType(DataType.Password)]
        public string ComfirmPassword { get; set; }
    }
}
