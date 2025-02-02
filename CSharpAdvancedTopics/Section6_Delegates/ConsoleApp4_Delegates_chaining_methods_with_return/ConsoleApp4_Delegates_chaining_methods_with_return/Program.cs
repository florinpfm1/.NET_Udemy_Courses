namespace ConsoleApp4_Delegates_chaining_methods_with_return
{
    internal class Program
    {
        //defining the delegate
        public delegate bool CheckLengthOfString(string message);

        static void Main(string[] args)
        {
            //we chain 3 methods in the delegate
            CheckLengthOfString d = LessThanFive;
            d += MoreThanFive;
            d += ExactlyFive;

            //we print to console the delegate
            Console.WriteLine(d("The sun is shining")); //here we will only get the last value of the delegate "ExactlyFive" which is false, but we want to have the return for the methods chained inside the delegate
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            //
            List<bool> result = new List<bool>();
            foreach (var del in d.GetInvocationList())
            {
                result.Add((bool)del.DynamicInvoke("The sun is shining"));
            }

            Console.WriteLine(string.Join(", ", result)); //now we print to console the outcome of each method inside the delegate

            //
            List<bool> result2 = d.GetInvocationList().Select(del => (bool)del.DynamicInvoke("The sun is shining")).ToList();

            Console.WriteLine(string.Join(", ", result2)); //does same thing as above, just with LINQ expressions

        }


        //methods that have same signature as the delegate
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

        
    }
}
