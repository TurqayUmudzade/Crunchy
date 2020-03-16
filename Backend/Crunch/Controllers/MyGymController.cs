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


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            

            return View();
        }

        [HttpPost]
        [TypeFilter(typeof(CheckAuth))]
        public void SendEmail(Email email)
        {
            User loggedInUser = _context.users.Find(_auth.User.UserID);

            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("User", "testing@gmail.com");

            if (loggedInUser!=null) {
                 from = new MailboxAddress(loggedInUser.firstName, "testing@gmail.com");
            }
            
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("Admin", "crunchgymemailbot@gmail.com");
            message.To.Add(to);

            message.Subject = email.Subject;

            String text = "Nature of contact:" + email.Nature + "\r\nGym this enquiry relates to" + email.Gym + "\r\nThe Message:"+email.Body;

            message.Body = new TextPart("plain") { Text = text };


            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("crunchgymemailbot@gmail.com", "3008812t");
                client.Send(message);
                client.Disconnect(true);
            }
             
        }
    }
}