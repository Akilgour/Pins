namespace Pins.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PinLog_AddPinColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PinLogs", "PIN", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PinLogs", "PIN");
        }
    }
}
