namespace ConsoleApp18_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring and Initializing
            var myTimeSpan = new TimeSpan(1, 2, 3);
            var myTimeSpan1 = new TimeSpan(1, 0, 0);
            var myTimeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration is: " + duration);

            //Properties
            Console.WriteLine("Minutes is: " + myTimeSpan.Minutes);
            Console.WriteLine("Total Minutes is: " + myTimeSpan.TotalMinutes);

            //Method Add()
            Console.WriteLine("Method Add() e.g.: " + myTimeSpan.Add(TimeSpan.FromMinutes(8)));
            //Method subtract()
            Console.WriteLine("Method Subtract() e.g.: " + myTimeSpan.Subtract(TimeSpan.FromMinutes(5)));

            //Converting to string by using ToString()
            Console.WriteLine("Using ToString() e.g.: " + myTimeSpan.ToString());
            //Converting from string by using Parse()
            Console.WriteLine("Using Parse() e.g.: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
