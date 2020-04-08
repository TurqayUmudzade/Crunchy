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
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Crunch.Controllers
{
    public class MyGymController : Controller
    {

        private readonly Context _context;
        private readonly IAuth _auth;

        public MyGymController(Context context, IAuth auth)
        {
            _context = context;
            _auth = auth;
        }

        [TypeFilter(typeof(CheckAuth))]
        public IActionResult Home()
        {
            User loggedInUser = _context.users.Find(_auth.User.UserID);
            return View(loggedInUser);
        }

        [TypeFilter(typeof(CheckAuth))]
        public IActionResult MyGymUsage()
        {
            User loggedInUser = _context.users.Find(_auth.User.UserID);
            return View(loggedInUser);
        }

        [TypeFilter(typeof(CheckAuth))]
        public IActionResult AverageUsage()
        {
            User loggedInUser = _context.users.Include(u => u.gym).Where(u => u.UserID == _auth.User.UserID).FirstOrDefault();
            return View(loggedInUser);
        }

        [HttpGet]
        [TypeFilter(typeof(CheckAuth))]
        public IActionResult Contact()
        {
            User loggedInUser = _context.users.Include(u => u.gym).Where(u => u.UserID == _auth.User.UserID).FirstOrDefault();
            ContactMemberViewModel model = new ContactMemberViewModel { user = loggedInUser };
            return View(model);
        }



        public void SendEmail(Email email, User loggedInUser)
        {
            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("User", "testing@gmail.com");

            if (loggedInUser != null)
            {
                from = new MailboxAddress(loggedInUser.firstName, "testing@gmail.com");
            }

            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("Admin", "crunchgymemailbot@gmail.com");
            message.To.Add(to);

            message.Subject = email.Subject;

            String text = "Nature of contact: " + email.Nature + "\r\nGym this enquiry relates to: " + email.Gym + "\r\nThe Message: " + email.Body;

            message.Body = new TextPart("plain") { Text = text };


            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("crunchgymemailbot@gmail.com", "3008812t");
                client.Send(message);
                client.Disconnect(true);
            }
        }

        [HttpPost]
        [TypeFilter(typeof(CheckAuth))]
        public async Task<IActionResult> Contact([FromForm]ContactMemberViewModel model)
        {
            User loggedInUser = _context.users.Find(_auth.User.UserID);
            model.user = _context.users.Include(u => u.gym).Where(u => u.UserID == _auth.User.UserID).FirstOrDefault();
            if (!ModelState.IsValid)
            {
                //fix this
                ModelState.AddModelError("Captcha", "Please click on the \"I'm not a robot\" checkbox");
                return View(model);
            }


            var result = await VerifyCaptcha(model.ReCaptcha);

            if (!result.Success)
            {
                ModelState.AddModelError("Captcha", "Please click on the \"I'm not a robot\" checkbox");

                return View(model);
            }
            SendEmail(model.email, loggedInUser);
            ViewBag.msg = "Email Was Sent";

            ContactMemberViewModel newModel = new ContactMemberViewModel()
            {
                user = _context.users.Include(u => u.gym).Where(u => u.UserID == _auth.User.UserID).FirstOrDefault()
            };
            return View(newModel);

        }


        /// verify the captcha's response with Google
        private async Task<CaptchaVerification> VerifyCaptcha(string captchaResponse)
        {
            string userIP = string.Empty;
            var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;
            if (ipAddress != null) userIP = ipAddress.MapToIPv4().ToString();

            var payload = string.Format("&secret={0}&remoteip={1}&response={2}", "6LeOf-EUAAAAAG6Lt40JwkIIv71LP8z7YUdxsdcf", userIP, captchaResponse);

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://www.google.com");
            var request = new HttpRequestMessage(HttpMethod.Post, "/recaptcha/api/siteverify")
            {
                Content = new StringContent(payload, Encoding.UTF8, "application/x-www-form-urlencoded")
            };

            var response = await client.SendAsync(request);
            return JsonConvert.DeserializeObject<CaptchaVerification>(response.Content.ReadAsStringAsync().Result);
        }
    }
}