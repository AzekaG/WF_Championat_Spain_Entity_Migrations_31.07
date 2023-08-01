namespace WF_Championat_Spain_Entity_Migrations_31._07.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WF_Championat_Spain_Entity_Migrations_31._07.Model.MatchDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WF_Championat_Spain_Entity_Migrations_31._07.Model.MatchDbContext";
        }

        protected override void Seed(WF_Championat_Spain_Entity_Migrations_31._07.Model.MatchDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
