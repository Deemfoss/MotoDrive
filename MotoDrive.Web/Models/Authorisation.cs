using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MotoDrive.Web.Models
{ 
    public class RegisterModel
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
