using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andy06.Controllers
{
    public class PrinciplesController : Controller
    {
        // GET: Principles
       [RequireHttps]
        public ActionResult Index()
        {
            return View("PrinciplesView");
        }
    }
}