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
using Microsoft.EntityFrameworkCore;

namespace Crunch.Controllers
{
    public class AccountController : Controller
    {
        private readonly Context _context;
        private readonly IAuth _auth;


        public AccountController(Context context, IAuth auth)
        {
            _context = context;
            _auth = auth;

        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Register2()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Register3()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                if (!_context.users.Any(u => u.Email == registerViewModel.User.Email))
                {
                    User user = new User
                    {
                        firstName = registerViewModel.User.firstName,
                        lastName = registerViewModel.User.lastName,
                        Email = registerViewModel.User.Email,
                        number = registerViewModel.User.number,
                        Town = registerViewModel.User.Town,
                        Postcode = registerViewModel.User.Postcode,
                        dateOfBirth = registerViewModel.User.dateOfBirth,
                        Gender = registerViewModel.User.Gender,
                        disability = registerViewModel.User.disability
                    };

                    _context.users.Add(user);
                    _context.SaveChanges();

                    //because we the id is 0 in our object whethers its not like that in the database
                    registerViewModel.User = _context.users.Where(u => u.Email == user.Email).FirstOrDefault();
                    registerViewModel.gyms = _context.gyms.ToList();

                    return View("~/Views/Account/Register2.cshtml", registerViewModel);
                }
                ModelState.AddModelError("Email", "this email is taken");
            }
            return View(registerViewModel);
        }

        [HttpPost]
        public IActionResult Register2(RegisterViewModel registerViewModel)
        {
            if (true)
            {
                User user = _context.users.Find(registerViewModel.User.UserID);
                user.gym = _context.gyms.Find(registerViewModel.gym.gymID);
                user.premiumMemberShip = registerViewModel.User.premiumMemberShip;

                registerViewModel.User = user;
                registerViewModel.gym = _context.users.Include("gym").Where(u => u.UserID == user.UserID).FirstOrDefault().gym;

                _context.SaveChanges();

                return View("~/Views/Account/Register3.cshtml", registerViewModel);
            }
            else
            {
                registerViewModel.gyms = _context.gyms.ToList();
                return View(registerViewModel);
            }

        }

        [HttpPost]
        public IActionResult Register3(RegisterViewModel registerViewModel)
        {
            if (true)
            {

                User user = _context.users.Find(registerViewModel.User.UserID);
                user.paymentOption = registerViewModel.User.paymentOption;
                user.pin = PinGenerator();

                user.Token = Guid.NewGuid().ToString();
                _context.SaveChanges();

                Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    Expires = DateTime.Now.AddYears(1),
                    HttpOnly = true
                });
                return RedirectToAction("Login", "Account");
            }
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public IActionResult Login(LogingInViewModel logingInViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = _context.users.Where(u => u.Email == logingInViewModel.Email).FirstOrDefault();

                if (user != null)
                {
                    //not hashing for the door
                    if (user.pin == logingInViewModel.Pin)
                    {

                        user.Token = Guid.NewGuid().ToString();
                        _context.SaveChanges();

                        logingInViewModel.RememberMe = true;
                        Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                        {
                            Expires = logingInViewModel.RememberMe ? DateTime.Now.AddYears(1) : DateTime.Now.AddDays(1),
                            HttpOnly = true
                        });

                        return RedirectToAction("index", "home");
                    }
                    ModelState.AddModelError("Pin", "Wrong email or password");
                }

            }

            return View(logingInViewModel);
        }


        [TypeFilter(typeof(CheckAuth))]
        public IActionResult Logout()
        {
            User user = _context.users.Find(_auth.User.UserID);
            user.Token = null;
            _context.SaveChanges();

            Response.Cookies.Delete("token");

            return RedirectToAction("index");
        }

        //generate a number pin with a size of 8
        static public String PinGenerator()
        {
            Random rand = new Random();
            String pin = Math.Round((rand.NextDouble() * Math.Pow(10, 8 + 1))).ToString();

            return pin;
        }

    }
}