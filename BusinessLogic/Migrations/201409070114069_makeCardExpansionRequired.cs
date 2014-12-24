namespace BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeCardExpansionRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Card", "Expansion", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Card", "Expansion", c => c.Int());
        }
    }
}
