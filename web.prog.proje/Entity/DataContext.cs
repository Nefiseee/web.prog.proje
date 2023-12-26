using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using web.prog.proje.Identity;
using web.prog.proje.Models;

namespace web.prog.proje.Entity
{
    public class DataContext: DbContext
    {
        public DataContext(): base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
            //Database.Initialize(true);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Hakkimizda>Hakkimizda { get; set; }

    }
}