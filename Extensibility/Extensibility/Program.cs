namespace Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            var dbMigratorFile = new DbMigrator(new FileLogger(@"F:\logs.txt"));
            dbMigratorFile.Migrate();
        }
    }
}
