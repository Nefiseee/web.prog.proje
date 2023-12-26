using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.Identity.EntityFramework;
using web.prog.proje.Entity;
using web.prog.proje.Identity;

namespace web.prog.proje
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            Database.SetInitializer(new DataInitializer());
            Database.SetInitializer(new IdentityInitializer());
        }
    }
}
