﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crunch.Data;
using Crunch.Injection;
using Crunch.Filters;
using Crunch.Models;
using Crunch.ViewModels;

namespace Crunch.Controllers
{
    public class MyMembershipController : Controller
    {

        private readonly Context _context;
        private readonly IAuth _auth;

        public MyMembershipController(Context context, IAuth auth)
        {
            _context = context;
            _auth = auth;
        }

        [TypeFilter(typeof(CheckAuth))]
        public IActionResult ChangeHomeGym()
        {
            User user = _context.users.Find(_auth.User.UserID);
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
            User user = _context.users.Find(_auth.User.UserID);
            user.gymLocation = location;
            _context.SaveChanges();
            return View("~/Views/MyGym/Home");
        }



        public IActionResult FreezeMemberShip()
        {
            return View();
        }

        public IActionResult CancelMemberShip()
        {
            return View();
        }

       
    }
}