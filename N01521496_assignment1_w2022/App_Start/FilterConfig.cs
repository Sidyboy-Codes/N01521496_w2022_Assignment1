using System.Web;
using System.Web.Mvc;

namespace N01521496_assignment1_w2022
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
