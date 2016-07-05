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
            ViewBag.Message = @Resources.Home.about;

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = @Resources.Home.services;

            return View();
        }

        public ActionResult References()
        {
            ViewBag.Message = @Resources.Home.references;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = @Resources.Home.contact;

            return View();
        }

    }
}