using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Crunch.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public string duration { get; set; }

        [Required]
        public DateTime dateTime { get; set; }
        [Required]
        public Gym gym { get; set; }

        [Required]
        public int space { get; set; }

        public int spaceUsed { get; set; }

        public string type { get; set; }

        public string icon { get; set; }

        public List<UserClass> userClasses { get; set; }
    }
}
