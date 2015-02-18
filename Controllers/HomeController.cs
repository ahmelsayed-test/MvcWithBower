using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWithBower.Controllers
{
    public class HomeController : Controller
    {
        // GET: HOme
        public ActionResult Index()
        {

            return View();
        }
    }
}