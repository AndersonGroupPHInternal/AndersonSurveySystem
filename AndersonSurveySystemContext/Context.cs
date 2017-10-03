using AndersonSurveySystemEntity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<ESurvey> Survey { get; set; }
        public DbSet<EQuestion> Question { get; set; }
        public DbSet<EAnsweredQuestion> AnsweredQuestion { get; set; }
        public DbSet<EAnsweredSurvey> AnsweredSurvey { get; set; }

    }
}
