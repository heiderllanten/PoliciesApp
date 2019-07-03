namespace PoliciesApp.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updating_Policies_and_Coverage_Type_Relation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CoverageTypes", "PolicyId", "dbo.Policies");
            DropIndex("dbo.CoverageTypes", new[] { "PolicyId" });
            CreateTable(
                "dbo.PolicyCoverageTypes",
                c => new
                    {
                        Policy_PolicyId = c.Int(nullable: false),
                        CoverageType_CoverageTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Policy_PolicyId, t.CoverageType_CoverageTypeId })
                .ForeignKey("dbo.Policies", t => t.Policy_PolicyId, cascadeDelete: true)
                .ForeignKey("dbo.CoverageTypes", t => t.CoverageType_CoverageTypeId, cascadeDelete: true)
                .Index(t => t.Policy_PolicyId)
                .Index(t => t.CoverageType_CoverageTypeId);
            
            DropColumn("dbo.CoverageTypes", "PolicyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CoverageTypes", "PolicyId", c => c.Int(nullable: false));
            DropForeignKey("dbo.PolicyCoverageTypes", "CoverageType_CoverageTypeId", "dbo.CoverageTypes");
            DropForeignKey("dbo.PolicyCoverageTypes", "Policy_PolicyId", "dbo.Policies");
            DropIndex("dbo.PolicyCoverageTypes", new[] { "CoverageType_CoverageTypeId" });
            DropIndex("dbo.PolicyCoverageTypes", new[] { "Policy_PolicyId" });
            DropTable("dbo.PolicyCoverageTypes");
            CreateIndex("dbo.CoverageTypes", "PolicyId");
            AddForeignKey("dbo.CoverageTypes", "PolicyId", "dbo.Policies", "PolicyId", cascadeDelete: true);
        }
    }
}
