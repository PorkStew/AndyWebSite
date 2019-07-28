using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andy06.Controllers
{
    public class ExpertWitnessTopicsController : Controller
    {
        // GET: ExpertWitnessTopics
       [RequireHttps]
        public ActionResult Index()
        {
            return View("ExpertWitnessTopicsView");
        }
    }
}