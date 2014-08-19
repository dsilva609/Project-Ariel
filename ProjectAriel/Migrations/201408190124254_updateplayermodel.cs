namespace ProjectAriel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateplayermodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Player", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Player", "Name", c => c.String());
        }
    }
}
