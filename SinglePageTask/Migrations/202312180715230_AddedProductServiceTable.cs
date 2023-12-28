namespace SinglePageTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProductServiceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products_Service_Tbl",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(nullable: false),
                        Unit = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products_Service_Tbl");
        }
    }
}
