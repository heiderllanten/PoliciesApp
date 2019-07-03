namespace PoliciesApp.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoverageTypes",
                c => new
                    {
                        CoverageTypeId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        PolicyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CoverageTypeId)
                .ForeignKey("dbo.Policies", t => t.PolicyId, cascadeDelete: true)
                .Index(t => t.PolicyId);
            
            CreateTable(
                "dbo.Policies",
                c => new
                    {
                        PolicyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ValidityBeginning = c.DateTime(nullable: false),
                        CoveragePeriod = c.Int(nullable: false),
                        Coverage = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        RiskType = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PolicyId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Policies", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CoverageTypes", "PolicyId", "dbo.Policies");
            DropIndex("dbo.Policies", new[] { "CustomerId" });
            DropIndex("dbo.CoverageTypes", new[] { "PolicyId" });
            DropTable("dbo.Customers");
            DropTable("dbo.Policies");
            DropTable("dbo.CoverageTypes");
        }
    }
}
