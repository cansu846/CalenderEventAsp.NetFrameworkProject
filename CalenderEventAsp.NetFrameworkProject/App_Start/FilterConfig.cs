using System.Web;
using System.Web.Mvc;

namespace CalenderEventAsp.NetFrameworkProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
