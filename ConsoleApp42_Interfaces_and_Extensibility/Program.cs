using System.IO;

namespace ConsoleApp42_Interfaces_and_Extensibility
{
    //Task: create a DbMigrator class that has a method that logs to console infos about the migration process (e.g. when started, when ended, ...)
    //Later: is possible we decide to log the logs into a file, or a db, SO best would be to use extensibility and create new classes for this and not to modify the existing class which logs to console 
    // ====>>> We can do this by using an Interface <<<====

    public class Program
    {
        static void Main(string[] args)
        {
            //this behavior to log to console using ConsoleLogger can be changed very easy using interfaces
            var dbMigrator = new DbMigrator(new ConsoleLogger());

            //we just use a FileLogger instead like this
            //and we did not have to change anything in class DbMigrator, hurray !!!!
            //this is what we call changing the app by extending the app instead of changing the code
            var dbMigrator2 = new DbMigrator(new FileLogger("C:\\Projects\\log.txt"));


            dbMigrator.Migrate();
        }
    }
}
