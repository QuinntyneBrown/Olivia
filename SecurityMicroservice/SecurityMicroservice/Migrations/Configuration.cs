namespace SecurityMicroservice.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SecurityMicroservice.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SecurityMicroservice.Data.DataContext context)
        {

        }
    }
}
