namespace ConsoleApp42_Interfaces_and_Extensibility;

public class DbMigrator
{
    private readonly ILogger _logger;
    
    //Constructor
    public DbMigrator(ILogger logger)   //in Constructor we inject the interface, this technique is called Dependency Injection
                                        //which means in the Constructor we are specifying the dependencies for this DbMigrator class
    {
        _logger = logger;
    }
    public void Migrate()
    {
        _logger.LogInfo("Migration started at {0}" + DateTime.Now);
        // details of migrating the db
        _logger.LogInfo("Migration finished at {0}" + DateTime.Now);

    }
}