using System;
using System.ComponentModel.DataAnnotations;

namespace Crunch.Models
{
    public class Email
    {
        [Required]
        [MaxLength(25)]
        public String Subject { get; set; }
        [Required]
        [MaxLength(250)]
        public String Body { get; set; }
        [Required]
        public String Nature { get; set; }
        [Required]
        public String Gym { get; set; }
    }
}
