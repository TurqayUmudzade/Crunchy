using System.Collections.Generic;
using Crunch.Models;

namespace Crunch.ViewModels
{
    public class BookClassViewModel
    {
        public User user { get; set; }

        public List<List<Class>> classes { get; set; }

        public List<Class> classesTable { get; set; }

    }
}
