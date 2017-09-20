using System;
using AndersonSurveySystemEntity;
using System.Data.Entity;

namespace AndersonSurveySystemContext
{
    public class Context : DbContext
    {
        public Context() : base("AndersonSurveySystemConnectionString")
        {
            Database.SetInitializer(new DBInitializer());

            if (Database.Exists())
            {
                //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>());
            }
            else
            {
                Database.SetInitializer(new DBInitializer());
            }
        }

        public class DBInitializer : CreateDatabaseIfNotExists<Context>
        {
            public DBInitializer()
            {
            }
        }
        public DbSet<ETypeOfQuestion> TypeOfQuestion { get; set; }
        public DbSet<ESurvey> Survey { get; set; }
        public DbSet<EQuestion> Question { get; set; }
        public DbSet<EAnsweredQuestion> AnsweredQuestion { get; set; }
        public DbSet<EAnsweredSurvey> AnsweredSurvey { get; set; }
        public DbSet<EAdmin>Admin { get; set; }
        public DbSet<EEmail> Emails { get; set; }
        public DbSet<ERate> Rate { get; set; }
        public DbSet<EComment> Comment { get; set; }

    }
}
