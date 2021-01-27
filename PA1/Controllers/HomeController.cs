using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PA1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult SubtractionForm(Models.SubtractionModel sm)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Difference = sm.Minuend - sm.Subtrahend;
            }

            return View("Index");
        }
    }
}