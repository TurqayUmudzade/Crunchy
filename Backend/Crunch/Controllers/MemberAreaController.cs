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

        public MemberAreaController(Context context, IAuth auth)
        {
            _context = context;
            _auth = auth;
        }
        //Book Class
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult BookClass()
        {
            //Get the user
            User loggedInUser = _context.users.Include(u => u.gym).Where(u => u.UserID == _auth.User.UserID).FirstOrDefault();

            //Get the classes from Users Locations
            List<List<Class>> classesList = new List<List<Class>>();

            for (int i = 0; i < 7; i++)
            {
                classesList.Add(_context.classes.Where(c => c.gym == loggedInUser.gym && c.dateTime.Date == DateTime.Today.AddDays(i).Date).ToList());
            }


            BookClassViewModel model = new BookClassViewModel()
            {
                user = loggedInUser,
                classes = classesList
            };

            return View(model);
        }


        [HttpGet]
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult BookTheClass(int ClassID)
        {
            try
            {
                User user = _context.users.Find(_auth.User.UserID);
                Class selectedClass = _context.classes.Find(ClassID);
                if (selectedClass.spaceUsed < selectedClass.space)
                {

                    selectedClass.spaceUsed++;

                    selectedClass.userClasses = new List<UserClass>() {
                    new UserClass
                    {
                    user=user,
                    @class=selectedClass
                    }
                 };

                    _context.SaveChanges();

                    return PartialView("~/Views/PartialViews/ClassBooked.cshtml");
                }
                else
                {
                    return PartialView("~/Views/PartialViews/ClassSpaceFull.cshtml");
                }
            }
            catch (DbUpdateException)
            {
                return PartialView("~/Views/PartialViews/ClassAlreadyBooked.cshtml");
            }
        }

        //MyBookings
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult MyBookings()
        {
            User user = _context.users.Include(u => u.userClasses).Where(u => u.UserID == _auth.User.UserID).FirstOrDefault();

            List<Class> classes = new List<Class>();
            List<UserClass> userClasses = user.userClasses;

            foreach (UserClass userClass in userClasses)
            {
                Class @class = _context.classes.Include(c => c.gym).Where(c => c.ClassID == userClass.ClassID).FirstOrDefault();
                classes.Add(@class);
            }

            BookClassViewModel model = new BookClassViewModel
            {
                user = user,
                classesTable = classes
            };

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

            return View("~/Views/MemberArea/ChangeDetails", user);
        }

        //The page which redirects to Edit
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult ChangeDetails()
        {
            User user = _context.users.Find(_auth.User.UserID);
            return View(user);
        }

        [TypeFilter(typeof(CheckAuth))]
        public IActionResult Trainers()
        {
            TrainerViewModel model = new TrainerViewModel()
            {
                trainers = _context.trainers.ToList(),
                user = _context.users.Find(_auth.User.UserID)
            };
            return View(model);
        }

        [HttpGet]
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult AboutTrainer(int trainerID)
        {
            TrainerViewModel model = new TrainerViewModel()
            {
                trainer = _context.trainers.Find(trainerID),
                user = _context.users.Find(_auth.User.UserID)
            };
            return View(model);
        }

    }
}