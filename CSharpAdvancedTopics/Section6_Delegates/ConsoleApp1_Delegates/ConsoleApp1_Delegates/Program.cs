namespace ConsoleApp1_Delegates
{
    public class Program
    {
        //delegate - HERE WE DEFINE THE DELEGATE
        public delegate bool Filters(string item); //the name of delegate is "Filters"

        static void Main(string[] args)
        {
            //input data
            string[] names = { "Alice", "John", "Bobbysim", "Kyle", "Scott", "Tod", "Sharonette", "Armin", "George" };
            Console.WriteLine("All names: " + string.Join(", ", names));

            //HERE WE CALL the method NamesFilter WITH THE DELEGATE AS ARGUMENT
            //the second argument is expected to be a delegate "Filter filter"
            //but we can give a method that has the same signature as the delegate
            //  --- meaning that the method has the same return type and the same input type as the delegate Filters
            //  --- and in this case we can give any of these 3: LessThanFive(string name) ; MoreThanFive(string name) ; ExactlyFive(string name)
            //  --- thus we give the method name without the brackets (....) and without the argument, so will be: LessThanFive ; MoreThanFive ; ExactlyFive
            List<string> lessThanFiveChars = NamesFilter(names, LessThanFive);
            Console.WriteLine(string.Join(", ", lessThanFiveChars));

            List<string> moreThanFiveChars = NamesFilter(names, MoreThanFive);
            Console.WriteLine(string.Join(", ", moreThanFiveChars));

            List<string> exactlyFiveChars = NamesFilter(names, ExactlyFive);
            Console.WriteLine(string.Join(", ", exactlyFiveChars));
        }

        //HERE ARE THE METHODS WITH SAME SIGNATURE AS THE DELEGATE
        //each one represent a new filtering condition
        public static bool LessThanFive(string name)
        {
            return name.Length < 5;
        }

        public static bool MoreThanFive(string name)
        {
            return name.Length > 5;
        }

        public static bool ExactlyFive(string name)
        {
            return name.Length == 5;
        }

        //method with the filtering single condition "item.Length <5"
        //THE IDEA IS: I WANT TO GENERALIZE THIS METHOD TO APPLY A DIFFERENT FILTERING CONDITION by using a DELEGATE
        /*
        public static List<string> NamesFilter(string[] items)
        {
            List<string> result = new List<string>();
            foreach (var item in items)
            {
                if (item.Length < 5)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        */

        //HERE we apply the delegate inside a method NamesFilter, each possible delegate will apply a different filtering condition
        //method that need to take different "filtering conditions" as delegates
        public static List<string> NamesFilter(string[] items, Filters filter)  //here we give ar argument also a delegate
        {
            List<string> result = new List<string>();
            foreach (var item in items)
            {
                //here the delegate filter is applied on the item
                // basically "filter(item)" is replaced by "LessThanFive(item)" which becomes "item.Length < 5"
                // basically "filter(item)" is replaced by "MoreThanFive(item)" which becomes "item.Length > 5"
                // basically "filter(item)" is replaced by "ExactlyFive(item)" which becomes "item.Length == 5"
                if (filter(item)) 
                {
                    result.Add(item);   
                }
            }
            return result;
        }







    }
}
