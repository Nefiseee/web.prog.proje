using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using web.prog.proje.Entity;

namespace web.prog.proje.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection")
        {

        }
    }
}
