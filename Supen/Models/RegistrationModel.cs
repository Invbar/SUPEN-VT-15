using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using DAL;

namespace Supen.Models
{
    public class RegistrationModel
    {
        public string Username { get; set; }

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

        public Users CreateNewUser(){
            var newUser = new Users();
            newUser.Username = newUser.Firstname.Substring(0, 3) + newUser.Surname.Substring(0, 3);
            newUser.uPassword = Password;
            newUser.email = Email;
            newUser.Firstname = Firstname;
            newUser.Surname = Surename;
        }
    
    }

   
}