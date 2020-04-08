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

        [Required]
        [MaxLength(100)]
        public String firstName { get; set; }

        [Required]
        [MaxLength(100)]
        public String lastName { get; set; }

        [Required]
        public String Gender { get; set; }

        [Required]
        public String dateOfBirth { get; set; }

        [MaxLength(100)]
        public String Adress { get; set; }

        [MaxLength(100)]
        public String Town { get; set; }

        [MaxLength(100)]
        public String Postcode { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [MaxLength(100)]
        public String number { get; set; }

        [MaxLength(100)]
        public String pin { get; set; }

        [MaxLength(100)]
        public String gymLocation { get; set; }

        public Gym gym { get; set; }

        public bool premiumMemberShip { get; set; }

        public bool recieveSMS { get; set; }

        public bool recieveEmail { get; set; }

        public bool disability { get; set; }

        public string Token { get; set; }


        public Promocode promocode { get; set; }

        public int paymentOption { get; set; }//1 2 3

        public DateTime membershipActiveTill { get; set; }


        public List<UserClass> userClasses { get; set; }

    }
}
