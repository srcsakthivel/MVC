using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC.GetStarted
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",                                                                    //Name
                url: "{controller}/{action}/{id}",                                                  //URL Parameter
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } //Defaults
            );
        }
    }
}
