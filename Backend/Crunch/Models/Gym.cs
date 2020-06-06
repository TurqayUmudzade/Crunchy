using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crunch.Models
{
    public class Gym
    {
        [Key]
        public int gymID { get; set; }

        public String gymLocation { get; set; }

        public String gymAdress { get; set; }

        public String gymNumber { get; set; }

        public float price { get; set; }

        public String image { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
