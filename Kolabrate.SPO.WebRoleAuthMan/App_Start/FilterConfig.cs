using System.Web;
using System.Web.Mvc;

namespace Kolabrate.SPO.WebRoleAuthMan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
