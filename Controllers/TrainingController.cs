using Crunch.Injection;
using Microsoft.AspNetCore.Mvc;

namespace Crunch.Controllers
{

    public class TrainingController : Controller
    {
        private readonly IAuth _auth;

        public TrainingController(IAuth auth)
        {
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
    }
}