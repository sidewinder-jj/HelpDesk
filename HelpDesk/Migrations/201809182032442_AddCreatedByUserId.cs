namespace HelpDesk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreatedByUserId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "CreatedByUserId", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "CreatedByUserId");
        }
    }
}
