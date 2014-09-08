namespace ProjectAriel.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class addPropertiesToCardModel : DbMigration
	{
		public override void Up()
		{
			AddColumn("dbo.Card", "Action", c => c.String(nullable: true, defaultValue: null));
			AddColumn("dbo.Card", "Expansion", c => c.String(nullable: true, defaultValue: null));
			AddColumn("dbo.Card", "Range", c => c.Int(nullable: true, defaultValue: null));
		}

		public override void Down()
		{
			DropColumn("dbo.Card", "Range");
			DropColumn("dbo.Card", "Expansion");
			DropColumn("dbo.Card", "Action");
		}
	}
}
