namespace SinglePageTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Corporate_Customer_Tbl",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Individual_Customer_Tbl",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Individual_Customer_Tbl");
            DropTable("dbo.Corporate_Customer_Tbl");
        }
    }
}
