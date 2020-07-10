using System.Collections.Generic;
using Crunch.Models;

namespace Crunch.ViewModels
{
    public class ClassesViewModel
    {
        public List<Gym> gyms { get; set; }
        public List<List<Class>> classes { get; set; }
    }
}
