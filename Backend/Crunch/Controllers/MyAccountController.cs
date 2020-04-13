using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Crunch.Data;
using Crunch.Injection;
using Crunch.Filters;
using Crunch.Models;
using Crunch.ViewModels;

namespace Crunch.Controllers
{
    public class MyAccountController : Controller
    {
        private readonly Context _context;
        private readonly IAuth _auth;

        public MyAccountController(Context context, IAuth auth)
        {
            _context = context;
            _auth = auth;
        }

        //Edit View
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult Edit()
        {
            User user = _context.users.Find(_auth.User.UserID);
            return View(user);
        }
        //Form method
        [HttpPost]
        public IActionResult EditUser(User editedUser)
        {
            User user = _context.users.Find(_auth.User.UserID);

            user.Gender = editedUser.Gender;
            user.Email = editedUser.Email;
            user.number = editedUser.number;
            user.Town = editedUser.Town;
            user.Postcode = editedUser.Postcode;
            user.recieveEmail = editedUser.recieveEmail;
            user.recieveSMS = editedUser.recieveSMS;

            _context.SaveChanges();
            return View("ChangeDetails", user);
        }

        //The page which redirects to Edit
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult ChangeDetails()
        {
            User user = _context.users.Find(_auth.User.UserID);
            return View(user);
        }

        //
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult ChangeHomeGym()
        {
            User user = _context.users.Include(u => u.gym).Where(u => u.UserID == _auth.User.UserID).FirstOrDefault();
            List<Gym> gyms = _context.gyms.ToList();
            ChangeGymViewModel model = new ChangeGymViewModel
            {
                user = user,
                gyms = gyms
            };

            return View(model);
        }


        [HttpPost]
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult Change(string location)
        {
            User user = _context.users.Include(u => u.gym).Where(u => u.UserID == _auth.User.UserID).FirstOrDefault();
            user.gym = _context.gyms.Where(g => g.gymLocation == location).FirstOrDefault();
            _context.SaveChanges();
            return View("~/Views/MyGym/Home");
        }
    }
}