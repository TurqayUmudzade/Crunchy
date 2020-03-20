using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Crunch.Models
{
    public class Gym
    {
        [Key]
        public int gymID { get; set; }

        public String gymLocation { get; set; }

        public String gymAdress { get; set; }

        public float price { get; set; }
    }
}
