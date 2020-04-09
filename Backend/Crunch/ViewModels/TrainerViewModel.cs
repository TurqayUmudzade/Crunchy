using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crunch.Models;

namespace Crunch.ViewModels
{
    public class TrainerViewModel
    {
        public User user { get; set; }
        public List<Trainer> trainers { get; set; }
        public Trainer trainer { get; set; }
    }
}
