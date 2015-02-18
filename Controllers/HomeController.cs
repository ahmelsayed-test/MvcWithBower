using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace MvcWithBower.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.BowerStatus = System.IO.File.Exists(HostingEnvironment.MapPath(@"~\bower_components\jquery\dist\jquery.js"))
                ? "Bower was restored"
                : "bower wasn't restored";
            return View();
        }
    }
}