namespace Composition
{
    public class DbMigrator
    {
        private readonly Logger logger;

        // Composition used for loose coupling
        public DbMigrator(Logger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.Log("We are migrating ...");
        }
    }
}
