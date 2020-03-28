using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Crunch.Models
{
    public class Promocode
    {
        [Key]
        public int ID { get; set; }

        public string promocode { get; set; }

        public int discountPercent { get; set; }

        public bool OneTime { get; set; }

        public DateTime Expire { get; set; }
    }
}
