﻿using System.Web.Mvc;

namespace Hivyppp.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "admin_default",
                "admin/{action}/{id}",
                new { controller="admin", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}