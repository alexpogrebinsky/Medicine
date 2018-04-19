namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Frist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Dosage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MasterLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Inventory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Inventories", t => t.Inventory_ID)
                .Index(t => t.Inventory_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MasterLists", "Inventory_ID", "dbo.Inventories");
            DropIndex("dbo.MasterLists", new[] { "Inventory_ID" });
            DropTable("dbo.MasterLists");
            DropTable("dbo.Inventories");
        }
    }
}
