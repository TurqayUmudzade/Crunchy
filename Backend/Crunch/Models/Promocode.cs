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
        [MaxLength(10)]
        public string promocode { get; set; }

        public int discountPercent { get; set; }

        public bool OneTime { get; set; }

        //check if one time promocode has been used
        public bool IsUsed { get; set; }

        public DateTime Expire { get; set; }

       
    }
}
