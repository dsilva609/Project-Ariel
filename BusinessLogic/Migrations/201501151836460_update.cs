namespace BusinessLogic.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class update : DbMigration
	{
		public override void Up()
		{
			//CreateTable(
			//	"dbo.Card",
			//	c => new
			//		{
			//			ID = c.Int(nullable: false, identity: true),
			//			Name = c.String(nullable: false),
			//			Description = c.String(),
			//			Action = c.String(),
			//			Expansion = c.Int(nullable: false),
			//			ExpansionString = c.String(),
			//			Cardtype = c.Int(nullable: false),
			//			CardTypeString = c.String(),
			//			Suit = c.Int(nullable: false),
			//			SuitString = c.String(),
			//			Rank = c.Int(nullable: false),
			//			RankString = c.String(),
			//			Range = c.Int(),
			//			ImageLocation = c.String(),
			//			IsActive = c.Boolean(nullable: false),
			//		})
			//	.PrimaryKey(t => t.ID);

			//CreateTable(
			//	"dbo.Player",
			//	c => new
			//		{
			//			ID = c.Int(nullable: false, identity: true),
			//			Name = c.String(nullable: false),
			//			IsActive = c.Boolean(nullable: false),
			//		})
			//	.PrimaryKey(t => t.ID);

		}

		public override void Down()
		{
			DropTable("dbo.Player");
			DropTable("dbo.Card");
		}
	}
}
