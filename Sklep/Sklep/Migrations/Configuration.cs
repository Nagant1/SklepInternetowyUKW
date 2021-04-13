﻿namespace Sklep.Migrations
{
    using Sklep.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Sklep.DAL.FilmsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Sklep.DAL.FilmsContext";
        }

        protected override void Seed(Sklep.DAL.FilmsContext context)
        {
            FilmsInitializer.SeedFilmy(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
