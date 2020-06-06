using Crunch.Models;
using System.Collections.Generic;

namespace Crunch.Areas.Admin.ViewModels
{
    public class AdminTrainersViewModel
    {
        public Trainer trainer { get; set; }

        public List<Trainer> trainers { get; set; }

        public List<Gym> gyms { get; set; }
    }
}
