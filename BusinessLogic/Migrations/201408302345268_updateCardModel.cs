namespace BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCardModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Card", "Suit", c => c.Int(nullable: false));
            AddColumn("dbo.Card", "Rank", c => c.Int(nullable: false));
            DropColumn("dbo.Card", "Type");
            DropColumn("dbo.Card", "SuitEnum");
            DropColumn("dbo.Card", "RankEnum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Card", "RankEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Card", "SuitEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Card", "Type", c => c.String());
            DropColumn("dbo.Card", "Rank");
            DropColumn("dbo.Card", "Suit");
        }
    }
}
