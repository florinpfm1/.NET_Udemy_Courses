namespace ConsoleApp6_Delegates_Func_and_Action
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alice", "John", "Bobby", "Kyle", "Scott", "Tod", "Sharon", "Armin", "George" };

            //Func = is a built-in delegate in System namespace
            //no mater how many input parameters T1, T2, T3, .. the Func has, it always will have the last output parameter TResult
            //here: T1 is string, and TResult is the last one meaning the bool
            //it is used for methods that return a value:   e.g.   public static bool LessThanFive(string item)
            Func<string, bool> lessThanFive = x => x.Length < 5;

            
            List<string> namesLessThanFiveChars = ExtractStrings(names, lessThanFive);
            List<string> namesMoreThanFiveChars = ExtractStrings(names, MoreThanFive);
            List<string> namesExactlyFiveChars = ExtractStrings(names, ExactlyFive);

            Console.WriteLine("All names: " + string.Join(", ", names));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Names less than five chars: " + string.Join(", ", namesLessThanFiveChars));
            Console.WriteLine("Names more than five chars: " + string.Join(", ", namesMoreThanFiveChars));
            Console.WriteLine("Names exactly five chars: " + string.Join(", ", namesExactlyFiveChars));
            Console.WriteLine(new string('-', 40));


            //Action = is another built-in delegate in System namespace
            //it only takes input parameters, IT HAS no output parameter TResult
            //is used for methods that do not return anything, so they return void:    e.g.   public static void Print(string message)
            Action<string> printer = Print;

            printer += PrintTwice;
            printer += Print;

            printer("The sky is blue");


        }

        public static List<string> ExtractStrings(string[] array, Func<string, bool> filter)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < array.Length; i++)
            {
                if (filter(array[i]))
                {
                    result.Add(array[i]);
                }
            }

            return result;
        }

        public static bool LessThanFive(string item)
        {
            return item.Length < 5;
        }

        public static bool MoreThanFive(string item)
        {
            return item.Length > 5;
        }

        public static bool ExactlyFive(string item)
        {
            return item.Length == 5;
        }

        public static void PrintTwice(string message)
        {
            Console.WriteLine(message + " " + message);
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
