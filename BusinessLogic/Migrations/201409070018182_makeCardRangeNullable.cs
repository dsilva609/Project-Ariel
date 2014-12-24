namespace BusinessLogic.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class makeCardRangeNullable : DbMigration
	{
		public override void Up()
		{
			AlterColumn("dbo.Card", "Range", c => c.Int(nullable: true, defaultValue: null));
		}

		public override void Down()
		{
			AlterColumn("dbo.Card", "Range", c => c.Int(nullable: false));
		}
	}
}
