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
    public class MemberAreaController : Controller
    {

        private readonly Context _context;
        private readonly IAuth _auth;

        public MemberAreaController(Context context, IAuth auth) {

            _context = context;
            _auth = auth;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [TypeFilter(typeof(CheckAuth))]
        public ContentResult BookTheClass(int ClassID)
        {
            Class selectedClass = _context.classes.Find(ClassID);
            selectedClass.spaceUsed++;
            _context.SaveChanges();

            return Content(ClassID.ToString());

        }


        [TypeFilter(typeof(CheckAuth))]
        public IActionResult BookClass()
        {
            //Get the user
            User loggedInUser = _context.users.Find(_auth.User.UserID);

            //Get the classes from Users Locations
            List<List<Class>> classesList = new List<List<Class>>();

            for (int i = 0; i < 7; i++) {
                classesList.Add(_context.classes.Where(c => c.gymLocation == loggedInUser.gymLocation && c.dateTime.Date == DateTime.Today.AddDays(i).Date).ToList());
            }


            BookClassViewModel model = new BookClassViewModel() {
                user = loggedInUser,
                classes = classesList
            };

            String s = "";
            foreach (List<Class> item in classesList)
            {
                s += item.Count.ToString();
            }

            return View(model);
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
        public IActionResult EditUser(User editedUser) {

            User user = _context.users.Find(_auth.User.UserID);

            user.Gender = editedUser.Gender;
            user.Email = editedUser.Email;
            user.number = editedUser.number;
            user.Town = editedUser.Town;
            user.Postcode = editedUser.Postcode;
            user.recieveEmail = editedUser.recieveEmail;
            user.recieveSMS = editedUser.recieveSMS;

            _context.SaveChanges();

            return View("~/Views/MemberArea/ChangeDetails", user);
        }

        //The page which redirects to Edit
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult ChangeDetails() {
            User user = _context.users.Find(_auth.User.UserID);
            return View(user);
        }


        public IActionResult Trainers()
        {
            List<Trainer> trainers= _context.trainers.ToList();

            return View(trainers);
        }

        [HttpGet]
        public IActionResult AboutTrainer(int trainerID)
        {
           Trainer trainer=_context.trainers.Find(trainerID);   

            return View(trainer);
        }

    }
}