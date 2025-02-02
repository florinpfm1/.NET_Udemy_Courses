namespace ConsoleApp5_Delegates_generic_method_with_return
{
    internal class Program
    {
        //defining the delegate
        public delegate bool CheckLengthOfString(string message);

        //defining the delegate used for generic method part
        public delegate int GetLengths(string message);

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
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            // for the second delegate - with generic method to catch all retun values from the methods chained in the delegate
            List<bool> result3 = GottaCatchEmAll<bool>(d, "The sun is shining");
            Console.WriteLine(string.Join(", ", result3));

            //we are chaining the methods in the delegate
            GetLengths g = x => x.Length;
            g += x => x.Length + 1;
            g += x => x.Length + 2;

            //we are calling the delegate
            List<int> lengths = GottaCatchEmAll<int>(g, "The sun is shining");
            Console.WriteLine(string.Join(", ", lengths));

        }

        //generic method - to catch the return of each method chained in the delegate
        // List<T> -->> is the list with return type of the methods chained in the delegate, T is generic since each chained method can return a different data type
        //object parameter = null -->> is optional because not all methods chained in delegate will actually return something
        public static List<T> GottaCatchEmAll<T>(Delegate del, object parameter = null)
        {
            List<T> result = del.GetInvocationList()
                                 .Select(d => (T)d.DynamicInvoke(parameter))
                                 .ToList();
            return result;
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
