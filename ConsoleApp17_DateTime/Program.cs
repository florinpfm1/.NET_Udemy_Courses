using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp17_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour is: " + now.Hour);
            Console.WriteLine("Minute is: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = today.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
