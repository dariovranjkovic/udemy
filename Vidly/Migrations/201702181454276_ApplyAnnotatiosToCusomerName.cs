namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotatiosToCusomerName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.MembershipTypes", "DurationInMoths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DurationInMoths", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "DurationInMonths");
        }
    }
}
