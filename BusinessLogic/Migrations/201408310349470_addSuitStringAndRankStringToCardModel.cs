namespace BusinessLogic.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class addSuitStringAndRankStringToCardModel : DbMigration
	{
		public override void Up()
		{
			AddColumn("dbo.Card", "SuitString", c => c.String(nullable: true, defaultValue: null));
			AddColumn("dbo.Card", "RankString", c => c.String(nullable: true, defaultValue: null));
		}

		public override void Down()
		{
			DropColumn("dbo.Card", "RankString");
			DropColumn("dbo.Card", "SuitString");
		}
	}
}
