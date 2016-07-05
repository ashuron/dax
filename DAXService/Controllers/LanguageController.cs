using DAXService.ActionFilters;
using System;
using System.Web.Mvc;

namespace DAXService.Controllers
{
    public class LanguageController : Controller
    {
        public void Set(String lang)
        {
            CultureAttribute.SavePreferredCulture(HttpContext.Response, lang);

            HttpContext.Response.Redirect(HttpContext.Request.UrlReferrer.AbsolutePath);
        }
    }
}