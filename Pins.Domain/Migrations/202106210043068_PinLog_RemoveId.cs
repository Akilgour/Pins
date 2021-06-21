namespace Pins.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PinLog_RemoveId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PinLogs");
            AlterColumn("dbo.PinLogs", "PIN", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.PinLogs", "PIN");
            DropColumn("dbo.PinLogs", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PinLogs", "Id", c => c.Guid(nullable: false));
            DropPrimaryKey("dbo.PinLogs");
            AlterColumn("dbo.PinLogs", "PIN", c => c.String());
            AddPrimaryKey("dbo.PinLogs", "Id");
        }
    }
}
