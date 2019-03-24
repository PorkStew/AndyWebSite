using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andy06.Controllers
{
    public class TopicsAndPrinciplesController : Controller
    {
        // GET: TopicsAndPrinciples
        public ActionResult Index()
        {
            return View("TopicsAndPrinciplesView");
        }
    }
}