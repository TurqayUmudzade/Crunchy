using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crunch.Models;

namespace Crunch.ViewModels
{
    public class ContactMemberViewModel
    {
        public Email  email  { get; set; }
        public User user { get; set; }
    }
}
