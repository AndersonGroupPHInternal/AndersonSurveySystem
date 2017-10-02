using System;
using AndersonSurveySystemEntity;
using System.Data.Entity;

namespace AndersonSurveySystemContext
{
    public class Context : DbContext
    {
        public Context() : base("AndersonSurveySystem")
        {
            Database.SetInitializer(new DBInitializer());

            if (Database.Exists())
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>());
            }
            else
            {
                Database.SetInitializer(new DBInitializer());
            }
        }

        public DbSet<ESurvey> Survey { get; set; }
        public DbSet<EQuestion> Question { get; set; }
        public DbSet<EAnsweredQuestion> AnsweredQuestion { get; set; }
        public DbSet<EAnsweredSurvey> AnsweredSurvey { get; set; }

    }
}
