using System.Web;
using System.Web.Mvc;

namespace Assignment2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // force all http request to use ssl
            filters.Add(new RequireHttpsAttribute());


        }
    }
}
