using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebUl.Models
{
    public class Login
    {

        [Required]
        [DisplayName("Your Username")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Your Email")]
        [EmailAddress(ErrorMessage = "Your e-mail is not correct")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Your Password")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}