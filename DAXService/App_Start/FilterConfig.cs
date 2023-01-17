using DynaSoft.ActionFilters;
using System.Web.Mvc;

namespace DynaSoft
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CultureAttribute());
        }
    }
}
