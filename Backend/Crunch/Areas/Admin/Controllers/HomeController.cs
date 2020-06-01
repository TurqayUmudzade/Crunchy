using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crunch.Data;
using Crunch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Crunch.Areas.Admin.ViewModels;

namespace Crunch.Areas.Admin.Controllers
{


    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }

        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult Trainers()
        {

            AdminTrainersViewModel model = new AdminTrainersViewModel()
            {
                trainers = _context.trainers.Include(t => t.gym).ToList(),
                gyms = _context.gyms.ToList()
            };
            return View(model);
        }

        [Area("Admin")]
        [HttpPost]
        public IActionResult AddTrainer(AdminTrainersViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                Trainer trainer = new Trainer
                {
                    title = model.trainer.title,
                    fullName = model.trainer.fullName,
                    email = model.trainer.email,
                    aboutMe = model.trainer.aboutMe,
                    gym = _context.gyms.Find(model.trainer.gym.gymID),
                    Qualifications = model.trainer.Qualifications,
                    Speciality = model.trainer.Speciality,
                    image = model.trainer.image

                };
                _context.trainers.Add(trainer);
                _context.SaveChanges();
                TempData["Alert"] = "New Trainer added!";
                return RedirectToAction("Trainers", "Home", new { area = "Admin" });
            }
            else
            {
                
                var message = string.Join(" | ", ModelState.Values .SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                TempData["Alert"] = message;
                AdminTrainersViewModel returnModel = new AdminTrainersViewModel()
                {
                    trainers = _context.trainers.Include(t => t.gym).ToList(),
                    gyms = _context.gyms.ToList()
                };
                return View("Trainers", returnModel);
            }

           
        }
    }
}