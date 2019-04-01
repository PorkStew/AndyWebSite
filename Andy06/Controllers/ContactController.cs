using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andy06.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View("ContactView");
        }
        [HttpPost]
        public ActionResult postusingparameters(string name, string emailAddress, string subject, string message)
        {
            Models.Contact s = new Models.Contact();
            s.name = name;
            s.emailAddress = emailAddress;
            s.subject = subject;
            s.message = message;
            s.sendEmail();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}