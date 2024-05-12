namespace ConsoleApp10_FOREACH_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo FOREACH loop over a string
            var name = "John Smith"; //string is an Enumerable object, we can iterate over each character element

            //e.g. using an IF loop
            /*
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            */

            //e.g. same code written with a FOREACH loop
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            // Demo FOREACH loop over an array
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }




        }
    }
}
