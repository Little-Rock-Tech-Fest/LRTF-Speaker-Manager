namespace LRTFSpeakers.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PresStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Presentations", "Status", c => c.Int(nullable: false, defaultValue: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Presentations", "Status");
        }
    }
}
