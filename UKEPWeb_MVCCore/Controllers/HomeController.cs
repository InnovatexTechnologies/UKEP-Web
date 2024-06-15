using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using UKEPWeb_MVCCore.Models;

namespace UKEPWeb_MVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Name, string Email, string Subject, string Message)
        {
            // mail code
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("marwarisoftware@gmail.com");
            mail.To.Add("ukepinternational@gmail.com");
            mail.Subject = "Contact Mail (UKEP Website)";

            mail.Body = "Name : " + Name + Environment.NewLine + "Email Id : " + Email + Environment.NewLine + "Subject : " + Subject + Environment.NewLine + "Message : " + Message;

            SmtpServer.Port = 587;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.UseDefaultCredentials = true;
            SmtpServer.Credentials = new System.Net.NetworkCredential("marwarisoftware@gmail.com", "ilwtnwrwogtlxmxz");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(string Name, string Email, string Subject, string Message)
        {
            // mail code
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("marwarisoftware@gmail.com");
            mail.To.Add("ukepinternational@gmail.com");
            mail.Subject = "Contact Mail (UKEP Website)";

            mail.Body = "Name : " + Name + Environment.NewLine + "Email Id : " + Email + Environment.NewLine + "Subject : " + Subject + Environment.NewLine + "Message : " + Message;

            SmtpServer.Port = 587;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.UseDefaultCredentials = true;
            SmtpServer.Credentials = new System.Net.NetworkCredential("marwarisoftware@gmail.com", "ilwtnwrwogtlxmxz");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult FerroAlloy()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult NonFerrous()
        {
            return View();
        }
        public IActionResult ScrapandMetallics()
        {
            return View();
        }
        public IActionResult SemiFinished()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
    }
}