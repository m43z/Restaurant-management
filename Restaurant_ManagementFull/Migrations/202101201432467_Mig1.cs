namespace Restaurant_ManagementFull.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenderId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Mobile = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lookups", t => t.GenderId)
                .Index(t => t.GenderId);
            
            CreateTable(
                "dbo.Lookups",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Title = c.String(),
                        GourpId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberFood = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        InvoiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId, cascadeDelete: true)
                .Index(t => t.InvoiceId);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeFoodId = c.Int(nullable: false),
                        Title = c.String(),
                        Decreption = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InvoiceDetails_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lookups", t => t.TypeFoodId)
                .ForeignKey("dbo.InvoiceDetails", t => t.InvoiceDetails_Id)
                .Index(t => t.TypeFoodId)
                .Index(t => t.InvoiceDetails_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceDetails", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.Foods", "InvoiceDetails_Id", "dbo.InvoiceDetails");
            DropForeignKey("dbo.Foods", "TypeFoodId", "dbo.Lookups");
            DropForeignKey("dbo.Invoices", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "GenderId", "dbo.Lookups");
            DropIndex("dbo.Foods", new[] { "InvoiceDetails_Id" });
            DropIndex("dbo.Foods", new[] { "TypeFoodId" });
            DropIndex("dbo.InvoiceDetails", new[] { "InvoiceId" });
            DropIndex("dbo.Invoices", new[] { "CustomerId" });
            DropIndex("dbo.Customers", new[] { "GenderId" });
            DropTable("dbo.Foods");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.Invoices");
            DropTable("dbo.Lookups");
            DropTable("dbo.Customers");
        }
    }
}
