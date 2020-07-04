using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Crunch.Data;
using Crunch.Areas.Admin.Authentication;
using Crunch.Areas.Admin.Models;

namespace Crunch.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly Context _context;
        private readonly IAdminAuth _auth;

        public LoginController(Context context, IAdminAuth auth)
        {
            _context = context;
            _auth = auth;

        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(AdminM model)
        {
            if (ModelState.IsValid)
            {
                AdminM admin = _context.Admins.Where(a => a.Username == model.Username).FirstOrDefault();

                if (admin != null)
                {
                    if (admin.Password == model.Password)
                    {

                        admin.Token = Guid.NewGuid().ToString();
                        _context.SaveChanges();

                        Response.Cookies.Append("Admintoken", admin.Token, new Microsoft.AspNetCore.Http.CookieOptions
                        {
                            Expires = DateTime.Now.AddDays(1),
                            HttpOnly = true
                        });

                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }

                }
                ModelState.AddModelError("Pass", "Wrong username or password");
            }

            return View(model);
        }


    }
}