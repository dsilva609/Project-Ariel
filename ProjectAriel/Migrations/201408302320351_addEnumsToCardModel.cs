namespace ProjectAriel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEnumsToCardModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Card", "CardType", c => c.Int(nullable: false));
            AddColumn("dbo.Card", "SuitEnum", c => c.Int(nullable: false));
            AddColumn("dbo.Card", "RankEnum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Card", "RankEnum");
            DropColumn("dbo.Card", "SuitEnum");
            DropColumn("dbo.Card", "CardType");
        }
    }
}
