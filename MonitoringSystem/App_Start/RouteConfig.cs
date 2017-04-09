using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MonitoringSystem
{   
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //показывает все предметы для группы
            routes.MapRoute(
                name: "toSubjects",
                url: "Subjects/{action}/{groupId}",
                defaults: new { controller = "Subjects", action = "Index", groupId = UrlParameter.Optional });

            //показывает оценки для всех студентов в группе по предмету
            routes.MapRoute(
                name: "toMarks",
                url: "Subjects/{action}/{groupId}/{subjectId}",
                defaults: new { controller = "Subjects", action = "Index",
                    groupId = UrlParameter.Optional,
                    subjectId = UrlParameter.Optional }
                );



            ///Default Route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
