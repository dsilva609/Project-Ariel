namespace ProjectAriel.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class addCardTypeStringToCardModel : DbMigration
	{
		public override void Up()
		{
			AddColumn("dbo.Card", "CardTypeString", c => c.String(nullable: true, defaultValue: null));
		}

		public override void Down()
		{
			DropColumn("dbo.Card", "CardTypeString");
		}
	}
}
