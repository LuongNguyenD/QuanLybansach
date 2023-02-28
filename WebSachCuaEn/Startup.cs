﻿using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity.EntityFramework;
using WebSachCuaEn.Identity;

[assembly: OwinStartup(typeof(WebSachCuaEn.Startup))]

namespace WebSachCuaEn
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
            this.CreateRolesAndUsers();
        }
        public void CreateRolesAndUsers()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new AppDBContext()));
            var appDBContext = new AppDBContext();
            var UserStore = new AppUserStore(appDBContext);
            var UsersManagers = new AppUserManager(UserStore);
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }
            if (UsersManagers.FindByName("admin") == null)
            {
                var user = new AppUser();
                user.UserName = "admin";
                user.Email = "admin@gmail.com";
                string userPwd = "admin123";

                var chkUser = UsersManagers.Create(user, userPwd);
                if (chkUser.Succeeded)
                {
                    UsersManagers.AddToRole(user.Id, "Admin");
                }
            }
            if (!roleManager.RoleExists("Manager"))
            {
                var role = new IdentityRole();
                role.Name = "Manager";
                roleManager.Create(role);
            }
            if (UsersManagers.FindByName("manager") == null)
            {
                var user = new AppUser();
                user.UserName = "manager";
                user.Email = "manager@gmail.com";
                string userPwd = "manager123";

                var chkUser = UsersManagers.Create(user, userPwd);
                if (chkUser.Succeeded)
                {
                    UsersManagers.AddToRole(user.Id, "Manager");
                }
            }
            if (!roleManager.RoleExists("Customer"))
            {
                var role = new IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);
            }

        }
    }
}
