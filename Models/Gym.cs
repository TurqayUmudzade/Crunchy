using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [NotMapped]
        public IFormFile Upload { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
