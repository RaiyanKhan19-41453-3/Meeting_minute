namespace SinglePageTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMeetingModelsAndDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meeting_Minutes_Master_Tbl",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerType = c.String(),
                        CustomerName = c.String(),
                        MeetingAgenda = c.String(),
                        MeetingDate = c.String(),
                        MeetingDiscussion = c.String(),
                        AttendsFromClientSide = c.String(),
                        MeetingDecision = c.String(),
                        AttendsFromHostSide = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Meeting_Minutes_Details_Tbl",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SL = c.Int(nullable: false),
                        ProductService = c.String(),
                        Unit = c.String(),
                        Quantity = c.Int(nullable: false),
                        meetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Meeting_Minutes_Master_Tbl", t => t.meetId, cascadeDelete: true)
                .Index(t => t.meetId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meeting_Minutes_Details_Tbl", "meetId", "dbo.Meeting_Minutes_Master_Tbl");
            DropIndex("dbo.Meeting_Minutes_Details_Tbl", new[] { "meetId" });
            DropTable("dbo.Meeting_Minutes_Details_Tbl");
            DropTable("dbo.Meeting_Minutes_Master_Tbl");
        }
    }
}
