namespace Online_Assessment_Project.DomainModel.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineAssessmentProject.DomainModel.AssessmentPortalDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OnlineAssessmentProject.DomainModel.AssessmentPortalDbContext";
        }

        protected override void Seed(OnlineAssessmentProject.DomainModel.AssessmentPortalDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
