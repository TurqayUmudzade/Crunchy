using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crunch.Models;
using System.ComponentModel.DataAnnotations;

namespace Crunch.ViewModels
{
    public class LoginViewModels
    {
        public RegisterViewModel Register { get; set; }
        public LogingInViewModel Login { get; set; }
    }

    public class RegisterViewModel
    {
        public User User { get; set; }

    }

    public class LogingInViewModel
    {
        [Required(ErrorMessage = "Entered Email ")]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Entered Password ")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
