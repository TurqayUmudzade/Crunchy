﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crunch.Models
{
    public class Trainer
    {

        [Key]
        public int ID { get; set; }
        [Required]
        public String fullName { get; set; }

        [Required]
        public String Speciality { get; set; }

        [Required]
        public String image { get; set; }


        public String aboutMe { get; set; }
        //mr or mrs
        public String title { get; set; }

       // public List<String> Qualifications { get; set; }

        /*[NotMapped]
        public HttpPostedFileBase Upload { get; set; }*/


    }
}
