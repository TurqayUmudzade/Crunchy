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
    [Area("Admin")]
    public class TrainerController : Controller
    {
        private readonly Context _context;

        public TrainerController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Trainers");
        }

        //TRAINERS

        //VIEW 
        public IActionResult Trainers()
        {

            AdminTrainersViewModel model = new AdminTrainersViewModel()
            {
                trainers = _context.trainers.Include(t => t.gym).ToList(),
                gyms = _context.gyms.ToList()
            };
            return View(model);
        }

        //ADD TRAINER
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

                var message = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                TempData["Alert"] = message;
                AdminTrainersViewModel returnModel = new AdminTrainersViewModel()
                {
                    trainers = _context.trainers.Include(t => t.gym).ToList(),
                    gyms = _context.gyms.ToList()
                };
                return View("Trainers", returnModel);
            }


        }
        //UPDATE TRAINER
        public IActionResult EditTrainer(int trainerID)
        {
            Trainer trainer = _context.trainers.Include(t => t.gym).SingleOrDefault(t => t.ID == trainerID);
            return View(new AdminTrainersViewModel { trainer = trainer, gyms = _context.gyms.ToList() });
        }

        [HttpPost]
        public IActionResult EditTrainer(AdminTrainersViewModel model)
        {

            if (ModelState.IsValid)
            {
                Trainer trainer = _context.trainers.Find(model.trainer.ID);
                trainer.fullName = model.trainer.fullName;
                trainer.title = model.trainer.title;
                trainer.gym = _context.gyms.Find(model.trainer.gym.gymID);
                trainer.aboutMe = model.trainer.aboutMe;
                trainer.email = model.trainer.email;
                trainer.Qualifications = model.trainer.Qualifications;
                trainer.Speciality = model.trainer.Speciality;

                if (!String.IsNullOrEmpty(model.trainer.image))
                {
                    trainer.image = model.trainer.image;
                }
                _context.SaveChanges();
                TempData["Alert"] = "Trainer Updated!";
                return RedirectToAction("Trainers", "Home", new { area = "Admin" });
            }
            else
            {
                var message = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                TempData["Alert"] = message;
                return Content(message);
            }
        }

        [HttpGet]
        public IActionResult DeleteTrainer(int trainerID)
        {
            _context.Remove(_context.trainers.Find(trainerID));
            _context.SaveChanges();
            string s = "Trainer Deleted";
            return PartialView("~/Views/PartialViews/alert.cshtml", s);
        }
    }
}