using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crunch.Models;

namespace Crunch.ViewModels
{
    public class ClassesViewModel
    {
        public List<Gym> gyms { get; set; }
        public List<List<Class>> classes { get; set; }
    }
}
