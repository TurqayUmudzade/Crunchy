using System;
using System.Linq;
using Crunch.Data;
using Crunch.Models;
using Microsoft.AspNetCore.Mvc;
using Crunch.Areas.Admin.ViewModels;
using Crunch.Areas.Admin.Authentication;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;

namespace Crunch.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(CheckAdminAuth))]
    public class GymController : Controller
    {
        public readonly Context _context;
        //Access to wwwroot path
        private readonly IWebHostEnvironment _webHost;

        public GymController(Context context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;
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
        public async Task<IActionResult> AddGym(AdminGymViewModel model)
        {
            if (ModelState.IsValid)
            {
                Gym gym = new Gym()
                {
                    gymLocation = model.gym.gymLocation,
                    gymAdress = model.gym.gymAdress,
                    gymNumber = model.gym.gymNumber,
                    price = model.gym.price,
                };

                if (model.gym.Upload != null)
                {
                    gym.image = model.gym.Upload.FileName;
                    var saving = Path.Combine(_webHost.WebRootPath, "image/Location", model.gym.Upload.FileName);
                    string imgext = Path.GetExtension(model.gym.Upload.FileName);
                    if (imgext == ".jpg" || imgext == ".png")
                    {
                        using (var uploading = new FileStream(saving, FileMode.Create))
                        {
                            await model.gym.Upload.CopyToAsync(uploading);
                        }

                    }
                }

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
        public async Task<IActionResult> EditGym(Gym formGym)
        {
            if (ModelState.IsValid)
            {
                Gym gym = _context.gyms.Find(formGym.gymID);

                gym.gymAdress = formGym.gymAdress;
                gym.gymLocation = formGym.gymLocation;
                gym.gymNumber = formGym.gymNumber;
                gym.price = formGym.price;
                if (formGym.Upload != null)
                {
                    gym.image = formGym.Upload.FileName;

                    var saving = Path.Combine(_webHost.WebRootPath, "image/Location", formGym.Upload.FileName);
                    string imgext = Path.GetExtension(formGym.Upload.FileName);
                    if (imgext == ".jpg" || imgext == ".png")
                    {
                        using (var uploading = new FileStream(saving, FileMode.Create))
                        {
                            await formGym.Upload.CopyToAsync(uploading);
                        }

                    }
                }
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