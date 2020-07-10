using Microsoft.AspNetCore.Mvc;
using Crunch.Data;
using Crunch.Injection;

namespace Crunch.Controllers
{
    public class FaqController : Controller
    {

        private readonly Context _context;
        private readonly IAuth _auth;


        public FaqController(Context context, IAuth auth)
        {
            _context = context;
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