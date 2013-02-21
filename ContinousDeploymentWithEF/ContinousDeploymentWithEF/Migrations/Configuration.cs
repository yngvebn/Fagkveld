using ContinousDeploymentWithEF.Database;

namespace ContinousDeploymentWithEF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContinousDeploymentWithEF.Database.Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContinousDeploymentWithEF.Database.Db context)
        {
            context.Set<Person>().AddOrUpdate(new Person()
                {
                    Age = 32,
                    Name = "Yngve"

                }, new Person()
                    {
                        Name = "Harald",
                        Age = 42
                    });
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
