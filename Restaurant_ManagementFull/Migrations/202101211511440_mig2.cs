namespace Restaurant_ManagementFull.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Foods", "InvoiceDetails_Id", "dbo.InvoiceDetails");
            DropIndex("dbo.Foods", new[] { "InvoiceDetails_Id" });
            AddColumn("dbo.Invoices", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.InvoiceDetails", "Count", c => c.Int(nullable: false));
            AddColumn("dbo.InvoiceDetails", "FoodsId", c => c.Int(nullable: false));
            AddColumn("dbo.InvoiceDetails", "Food_Id", c => c.Int());
            CreateIndex("dbo.InvoiceDetails", "Food_Id");
            AddForeignKey("dbo.InvoiceDetails", "Food_Id", "dbo.Foods", "Id");
            DropColumn("dbo.InvoiceDetails", "NumberFood");
            DropColumn("dbo.InvoiceDetails", "Date");
            DropColumn("dbo.Foods", "InvoiceDetails_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "InvoiceDetails_Id", c => c.Int());
            AddColumn("dbo.InvoiceDetails", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.InvoiceDetails", "NumberFood", c => c.Int(nullable: false));
            DropForeignKey("dbo.InvoiceDetails", "Food_Id", "dbo.Foods");
            DropIndex("dbo.InvoiceDetails", new[] { "Food_Id" });
            DropColumn("dbo.InvoiceDetails", "Food_Id");
            DropColumn("dbo.InvoiceDetails", "FoodsId");
            DropColumn("dbo.InvoiceDetails", "Count");
            DropColumn("dbo.Invoices", "Amount");
            CreateIndex("dbo.Foods", "InvoiceDetails_Id");
            AddForeignKey("dbo.Foods", "InvoiceDetails_Id", "dbo.InvoiceDetails", "Id");
        }
    }
}
