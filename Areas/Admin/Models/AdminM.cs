﻿using System.ComponentModel.DataAnnotations;

namespace Crunch.Areas.Admin.Models
{
    public class AdminM
    {

        [Key]
        public int AdminID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }


        public string Token { get; set; }
    }
}
