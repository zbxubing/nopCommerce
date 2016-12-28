namespace Nop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSeller : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seller",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SellerGuid = c.Guid(nullable: false),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                //.ForeignKey("dbo.Customer", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Seller", "Customer_Id", "dbo.Customer");
            DropIndex("dbo.Seller", new[] { "Customer_Id" });
            DropTable("dbo.Seller");
        }
    }
}
