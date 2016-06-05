namespace TvShowMicroservice.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TvShowMicroservice.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TvShowMicroservice.Data.DataContext context)
        {

        }
    }
}
