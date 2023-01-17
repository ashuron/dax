using System;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace DynaSoft.ActionFilters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class CultureAttribute : ActionFilterAttribute
    {
        private const string CookieLangEntry = "language";

        public string Name { get; set; }

        public static string CookieName
        {
            get { return "_Language"; }
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var culture = Name;
            if (string.IsNullOrEmpty(culture))
            {
                culture = GetSavedCultureOrDefault(filterContext.RequestContext.HttpContext.Request);
            }
            // Set culture on current thread
            SetCultureOnThread(culture);

            // Proceed as usual
            base.OnActionExecuting(filterContext);
        }

        public static void SavePreferredCulture(HttpResponseBase response, string language,
                                                Int32 expireDays = 1)
        {
            var cookie = new HttpCookie(CookieName) { Expires = DateTime.Now.AddDays(expireDays) };
            cookie.Values[CookieLangEntry] = language;
            response.Cookies.Add(cookie);
        }

        public static string GetSavedCultureOrDefault(HttpRequestBase httpRequestBase)
        {
            var culture = "EN";
            var cookie = httpRequestBase.Cookies[CookieName];
            if (cookie != null)
            {
                culture = cookie.Values[CookieLangEntry];
            }

            return culture;
        }

        private static void SetCultureOnThread(string language)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}