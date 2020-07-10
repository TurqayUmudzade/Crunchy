using System.Collections.Generic;
using Crunch.Models;

namespace Crunch.Areas.Admin.ViewModels
{
    public class AdminGymViewModel
    {
        public Gym gym { get; set; }

        public List<Gym> gyms { get; set; }
    }
}
