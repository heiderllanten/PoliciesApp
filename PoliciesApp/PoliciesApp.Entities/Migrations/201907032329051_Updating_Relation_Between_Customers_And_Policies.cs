namespace PoliciesApp.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updating_Relation_Between_Customers_And_Policies : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Policies", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Policies", new[] { "CustomerId" });
            CreateTable(
                "dbo.CustomerPolicies",
                c => new
                    {
                        Customer_CustomerId = c.Int(nullable: false),
                        Policy_PolicyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Customer_CustomerId, t.Policy_PolicyId })
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Policies", t => t.Policy_PolicyId, cascadeDelete: true)
                .Index(t => t.Customer_CustomerId)
                .Index(t => t.Policy_PolicyId);
            
            DropColumn("dbo.Policies", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Policies", "CustomerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.CustomerPolicies", "Policy_PolicyId", "dbo.Policies");
            DropForeignKey("dbo.CustomerPolicies", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.CustomerPolicies", new[] { "Policy_PolicyId" });
            DropIndex("dbo.CustomerPolicies", new[] { "Customer_CustomerId" });
            DropTable("dbo.CustomerPolicies");
            CreateIndex("dbo.Policies", "CustomerId");
            AddForeignKey("dbo.Policies", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
        }
    }
}
