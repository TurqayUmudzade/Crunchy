using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Crunch.Models;
using Crunch.Injection;

namespace Crunch.Controllers
{
    public class HomeController : Controller
    {

        private readonly IAuth _auth;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IAuth auth)
        {
            _logger = logger;
            _auth = auth;
        }

        public IActionResult Index()
        {

            if (_auth.User != null)
            {
                ViewData["Layout"] = "~/Views/Shared/UserLayout.cshtml";
                return View(_auth.User);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
