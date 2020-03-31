﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crunch.Data;
using Crunch.Injection;
using Crunch.Filters;
using Crunch.Models;
using Crunch.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Crunch.Controllers
{
    public class LocationsController : Controller
    {

        private readonly Context _context;

        public LocationsController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.gyms.ToList());
        }

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
            else {
                return PartialView("~/Views/PartialViews/GymList.cshtml", _context.gyms.ToList());
            }
        }

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