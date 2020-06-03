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

    public class GymController : Controller
    {
        public readonly Context _context;

        public GymController(Context context)
        {
            _context = context;

        }

        [Area("Admin")]
        public IActionResult Index()
        {
            return RedirectToAction("Gyms");
        }

        [Area("Admin")]
        public IActionResult Gyms()
        {
            return View(new AdminGymViewModel {gyms=_context.gyms.ToList() });
        }

        [Area("Admin")]
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
    }
}