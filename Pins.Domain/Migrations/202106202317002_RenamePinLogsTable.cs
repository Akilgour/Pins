namespace Pins.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamePinLogsTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Pins", newName: "PinLogs");
            DropColumn("dbo.PinLogs", "PIN");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PinLogs", "PIN", c => c.Int(nullable: false));
            RenameTable(name: "dbo.PinLogs", newName: "Pins");
        }
    }
}
