using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Supen.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Passwords requierd")]
        [MinLength(3, ErrorMessage = "The password must be atleast 3 characters")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The passwords dosent match")]
        [MinLength(3, ErrorMessage = "The password must be atleast 3 characters")]
        public string PasswordMatch { get; set; }

        [Required(ErrorMessage = "State your firstname")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "State your surename")]
        public string Surename { get; set; }

        [Required(ErrorMessage = "State your email")]
        [EmailAddress(ErrorMessage = "Invalid email adress")]
        public string Email { get; set; }
   
       
    
    }

   
}