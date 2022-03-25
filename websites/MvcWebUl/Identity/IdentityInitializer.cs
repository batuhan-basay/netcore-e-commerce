using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MvcWebUl.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcWebUl.Identity
{
    public class IdentityInitializer: CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            // rolleri

            if (!context.Roles.Any(i=> i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager =new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "admin", Description="admin rolu" };

                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Description = "user rolu" };

                manager.Create(role);
            }

            if (!context.Users.Any(i => i.UserName == "batuhanbasay"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Batuhan", Surname = "Basay", UserName="batuhanbasay", Email="basaybatuhan@gmail.com"};


                manager.Create(user,"1234");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.UserName == "ruveydaakcinar"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Ruveyda Hilal", Surname = "Akçınar", UserName = "ruveydaakcinar", Email = "ruveydaakcinar@gmail.com" };


                manager.Create(user, "1234");
                manager.AddToRole(user.Id, "user");
            }
            // user
            base.Seed(context);
        }
    }
}