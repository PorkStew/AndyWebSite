using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andy06.Controllers
{
    public class DownloadsController : Controller
    {
        // GET: Downloads
      [RequireHttps]
        public ActionResult Index()
        {
            return View("DownloadsView");
        }
        //public FileResult Download()
        //{
        //    return new FilePathResult(Server.MapPath("/Images/dummy.docx"), "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        //}
    }
}