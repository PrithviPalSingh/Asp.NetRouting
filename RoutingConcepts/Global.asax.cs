using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingConcepts
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static string[] ViewLocation
        {
            get
            {
                return new[] { "~/Areas/Schemes/Views/{0}.cshtml", "~/Areas/Schemes/Views/{1}/{0}.cshtml",
                "~/Areas/Services/Views/{0}.cshtml", "~/Areas/Services/Views/{1}/{0}.cshtml",
                "~/Areas/Misc/Views/{0}.cshtml", "~/Areas/Misc/Views/{1}/{0}.cshtml",
                "~/Areas/blog/Views/{0}.cshtml", "~/Areas/blog/Views/{1}/{0}.cshtml",
                "~/Areas/dashboard/Views/{0}.cshtml", "~/Areas/dashboard/Views/{1}/{0}.cshtml"};
            }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var razorEngine = ViewEngines.Engines.OfType<RazorViewEngine>().First();
            razorEngine.ViewLocationFormats = razorEngine.ViewLocationFormats.Concat(ViewLocation).ToArray();
        }
    }
}
