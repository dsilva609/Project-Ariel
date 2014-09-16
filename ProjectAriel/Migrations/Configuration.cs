namespace ProjectAriel.Migrations
{
	using ProjectAriel.Enums;
	using ProjectAriel.Models;
	using System.Data.Entity.Migrations;

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
				new Player { Name = "Liam Neeson", ID = 2, IsActive = true },
				new Player { Name = "Rachel McAdams", ID = 3, IsActive = true },
				new Player { Name = "Marky Mark and the Funky Bunch", ID = 4, IsActive = true }
				);

			#region Cards

			#region Roles
			context.Cards.AddOrUpdate(
				new Card { Name = "Sheriff", ID = 1, Expansion = Expansion.Standard, Cardtype = CardType.Role, IsActive = true },
				new Card { Name = "Deputy", ID = 2, Expansion = Expansion.Standard, Cardtype = CardType.Role, IsActive = true },
				new Card { Name = "Outlaw", ID = 3, Expansion = Expansion.Standard, Cardtype = CardType.Role, IsActive = true },
				new Card { Name = "Renegade", ID = 4, Expansion = Expansion.Standard, Cardtype = CardType.Role, IsActive = true }
			);
			#endregion

			#region Characters

			#endregion

			#region Playable Cards

			#region Weapons
			context.Cards.AddOrUpdate(
				new Card { Name = "Volcanic", Expansion = Expansion.Standard, Cardtype = CardType.Weapon, Range = 1, IsActive = true },
				new Card { Name = "Schofield", Expansion = Expansion.Standard, Cardtype = CardType.Weapon, Range = 2, IsActive = true },
				new Card { Name = "Remington", Expansion = Expansion.Standard, Cardtype = CardType.Weapon, Range = 3, IsActive = true },
				new Card { Name = "Rev. Carabine", Expansion = Expansion.Standard, Cardtype = CardType.Weapon, Range = 4, IsActive = true },
				new Card { Name = "Winchester", Expansion = Expansion.Standard, Cardtype = CardType.Weapon, Range = 5, IsActive = true }
			);
			#endregion

			#endregion

			#endregion

			context.Cards.AddOrUpdate(
									   new Card { Name = "Bang!", ID = 1, Cardtype = CardType.Basic, Description = "Kill 'Em All", Rank = Rank.Ace, Suit = Suit.Spade, ImageLocation = null, IsActive = true }
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
