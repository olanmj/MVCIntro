using MVCIntro.Models;
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

        public ActionResult Misc()
        {
            string[] stringArray = { "apple", "orange", "banana",  "kiwi"};
            List<int> intList = new List<int> { 10, 20, 30, 40 };
            Dictionary<string, int> myDictionary = new Dictionary<string, int> { { "apple", 4131 }, { "orange", 3107 }, { "banana", 4011 } };
            ViewBag.Array = stringArray;
            ViewBag.List = intList;
            ViewBag.Dictionary = myDictionary;
            return View();
        }

        public ActionResult Funky(int count, string name)
        {
            ViewBag.Count = count;
            ViewBag.Name = "My name is " + name;
            return View();
        }

        [HttpGet]
        public ActionResult ShowProduct()
        {
            Product p = new Product {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 750M,
                Category = "Watersports"
            };

            //Product q = new Product
            //{
            //    ProductID = 101,
            //    Name = "Canoe",
            //    Description = "A boat for one or 2 persons",
            //    Price = 7500.78753M,
            //    Category = "Watersports"
            //};

            return View(p);
        }

        [HttpPost]
        public ActionResult ShowProduct(Product p)
        {
            if (ModelState.IsValid)
            {
                return View(p);
            }
            // Go back to the original Product 
            return ShowProduct();
        }

    }
}