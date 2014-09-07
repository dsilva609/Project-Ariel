namespace ProjectAriel.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class addCardExpansionStringProperty : DbMigration
	{
		public override void Up()
		{
			AddColumn("dbo.Card", "ExpansionString", c => c.String(nullable: true, defaultValue: null));
			AlterColumn("dbo.Card", "Expansion", c => c.Int(nullable: false));
		}

		public override void Down()
		{
			AlterColumn("dbo.Card", "Expansion", c => c.String());
			DropColumn("dbo.Card", "ExpansionString");
		}
	}
}
