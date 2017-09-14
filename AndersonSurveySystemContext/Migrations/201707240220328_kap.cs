namespace AndersonSurveySystemContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        AdminName = c.String(maxLength: 250),
                        UserName = c.String(maxLength: 250),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            AddColumn("dbo.AnsweredSurvey", "EAdmin_AdminId", c => c.Int());
            CreateIndex("dbo.AnsweredSurvey", "EAdmin_AdminId");
            AddForeignKey("dbo.AnsweredSurvey", "EAdmin_AdminId", "dbo.Admin", "AdminId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AnsweredSurvey", "EAdmin_AdminId", "dbo.Admin");
            DropIndex("dbo.AnsweredSurvey", new[] { "EAdmin_AdminId" });
            DropColumn("dbo.AnsweredSurvey", "EAdmin_AdminId");
            DropTable("dbo.Admin");
        }
    }
}
