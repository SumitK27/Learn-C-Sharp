namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger logger;

        // Dependency Injection
        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }
        public void Migrate()
        {
            logger.LogInfo($"Migration started at {DateTime.Now}");
            logger.LogInfo("Migrating...");
            logger.LogInfo($"Migration ended at {DateTime.Now}");
        }
    }
}
