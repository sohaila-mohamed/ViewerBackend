using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "MetaData",
                url: "{MetaData}/{Get}",
                defaults: new { controller = "MetaData", action = "Get", id = UrlParameter.Optional }
            );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Thumbnails",
                url: "{Thumbnails}/{Get}/{ID}",
                defaults: new { controller = "Thumbnails", action = "Get", ID = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "ImageViewer",
                url: "{ImageViewer}/{Get}/{ID}",
                defaults: new { controller = "ImageViewer", action = "Get", ID = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
