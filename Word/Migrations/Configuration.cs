namespace Word.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Word.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Word.Models.ApplicationDbContext context)
        {
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
            //context.UserManager.AddOrUpdate(
            //        p => p.Id,
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now},
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now },
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now },
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now },
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now },
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now },
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now },
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now },
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now },
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now },
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now },
            //        new Models.UserManager { Ten = "Hoang", BirthDay = DateTime.Now },
            //        new Models.UserManager { Ten = "Hieu", BirthDay = DateTime.Now }
            //    );
        }
    }
}
