using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crunch.ViewModels;
using Crunch.Data;
using Crunch.Models;

namespace Crunch.Controllers
{
    public class AccountController : Controller
    {
        private readonly Context _context;


        public AccountController(Context context)
        {
            _context = context;

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
                        Postcode = registerViewModel.User.firstName,
                        dateOfBirth = registerViewModel.User.dateOfBirth,
                        Gender = registerViewModel.User.Gender,
                        disability = registerViewModel.User.disability,
                        // Token = Guid.NewGuid().ToString()

                    };
                    _context.users.Add(user);
                    _context.SaveChanges();

                    //because we the id is 0 in our object whethers its not like that in the database
                    registerViewModel.User = _context.users.Where(u => u.Email == user.Email).FirstOrDefault();

                    
                    return View("~/Views/Account/Register2.cshtml", registerViewModel);
                }
                ModelState.AddModelError("Email", "Bu e-poçt artıq qeydiyyatdan keçib");
            }
            return View(registerViewModel);
        }
        [HttpPost]
        public IActionResult Register2(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {


                User user = _context.users.Find(registerViewModel.User.UserID);
                user.gymLocation = registerViewModel.User.gymLocation;
                user.premiumMemberShip = registerViewModel.User.premiumMemberShip;
               


                _context.SaveChanges();



            }
            return Content(registerViewModel.User.premiumMemberShip.ToString());
        }

    }
}