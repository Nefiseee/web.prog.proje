using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace web.prog.proje.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}