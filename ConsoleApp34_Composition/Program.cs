namespace ConsoleApp34_Composition
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            //we defined the Log method in a common place Logger class and we used it in 2 different other instances of classes DbMIgrate and Installer
            //this is done by defining a readonly property in class DbMigrate and Installer which receives in CTOR a Logger object !!!
            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
