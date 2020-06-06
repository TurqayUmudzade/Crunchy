using System;
using System.Collections.Generic;
using System.Linq;
using Crunch.Data;
using Crunch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Crunch.Areas.Admin.ViewModels;

namespace Crunch.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GymController : Controller
    {
        public readonly Context _context;

        public GymController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Gyms");
        }

        public IActionResult Gyms()
        {
            return View(new AdminGymViewModel { gyms = _context.gyms.ToList() });
        }

        [HttpPost]
        public IActionResult AddGym(AdminGymViewModel model)
        {
            if (ModelState.IsValid)
            {
                Gym gym = new Gym()
                {
                    gymLocation = model.gym.gymLocation,
                    gymAdress = model.gym.gymAdress,
                    gymNumber = model.gym.gymNumber,
                    price = model.gym.price,
                    image = model.gym.image

                };

                _context.gyms.Add(gym);
                _context.SaveChanges();

                TempData["Alert"] = "New Gym added!";
                return RedirectToAction("Gyms", "Gym", new { area = "Admin" });
            }
            else
            {

                var message = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                TempData["Alert"] = message;
                return RedirectToAction("Gyms", "Gym", new { area = "Admin" });
            }

        }

        public IActionResult EditGym(int gymID)
        {
            return View(_context.gyms.Find(gymID));
        }

        [HttpPost]
        public IActionResult EditGym(Gym formGym)
        {
            if (ModelState.IsValid)
            {
                Gym gym = _context.gyms.Find(formGym.gymID);

                gym.gymAdress = formGym.gymAdress;
                gym.gymLocation = formGym.gymLocation;
                gym.gymNumber = formGym.gymNumber;
                gym.price = formGym.price;
                if (!String.IsNullOrEmpty(formGym.image))
                    gym.image = formGym.image;

                _context.SaveChanges();

                TempData["Alert"] = "Gym Updated!";
                return RedirectToAction("Gyms", "Gym", new { area = "Admin" });
            }
            else
            {
                var message = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                TempData["Alert"] = message;
                return RedirectToAction("Gyms", "Gym", new { area = "Admin" });
            }

        }

        [HttpGet]
        public IActionResult DeleteGym(int gymID)
        {
            _context.Remove(_context.gyms.Find(gymID));
            _context.SaveChanges();
            string s = "Gym Deleted";
            return PartialView("~/Views/PartialViews/alert.cshtml", s);
        }
    }
}