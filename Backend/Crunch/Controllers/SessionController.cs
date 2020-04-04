using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Crunch.Models;
using Newtonsoft.Json;

namespace Crunch.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {

            Trainer t = new Trainer()
            {
                fullName = "Trainer NAme",
                Speciality = "seopcita",
                image = "imagedsad"
            };
            HttpContext.Session.SetString("SesionTrainr", JsonConvert.SerializeObject(t));


            return View();
        }

        public IActionResult Test()
        {
            var info = JsonConvert.DeserializeObject<Trainer>(HttpContext.Session.GetString("SesionTrainr"));


            return View(info);
        }

    }
}