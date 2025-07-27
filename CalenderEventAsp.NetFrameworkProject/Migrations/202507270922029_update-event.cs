namespace CalenderEventAsp.NetFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateevent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "CategoryId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "CategoryId");
        }
    }
}
