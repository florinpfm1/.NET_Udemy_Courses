using System.Linq;

namespace ConsoleApp1_LINQ_with_LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            List<int> numbers = new List<int>() { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };
            object[] mix = { 1, "string", 'd', new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 2, 3, 4 }, "dd", 's', "Hello Kitty", 1, 2, 3, 4, };

            // find the odd numbers through LINQ query
            var oddNumbers = from n in numbers
                             where n % 2 == 1
                             select n;
            Console.WriteLine(string.Join(", ", oddNumbers));

            // same as above but with LINQ with Lambda Expression
            var oddNumbers2 = numbers.Where(n => n % 2 == 1);
            /*
             n is the iterating variable ; => is the lambda operator ; numbers is the collection through which we will iterate ; n % 2 == 1 is the condition
             if the condition is true, the number will be added to the oddNumbers2 collection
            */
            Console.WriteLine(string.Join(", ", oddNumbers2));

            // if we want to convert the var oddNumbers2 to a List<int> type, then we need to add .ToList() at the end of the statement
            List<int> oddNumbers3 = numbers.Where(n => n % 2 == 1).ToList();
            Console.WriteLine(string.Join(", ", oddNumbers3));

            // check what is the average char length of the items in cat names list
            double average = catNames.Average(c => c.Length);
            Console.WriteLine(average);
            double minCatNamesLength = catNames.Min(c => c.Length);
            Console.WriteLine(minCatNamesLength);
            double maxCatNamesLength = catNames.Max(c => c.Length);
            Console.WriteLine(maxCatNamesLength);
            double sumCatNamesLength = catNames.Sum(c => c.Length);
            Console.WriteLine(sumCatNamesLength);

            // extract all integers from the mix array of objects (some of them are integers which we want to extract)
            var allIntegrs = mix.OfType<int>();
            Console.WriteLine(string.Join(", ", allIntegrs));

            var allIntegrs2 = mix.OfType<int>().Where(i => i < 3);
            Console.WriteLine(string.Join(", ", allIntegrs2));

            var allIntLists = mix.OfType<List<int>>().ToList();
            for (int i = 0; i < allIntLists.Count(); i++)
            {
                Console.WriteLine($"Int of List[{i}]: " + string.Join(", ", allIntLists[i]));
            }

            // e.g. how to extract a list of derived classes Melle and Spellcaster from a list of base class Characters:
            //      basically we are extracting a derived type from a base type

            //List<Character> characters = new List<Character>(); //in this list we have some Melle and some Spellcaster objects
            //List<Melle> melleTeam = new List<Melle>();
            //List<Spellcaster> spellcasterTeam = new List<Spellcaster>();

            //1st way to do this
            //melleTeam = characters.OfType<Melee>.ToList();

            //2nd way to do this with Lambda Expression
            //melleTeam = characters.Where(c => c is Melee).Cast<Melle>.ToList();

            //speallcasterTeam = characters.Where(c => c is Spellcaster).Cast<Spellcaster>.ToList();


            //Difference between "Select" and "Where": Select is used to project data, Where is used to filter data
            List<Warrior> warriors = new List<Warrior>()
            {
                new Warrior() { Height = 100 },
                new Warrior() { Height = 80 },
                new Warrior() { Height = 100 },
                new Warrior() { Height = 70 },
            };

            var shortWarriors = warriors.Where(wh => (wh.Height == 100)); //"Where" returns a collection of Warrior objects
            var shortWarriors2 = warriors.Where(wh => (wh.Height == 100))
                                         .Select(wh => (wh.Height)); //"Select" returns a collection from another collection
                                                                     //from Warriro collection will make a new collections of int Height of each Warrior

            // a feature that only the List type have: a built-in foreach method :):):) which work like a foreach loop
            List<int> shortWarriors3 = warriors.Where(wh => (wh.Height == 100))
                                               .Select(wh => (wh.Height))
                                               .ToList();
            //we want to print in console the height of all our warrior objects
            Console.WriteLine(string.Join(", ", warriors)); //<<-- this will give some error in the console, because we are trying to print a list of objects and it cannot convert from an object to a string :(

            warriors.ForEach(w => Console.WriteLine(w.Height)); //<<-- this will work, because we are using the ForEach method of the List type, which is a built-in foreach loop and we print directly the Height of each Warrior object
            warriors.ForEach(w => Console.Write(w.Height + " "));
            Console.WriteLine();
            shortWarriors3.ForEach(sw => Console.WriteLine(sw));

            //note that this:     warriors.ForEach(w => Console.WriteLine(w.Height));    is the same as this:
            foreach (var w in warriors)
            {
                Console.WriteLine(w.Height);
            }
        }

        internal class Warrior
        {
            public int Height { get; set; }
        }

        private static int[] StringToIntArray(string array)
        {
            int[] arrayFromString = array.Split(' ')
                                          .Select(element => int.Parse(element))
                                          .ToArray();   
            return arrayFromString;
        }
    }
}
