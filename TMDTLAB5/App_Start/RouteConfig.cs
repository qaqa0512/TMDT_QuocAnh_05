using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TMDTLAB5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               "Sitemap",
               "sitemap.xml",
               new { controller = "Sitemap", action = "Index" });
            //
            routes.MapRoute(
                name: "Category",
                url: "{Category}",
                defaults: new { controller = "Category", action = "Category", id = UrlParameter.Optional }
            );
            //
            routes.MapRoute(
              name: "News",
              url: "{Category}/{Alias}",
              defaults: new { controller = "News", action = "News", id = UrlParameter.Optional }
             );
            //
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
