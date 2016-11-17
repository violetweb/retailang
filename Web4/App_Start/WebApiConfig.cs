﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace App.Web4
{

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
 
           
     
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
               name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",   
                defaults: new { id = RouteParameter.Optional}
           );

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
           

            // Remove the XML formatter
            config.Formatters.Remove(config.Formatters.XmlFormatter);


        }
    }
}