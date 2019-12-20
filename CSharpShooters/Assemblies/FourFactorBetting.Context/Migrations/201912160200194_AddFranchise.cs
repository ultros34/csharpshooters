namespace FourFactorBetting.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFranchise : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Franchises",
                c => new
                    {
                        FranchiseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Abbreviation = c.String(),
                        UrlName = c.String(),
                        Conference = c.Int(nullable: false),
                        Division = c.Int(nullable: false),
                        TeamIdentifier = c.String(),
                        Version = c.Binary(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FranchiseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Franchises");
        }
    }
}
