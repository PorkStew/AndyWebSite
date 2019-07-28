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
      // [RequireHttps]
        public ActionResult Index()
        {
            
            return View("ContactView");
        }
        [HttpPost]
        public ActionResult postusingparameters(string name, string emailAddress, string subject, string body)
        {
            Models.Contact s = new Models.Contact();
            s.Name = name;
            s.EmailAddress = emailAddress;
            s.Subject = subject;
            s.GetMessage = body;
            s.sendEmail();
            //add error checking
            //return Content("<script language='javascript' type='text/javascript'>alert ('Email successfully sent I will be in contact with you as soon as possible! ');</script>");
            
            return RedirectToAction("Index", "Home");
        }
    }
}