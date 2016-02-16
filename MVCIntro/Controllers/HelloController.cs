using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index(int id)
        {
            ViewBag.Value = id;
            return View();
        }
    }
}