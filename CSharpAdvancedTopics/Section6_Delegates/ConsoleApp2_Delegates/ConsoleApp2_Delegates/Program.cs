namespace ConsoleApp2_Delegates
{
    internal class Program
    {
        //delegate - HERE WE DEFINE THE DELEGATE
        public delegate bool Filters(string item); //the name of delegate is "Filters"

        static void Main(string[] args)
        {
            //input data
            string[] names = { "Alice", "John", "Bobbysim", "Kyle", "Scott", "Tod", "Sharonette", "Armin", "George" };
            Console.WriteLine("All names: " + string.Join(", ", names));

            //HERE WE CALL the method NamesFilter WITH THE DELEGATE AS ARGUMENT
            //we pass the 2nd argument the delegate as a lambda expression !!!!!!     *****THIS IS A SHORTER WAY TO WRITE 
            List<string> lessThanFiveChars = NamesFilter(names, item => item.Length < 5);
            Console.WriteLine(string.Join(", ", lessThanFiveChars));

            List<string> moreThanFiveChars = NamesFilter(names, item => item.Length > 5);
            Console.WriteLine(string.Join(", ", moreThanFiveChars));

            List<string> exactlyFiveChars = NamesFilter(names, item => item.Length == 5);
            Console.WriteLine(string.Join(", ", exactlyFiveChars));
        }

        

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
