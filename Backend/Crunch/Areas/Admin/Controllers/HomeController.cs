using Crunch.Data;
using Microsoft.AspNetCore.Mvc;
using Crunch.Areas.Admin.Authentication;
namespace Crunch.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(CheckAdminAuth))]
    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            return View();
        }


    }
}