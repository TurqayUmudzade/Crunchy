using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Crunch.Models;
namespace Crunch.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }

        [Required]
        public String name { get; set; }
        [Required]
        public String description { get; set; }
        [Required]
        public String duration { get; set; }
        [Required]
        public DateTime dateTime { get; set; }
        [Required]
        public Gym gym { get; set; }

        [Required]
        public int space { get; set; }
        
        public int spaceUsed { get; set; }
        
        public String type { get; set; }
        
        public String icon { get; set; }

        public List<UserClass> userClasses { get; set; }
    }
}
