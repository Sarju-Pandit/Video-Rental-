using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VideoRental
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Most specific route should be in the front , 
            //otherwise the most general route will be called

            //routes.MapRoute(
            //    name: "CustomRoute",
            //    url: "{controller}/{action}/{year}/{month}",
            //    new {controller="Movies", action="ByReleaseDate" }
            //  //  new {  year = @"\d{4}", month=@"\d{2}"}
            //    );
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
