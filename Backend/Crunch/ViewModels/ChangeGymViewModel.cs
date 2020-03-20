using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crunch.Models;

namespace Crunch.ViewModels
{
    public class ChangeGymViewModel
    {
        public User user { get; set; }
        public List<Gym> gyms { get; set; }
    }
}
