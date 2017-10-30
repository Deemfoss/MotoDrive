using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MotoDrive.Web.Models.Authorisation
{ 
        public class LoginModel
    {
        [Required(ErrorMessage = "Empty area")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Empty area")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}
