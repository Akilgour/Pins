namespace Pins.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PinLog_ChangeIdType : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PinLogs");
            AddColumn("dbo.PinLogs", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.PinLogs", "PIN", c => c.String());
            AddPrimaryKey("dbo.PinLogs", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PinLogs");
            AlterColumn("dbo.PinLogs", "PIN", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.PinLogs", "Id");
            AddPrimaryKey("dbo.PinLogs", "PIN");
        }
    }
}
