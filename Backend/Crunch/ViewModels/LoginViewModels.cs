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
        public List<Gym> gyms { get; set; }
        public Gym gym { get; set; }

    }

    public class LogingInViewModel
    {
        [Required(ErrorMessage = "Enter Email ")]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter Password ")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Pin { get; set; }

        public bool RememberMe { get; set; }
    }
}
