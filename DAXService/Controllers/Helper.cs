using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAXService.Controllers
{
    public static class Helper
    {
        public static string getLanguage(string language)
        {
            return language ?? "EN";
        }
    }
}