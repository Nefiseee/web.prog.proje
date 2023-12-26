using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using web.prog.proje.Identity;


namespace web.prog.proje.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            // Rolleri
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" }; 
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "Nefise"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "nefise", Surname = "abduresit", UserName = "Nefise", Email = "nefise@gmail.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "hatice"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "hatice", Surname = "bülbül", UserName = "hatice", Email = "hatice@gmail.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
            }



            base.Seed(context);
        }
    }
}