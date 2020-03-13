using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Crunch.Models
{
    public class Class
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public String name { get; set; }
        [Required]
        public String duration { get; set; }
        [Required]
        public DateTime dateTime { get; set; }
        [Required]
        public String gymLocation { get; set; }
        [Required]
        public String Status { get; set; }
        [Required]
        public int space { get; set; }
        [Required]
        public int spaceUsed { get; set; }
        [Required]
        public String type { get; set; }
        [Required]
        public String icon { get; set; }
    }
}
