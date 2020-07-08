#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Crunch.Areas.support.Controllers
{
    public class HomeController : Controller
    {
        [Area("Support")]
        public IActionResult Index()
        {
            return View();
        }
        [Area("Support")]
        public IActionResult Chat(string? ID)
        {


            return View((object?)ID);
        }
    }
}