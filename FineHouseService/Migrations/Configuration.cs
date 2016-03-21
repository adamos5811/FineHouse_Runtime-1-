namespace FineHouseService.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FineHouseService.Models;
    using FineHouseService.DataObjects;

    internal sealed class Configuration : DbMigrationsConfiguration<FineHouseService.Models.FineHouseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FineHouseService.Models.FineHouseContext";
        }

        protected override void Seed(FineHouseService.Models.FineHouseContext context)
        {

            var manager = new UserManager<User>(new UserStore<User>(new FineHouseContext()));

            var user = new User()
            {
                UserName = "SuperPowerUser",
                Email = "taiseer.joudeh@mymail.com",
                EmailConfirmed = true,  
                FirstName = "Taiseer",
                LastName = "Joudeh",
                Level = 1,

            };

            manager.Create(user, "MySuperP@ssword!");
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
