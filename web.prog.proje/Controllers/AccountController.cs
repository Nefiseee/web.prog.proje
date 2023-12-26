using web.prog.proje.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.prog.proje.Entity;
using web.prog.proje.Models;

namespace web.prog.proje.Controllers
{
        public class AccountController : Controller
        {
            private DataContext db = new DataContext();
            private UserManager<ApplicationUser> UserManager;
            private RoleManager<ApplicationRole> RoleManager;

            public AccountController()
            {
                var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
                UserManager = new UserManager<ApplicationUser>(userStore);

                var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
                RoleManager = new RoleManager<ApplicationRole>(roleStore);

            }

            // GET: Account
            public ActionResult Register()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Register(Register model)
            {
                if (ModelState.IsValid)
                {
                    //Kayıt işlemleri

                    var user = new ApplicationUser();
                    user.Name = model.Name;
                    user.Surname = model.SurName;
                    user.Email = model.Email;
                    user.UserName = model.UserName;

                    var result = UserManager.Create(user, model.Password);

                    if (result.Succeeded)
                    {
                        //kullanıcı oluştu ve kullanıcıyı bir role atayabilirsiniz.
                        if (RoleManager.RoleExists("user"))
                        {
                            UserManager.AddToRole(user.Id, "user");
                        }
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        ModelState.AddModelError("RegisterUserError", "Kullanıcı  oluşturma hatası.");
                    }

                }

                return View(model);
            }



        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = UserManager?.Find(model.UserName, model.Password);

                if (user != null)
                {
                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = model.RememberMe;
                    authManager.SignIn(authProperties, identityclaims);
                    ModelState.AddModelError("LoginUserError", "Geçersiz kullanıcı adı veya parola.");

                    if (!String.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "böyle bir kullanıcı yok");
                }

            }

            return View(model);

        }


            public ActionResult Logout()
            {
                var authManager = HttpContext.GetOwinContext().Authentication;
                authManager.SignOut();

                return RedirectToAction("Index", "Home");
            }

        }
    }

    