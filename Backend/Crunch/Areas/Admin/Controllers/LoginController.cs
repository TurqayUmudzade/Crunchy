using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crunch.ViewModels;
using Crunch.Data;
using Crunch.Models;
using Crunch.Injection;
using Crunch.Filters;

namespace Crunch.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context _context;
        private readonly IAuth _auth;

        public LoginController(Context context, IAuth auth)
        {
            _context = context;
            _auth = auth;

        }
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult Login()
        {

            return View();
        }


    }
}