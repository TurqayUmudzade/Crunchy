using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Crunch.Models;
using Crunch.ViewModels;
using Crunch.Data;

namespace Crunch.Controllers
{
    public class ClassesController : Controller
    {
        private readonly Context _context;


        public ClassesController(Context context)
        {

            _context = context;
        }
        public IActionResult Index()
        {
            ClassesViewModel model = new ClassesViewModel
            {
                gyms = _context.gyms.ToList()
            };


            return View(model);
        }

        public IActionResult testfunction(int gymID)
        {
            //Get the classes from Users Locations
            List<List<Class>> classesList = new List<List<Class>>();

            for (int i = 0; i < 7; i++)
            {
                classesList.Add(_context.classes.Where(c => c.gym.gymID == gymID && c.dateTime.Date == DateTime.Today.AddDays(i).Date).ToList());
            }


            BookClassViewModel model = new BookClassViewModel()
            {

                classes = classesList
            };
            return PartialView("~/Views/Shared/ClassInfo.cshtml", model);
        }
    }
}