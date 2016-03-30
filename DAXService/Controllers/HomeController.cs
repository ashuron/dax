using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAXService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "DAX Service";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page";

            return View();
        }

    }
}