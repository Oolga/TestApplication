using System.Web;
using System.Web.Mvc;

namespace Test_application_iTechArt
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
