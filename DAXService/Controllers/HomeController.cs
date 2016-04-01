using DAXService.ActionFilters;
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

        /*public ActionResult ChangeLanguageDE()
        {
            CultureAttribute.SavePreferredCulture(HttpContext.Response, "DE");

            return View("Index");
        }*/

/*        public string getLanguage(HttpRequestBase httpRequestBase)
        {
            return CultureAttribute.GetSavedCultureOrDefault(httpRequestBase);
        }*/
        /*
        public ActionResult ChangeLanguageEN()
        {
            CultureAttribute.SavePreferredCulture(HttpContext.Response, "EN");

            return View("Index");
        }

        public ActionResult ChangeLanguageRU()
        {
            CultureAttribute.SavePreferredCulture(HttpContext.Response, "RU");

            return View("Index");
        }*/
    }
}