using System.Web;
using System.Web.Mvc;

namespace Asp.NetMvc5ConceitosBasicos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
