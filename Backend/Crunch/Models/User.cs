using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Crunch.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserID { get; set; }


        public String firstName { get; set; }

        public String lastName { get; set; }

        public String Gender { get; set; }

        public String dateOfBirth { get; set; }

        public String Adress { get; set; }

        public String Town { get; set; }

        public String Postcode { get; set; }

        public String Email { get; set; }

        public String number { get; set; }

        public String pin { get; set; }

        public String gymLocation { get; set; }

        public bool premiumMemberShip { get; set; }

        public bool recieveSMS { get; set; }

        public bool recieveEmail { get; set; }

        public bool disability { get; set; }

        public string Token { get; set; }


    }
}
