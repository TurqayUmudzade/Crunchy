using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crunch.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crunch.Models
{
    public class UserClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserClassID { get; set; }

        public int UserID { get; set; }
        public int ClassID { get; set; }

        public User user { get; set; }
        public Class @class { get; set; }
    }
}
