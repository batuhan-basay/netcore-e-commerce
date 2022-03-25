using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebUl.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Your Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Your Surname")]
        public string SurName { get; set; }

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
        [DisplayName("Your RePassword")]
        [Compare("Password", ErrorMessage = "Your passwords do not match")]
        public string RePassword { get; set; }

    }
}