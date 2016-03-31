using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAXService.Controllers
{
    public class HomeController : Controller
    {
        string language;

        public ActionResult Index()
        {
            ViewBag.Title = "DAX Service";
            ViewBag.Language = language;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About page";
            ViewBag.Language = language;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page";
            ViewBag.Language = language;

            return View();
        }

        public ActionResult ChangeLanguageDE()
        {
            language = "DE";

            ViewBag.Language = "DE";

            return View("Index");
        }

        public ActionResult ChangeLanguageEN()
        {
            language = "EN";

            ViewBag.Language = "EN";

            return View("Index");
        }

        public ActionResult ChangeLanguageRU()
        {
            language = "RU";

            ViewBag.Language = "RU";

            return View("Index");
        }
    }
}