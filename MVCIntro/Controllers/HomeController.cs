using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult  Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Purveyors of the finest dumpster diving finds since 1985!";
            ViewBag.AnotherMessage = "You know you want some.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "The Junk Shop";

            return View();
        }
    }
}