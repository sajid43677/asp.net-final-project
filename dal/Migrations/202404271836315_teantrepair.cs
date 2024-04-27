namespace dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teantrepair : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        repairDetails = c.String(nullable: false, maxLength: 250),
                        status = c.String(nullable: false),
                        tid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Tenants", t => t.tid, cascadeDelete: true)
                .Index(t => t.tid);
            
            CreateTable(
                "dbo.Tenants",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        floorNo = c.Int(nullable: false),
                        flatNo = c.String(nullable: false),
                        uid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repairs", "tid", "dbo.Tenants");
            DropIndex("dbo.Repairs", new[] { "tid" });
            DropTable("dbo.Tenants");
            DropTable("dbo.Repairs");
        }
    }
}
