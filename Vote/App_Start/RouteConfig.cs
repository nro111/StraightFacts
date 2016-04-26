using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vote
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            #region dashboards

            routes.MapRoute(
                name: "Dashboard",
                url: "Dashboard/{action}",
                defaults: new { controller = "Dashboard", action = "Index"}
            );

            #region national level dashboards

            routes.MapRoute(
                name: "National__Executive_Level_Dashboard",
                url: "Views/Dashboard/National_Level_Dashboard/{action}",
                defaults: new { controller = "National_Level_Dashboard", action = "Executive_Dashboard", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "National_Legislative_Level_Dashboard",
                url: "Views/Dashboard/National_Level_Dashboard/{action}",
                defaults: new { controller = "National_Level_Dashboard", action = "Legislative_Dashboard", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "National_Judicial_Level_Dashboard",
                url: "Views/Dashboard/National_Level_Dashboard/{action}",
                defaults: new { controller = "National_Level_Dashboard", action = "Judicial_Dashboard", id = UrlParameter.Optional }
            );

            #endregion

            #region state level dashboards
            routes.MapRoute(
                name: "State_Level_Dashboard",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "State_Level_Dashboard", action = "Index", id = UrlParameter.Optional }
            );
            #endregion  

            #region local level dashboards
            routes.MapRoute(
                name: "Local_Level_Dashboard",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Local_Level_Dashboard", action = "Index", id = UrlParameter.Optional }
            );
            #endregion

            #endregion            

        }
    }
}
