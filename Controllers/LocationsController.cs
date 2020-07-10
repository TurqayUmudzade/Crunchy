using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Crunch.Data;
using Crunch.Models;
using Crunch.Injection;
using Crunch.ViewModels;

namespace Crunch.Controllers
{
    public class LocationsController : Controller
    {

        private readonly Context _context;
        private readonly IAuth _auth;


        public LocationsController(Context context, IAuth auth)
        {
            _auth = auth;
            _context = context;
        }

        //Front Locations Page
        public IActionResult Index()
        {
            ChangeGymViewModel model = new ChangeGymViewModel()
            {
                gyms = _context.gyms.ToList()
            };

            if (_auth.User != null)
            {
                model.user = _auth.User;

                ViewData["Layout"] = "~/Views/Shared/_LayoutViewModelUser.cshtml";
                return View(model);
            }


            return View(model);
        }

        //Full gym informations after search or select
        public IActionResult selectFill(string searchStr)
        {
            //format the string to match database type of Name first capital and other lower
            if (!string.IsNullOrEmpty(searchStr))
            {
                searchStr = searchStr.ToLower();
                char first = char.ToUpper(searchStr[0]);
                searchStr = first + searchStr.Substring(1);
                List<Gym> model = _context.gyms.Where(g => g.gymLocation.StartsWith(searchStr)).ToList();
                return PartialView("~/Views/PartialViews/GymList.cshtml", model);
            }
            else
            {
                return PartialView("~/Views/PartialViews/GymList.cshtml", _context.gyms.ToList());
            }
        }

        //GYM names for autofill
        public IActionResult search(string searchStr)
        {
            //format the string to match database type of Name first capital and other lower
            if (!string.IsNullOrEmpty(searchStr))
            {
                var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
                searchStr = searchStr.ToLower();
                char first = char.ToUpper(searchStr[0]);
                searchStr = first + searchStr.Substring(1);
                List<Gym> model = _context.gyms.Where(g => g.gymLocation.StartsWith(searchStr)).ToList();
                return PartialView("~/Views/PartialViews/GymLocationList.cshtml", model);
            }
            else
            {
                return PartialView("~/Views/PartialViews/GymLocationList.cshtml", _context.gyms.ToList());
            }
        }
    }
}