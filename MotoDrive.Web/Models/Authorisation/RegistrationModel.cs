using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotoDrive.Web.Models.Authorisation
{
    public class RegistrationModel
    {
     
        [Required(ErrorMessage ="Empty area")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Empty area")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Wrong pasword")]
        public string ConfirmPassword { get; set; }

    
    }
}
