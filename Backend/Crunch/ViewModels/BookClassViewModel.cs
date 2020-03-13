using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crunch.Models;

namespace Crunch.ViewModels
{
    public class BookClassViewModel
    {
        User user { get; set; }

        List<List<Class>> classes{ get; set; }

    }
}
