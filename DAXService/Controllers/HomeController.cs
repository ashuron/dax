using System.Web.Mvc;

namespace DynaSoft.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Dyna-Soft";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = @Resources.Home.about;

            return View();
        }

        public ActionResult Team()
        {
            ViewBag.Message = @Resources.Home.team;

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