using System;
using System.Collections.Generic;
using System.Linq;
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
                    new UserClass{ user=user,@class=selectedClass }
                    };

                    _context.SaveChanges();


                    ViewBag.Msg = "Great, you are booked into this class";
                    ViewBag.Type = "1";//Give cancel option
                    ViewBag.ClassID = ClassID;
                    return PartialView("~/Views/PartialViews/ClassBooked.cshtml");
                }
                else
                {
                    ViewBag.Msg = "No space avaliable";
                    return PartialView("~/Views/PartialViews/ClassBooked.cshtml");
                }
            }
            catch (DbUpdateException)
            {
                ViewBag.Msg = "You already booked this class";
                ViewBag.Type = "1";//Give cancel option
                ViewBag.ClassID = ClassID;

                return PartialView("~/Views/PartialViews/ClassBooked.cshtml");
            }
        }

        //Canceling class and removing it from DB
        [HttpGet]
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult Cancel(int ClassID)
        {
            User user = _context.users.Include(u => u.userClasses).Where(u => u.UserID == _auth.User.UserID).FirstOrDefault();
            Class selectedClass = _context.classes.Find(ClassID);
            selectedClass.spaceUsed--;

            List<UserClass> userClasses = user.userClasses;
            UserClass userClass = new UserClass();

            foreach (UserClass uc in userClasses.ToList())//Tolist because the value is modified during the loop
            {
                if (uc.ClassID == ClassID && uc.UserID == user.UserID)
                {
                    //Find entity and delete it
                    _context.users.Include(u => u.userClasses).FirstOrDefault(u => u.UserID == _auth.User.UserID).userClasses.Remove(uc);
                }
            }

            _context.SaveChanges();

            return PartialView("~/Views/PartialViews/CancelClass.cshtml");
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



        //Trainers

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