using System.Text;

namespace ConsoleApp20_class_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo: StringBuilder class
            //Creating
            var builder = new StringBuilder();
            var builder2 = new StringBuilder("Hello World!");
            var builder3 = new StringBuilder("here is my text");

            //Methods used for manipulation
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new string('-', 10));

            Console.WriteLine("My builder is: " + builder);
            Console.WriteLine();
            Console.WriteLine("My builder2 is: " + builder2);
            Console.WriteLine();

            //Access elements in a StringBuilder
            Console.WriteLine("First character is: " + builder[0]);

            //Chaining multiple StringBuilders Append() methods, or other methods from StringBuilder
            //we can do this because the return type of class StringBuilder is a StringBuilder
            builder3
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine("My builder3 is: " + builder3);


        }
    }
}
