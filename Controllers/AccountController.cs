﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Crunch.ViewModels;
using Crunch.Data;
using Crunch.Models;
using Crunch.Injection;
using Crunch.Filters;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using MailKit.Net.Smtp;
using MimeKit;

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
        public IActionResult Register2()
        {
            if (HttpContext.Session.GetString("SessionUser") == null)
            {
                return RedirectToAction("Register", "Account");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Register3()
        {
            if (HttpContext.Session.GetString("SessionUser") == null)
            {
                return RedirectToAction("Register", "Account");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (TempData["PinNotification"] != null)
            {
                ViewBag.Text = TempData["PinNotification"].ToString();
                ViewBag.Email = TempData["PinNotificationSpan"].ToString();
            }
            if (_auth.User != null)
            {
                return RedirectToAction("Home", "MyGym");
            }

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


                    HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));

                    registerViewModel.gyms = _context.gyms.ToList();


                    return View("~/Views/Account/Register2.cshtml", registerViewModel);
                }
                ModelState.AddModelError("Email", "This Email is taken");
            }

            return View(registerViewModel);
        }

        [HttpPost]
        public IActionResult Register2(RegisterViewModel registerViewModel)
        {
            if (registerViewModel.gym != null)
            {
                User user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
                user.gym = _context.gyms.Find(registerViewModel.gym.gymID);
                user.premiumMemberShip = registerViewModel.User.premiumMemberShip;

                string promocode = registerViewModel.User.promocode.promocode;
                if (!string.IsNullOrEmpty(promocode))
                {
                    if (_context.promocodes.Any(p => p.promocode == promocode))
                    {
                        user.promocode = Discount(promocode, _context);
                    }
                }

                HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));

                RegisterViewModel model = new RegisterViewModel()
                {
                    User = user,
                    gym = user.gym
                };

                return View("~/Views/Account/Register3.cshtml", model);
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
            if (registerViewModel.User != null)
            {
                User user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
                user.paymentOption = registerViewModel.User.paymentOption;
                user.pin = newPin(_context);

                //IF its the first time adding ,add a user or it will timeout so uncomment this
                //user.pin = "123";
                user.Token = Guid.NewGuid().ToString();


                //to avoid entity relation errors
                int gymId = user.gym.gymID;
                user.gym = _context.gyms.Find(gymId);
                if (user.promocode != null) { user.promocode = _context.promocodes.Where(p => p.promocode == user.promocode.promocode).FirstOrDefault(); }

                user.membershipActiveTill = DateTime.Now.AddMonths(1);
                user.active = true;
                _context.Add(user);
                _context.SaveChanges();

                HttpContext.Session.Remove("SessionUser");

                String text = "Your pin is " + user.pin;

                SendEmail(user, text);

                TempData["PinNotification"] = "Your Pin has been send to your email adress ";
                TempData["PinNotificationSpan"] = user.Email.ToString();

                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View(registerViewModel);
            }

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

                        Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                        {
                            Expires = logingInViewModel.RememberMe ? DateTime.Now.AddYears(1) : DateTime.Now.AddDays(1),
                            HttpOnly = true
                        });

                        return RedirectToAction("Home", "MyGym");
                    }

                }
                ModelState.AddModelError("Pin", "Wrong email or password");
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

            return RedirectToAction("Login");
        }

        //generate a number pin with a size of 8
        static public String PinGenerator()
        {

            Random rand = new Random();
            String pin = Math.Round((rand.NextDouble() * Math.Pow(10, 8))).ToString();

            return pin;
        }

        static public String newPin(Context context)
        {
            string pin;

            while (true)
            {
                pin = PinGenerator();
                //check if the pin doesnt belong to another user
                if (!context.users.All(u => u.pin == pin))
                {
                    break;
                }
            }

            return pin;
        }


        //PROMOCODE
        static public Promocode Discount(string promocode, Context _context)
        {
            Promocode p = new Promocode();

            p = _context.promocodes.Where(p => p.promocode == promocode).FirstOrDefault();

            if (p == null)
            {
                return null;
            }

            if (p.OneTime)
            {
                p.IsUsed = true;
            }

            //Check if it has an expiration date
            if (p.Expire != null)
            {
                if (DateTime.Compare(p.Expire, DateTime.Now) != 1)//if it expired
                {
                    return null;
                }
            }
            return p;
        }

        //Returns view of promocodes information either an error or the x% will be applied   
        public IActionResult Promo(string promo)
        {
            Promocode p = Discount(promo, _context);

            return PartialView("~/Views/PartialViews/PromoStatus.cshtml", p);
        }

        public void SendEmail(User user, String text)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Crunch", "crunchgymemailbot@gmail.com");

            if (user != null)
            {
                from = new MailboxAddress(user.firstName, "testing@gmail.com");
            }
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("user", user.Email);
            message.To.Add(to);

            message.Body = new TextPart("plain") { Text = text };

            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("crunchgymemailbot@gmail.com", "3008812t");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}