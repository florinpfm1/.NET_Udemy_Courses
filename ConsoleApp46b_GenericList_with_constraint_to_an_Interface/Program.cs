namespace ConsoleApp46b_GenericList_with_constraint_to_an_Interface
{



    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
            dictionary.Add("1235", book);

            //For case when we apply constraint to a value type (where T : struct)
            var number = new Nullable<int>(5);  //here we check for something with a value
            Console.WriteLine("Has Value ? Answer: " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            var number2 = new Nullable<int>(); //here we check for something that does not have a value
            Console.WriteLine("Has Value ? Answer: " + number2.HasValue);
            Console.WriteLine("Value: " + number2.GetValueOrDefault());

            //this Nullable structure actually is part of .NET framework and we can use it, is under: System.Nullable<>
        }
    }
}
