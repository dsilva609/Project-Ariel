namespace ProjectAriel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madeCardExpansionNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Card", "Expansion", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Card", "Expansion", c => c.Int(nullable: false));
        }
    }
}
