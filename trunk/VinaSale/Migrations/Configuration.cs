using System.Collections.Generic;
using VinaSale.Models;

namespace VinaSale.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VinaSale.DAL.VinaSaleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(VinaSale.DAL.VinaSaleContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            context.Users.AddOrUpdate(
              new User { UserId = 1, UserName = "troyvnit", Password = "Asdcxz1+", DateOfBirth = new DateTime(1989, 6, 8), ProfilePicture = "/UserFiles/Images/logo.png" }
            );
            context.Brands.AddOrUpdate(
              new Brand { UserId = 1, BrandId = 1, BrandName = "Seft", Logo = "/UserFiles/Images/logo.png" }
            );
        }
    }
}
