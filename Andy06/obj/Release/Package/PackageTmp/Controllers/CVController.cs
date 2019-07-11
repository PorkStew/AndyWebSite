using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andy06.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        [RequireHttps]
        public ActionResult Index()
        {
            return View("CVview");
        }
    }
}