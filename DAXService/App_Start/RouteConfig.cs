using System.Web.Mvc;
using System.Web.Routing;

namespace DAXService
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("index", "index", new { controller = "Home", action = "Index" });
            routes.MapRoute("about", "about", new { controller = "Home", action = "About" });
            routes.MapRoute("references", "references", new { controller = "Home", action = "References" });
            routes.MapRoute("services", "services", new { controller = "Home", action = "Services" });
            routes.MapRoute("contact", "contact", new { controller = "Home", action = "Contact" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
