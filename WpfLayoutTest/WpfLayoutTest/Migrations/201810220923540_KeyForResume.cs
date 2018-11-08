namespace WpfLayoutTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KeyForResume : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resumes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FullTime = c.Boolean(nullable: false),
                        KnowsCSharp = c.Boolean(nullable: false),
                        KnowsCPlusPlus = c.Boolean(nullable: false),
                        KnowsJavaScript = c.Boolean(nullable: false),
                        Role = c.String(),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Resumes");
        }
    }
}
