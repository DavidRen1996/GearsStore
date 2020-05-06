namespace GearsStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SiteInit1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExternalRegister = c.Boolean(nullable: false),
                        EmailAddress = c.String(),
                        Birthday = c.String(),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameName = c.String(),
                        GamePrice = c.Single(nullable: false),
                        GameReleasedDate = c.String(),
                        GameDescription = c.String(),
                        GameVideoLink = c.String(),
                        Customer_Id = c.Int(),
                        Customer_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id1)
                .Index(t => t.Customer_Id)
                .Index(t => t.Customer_Id1);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Customer_Id1", "dbo.Customers");
            DropForeignKey("dbo.Games", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Games", new[] { "Customer_Id1" });
            DropIndex("dbo.Games", new[] { "Customer_Id" });
            DropTable("dbo.Managers");
            DropTable("dbo.Games");
            DropTable("dbo.Customers");
        }
    }
}
