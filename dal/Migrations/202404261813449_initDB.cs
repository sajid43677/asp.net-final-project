namespace dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        nid = c.Int(nullable: false, identity: true),
                        reason = c.String(nullable: false, maxLength: 100),
                        carNo = c.String(nullable: false, maxLength: 50),
                        secId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.nid)
                .ForeignKey("dbo.Securities", t => t.secId, cascadeDelete: true)
                .Index(t => t.secId);
            
            CreateTable(
                "dbo.Securities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        phone = c.String(nullable: false, maxLength: 11),
                        password = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        sid = c.Int(nullable: false, identity: true),
                        position = c.String(nullable: false, maxLength: 50),
                        shift = c.String(nullable: false, maxLength: 50),
                        secId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sid)
                .ForeignKey("dbo.Securities", t => t.secId, cascadeDelete: true)
                .Index(t => t.secId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shifts", "secId", "dbo.Securities");
            DropForeignKey("dbo.Reports", "secId", "dbo.Securities");
            DropIndex("dbo.Shifts", new[] { "secId" });
            DropIndex("dbo.Reports", new[] { "secId" });
            DropTable("dbo.Shifts");
            DropTable("dbo.Securities");
            DropTable("dbo.Reports");
        }
    }
}
