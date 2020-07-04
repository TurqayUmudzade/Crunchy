using System;
using System.Linq;
using Crunch.Data;
using Crunch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Crunch.Areas.Admin.ViewModels;
using Crunch.Areas.Admin.Authentication;
//FILE
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;

namespace Crunch.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(CheckAdminAuth))]
    public class TrainerController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _webHost;

        public TrainerController(Context context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;
        }

        [HttpGet]
        public IActionResult FileDownload()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FileDownload([FromForm(Name = "file")] IFormFile file)
        {
            var saving = Path.Combine(_webHost.WebRootPath, "image/Trainers", file.FileName);
            string imgext = Path.GetExtension(file.FileName);
            if (imgext == ".jpg" || imgext == ".png")
            {
                using (var uploading = new FileStream(saving, FileMode.Create))
                {
                    await file.CopyToAsync(uploading);
                }

            }
            return View();
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
        public async Task<IActionResult> AddTrainer(AdminTrainersViewModel model)
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
                    image = model.trainer.Upload.FileName
                };

                var saving = Path.Combine(_webHost.WebRootPath, "image/Trainers", model.trainer.Upload.FileName) ;
                string imgext = Path.GetExtension(model.trainer.Upload.FileName);
                if (imgext == ".jpg" || imgext == ".png")
                {
                    using (var uploading = new FileStream(saving, FileMode.Create))
                    {
                       
                        await model.trainer.Upload.CopyToAsync(uploading);
                    }

                }

                _context.trainers.Add(trainer);
                _context.SaveChanges();
                TempData["Alert"] = "New Trainer added!";
                return RedirectToAction("Trainers", "Trainer", new { area = "Admin" });
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
        public async Task<IActionResult> EditTrainer(AdminTrainersViewModel model)
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

                if (!String.IsNullOrEmpty(model.trainer.Upload.FileName))
                {
                    trainer.image = model.trainer.Upload.FileName;

                    var saving = Path.Combine(_webHost.WebRootPath, "image/Trainers", model.trainer.Upload.FileName);
                    string imgext = Path.GetExtension(model.trainer.Upload.FileName);
                    if (imgext == ".jpg" || imgext == ".png")
                    {
                        using (var uploading = new FileStream(saving, FileMode.Create))
                        {

                            await model.trainer.Upload.CopyToAsync(uploading);
                        }

                    }
                }
                _context.SaveChanges();
                TempData["Alert"] = "Trainer Updated!";
                return RedirectToAction("Trainers", "Trainer", new { area = "Admin" });
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