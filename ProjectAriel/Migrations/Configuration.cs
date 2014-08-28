namespace ProjectAriel.Migrations
{
	using ProjectAriel.Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectAriel.DAL.ProjectArielContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectAriel.DAL.ProjectArielContext context)
        {
			context.Players.AddOrUpdate(
				new Player { Name = "Smitty Werbenjagermanjensen", ID = 1, IsActive = true },
				new Player { Name = "Liam Neeson", ID = 2, IsActive = true},
				new Player { Name = "Rachel McAdams", ID = 3, IsActive = true },
				new Player { Name = "Marky Mark and the Funky Bunch", ID = 4, IsActive = true }
				);

			context.Cards.AddOrUpdate(
				new Card { Name = "Bang!", ID = 1, Type = "Basic", Description = "Kill 'Em All", Rank = 'A', Suit = 'S', ImageLocation = null, IsActive = true }
				);
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
