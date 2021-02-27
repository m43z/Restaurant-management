namespace Restaurant_ManagementFull.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.InvoiceDetails", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Invoices", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Invoices", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.InvoiceDetails", "Price");
            DropColumn("dbo.Invoices", "Date");
        }
    }
}
