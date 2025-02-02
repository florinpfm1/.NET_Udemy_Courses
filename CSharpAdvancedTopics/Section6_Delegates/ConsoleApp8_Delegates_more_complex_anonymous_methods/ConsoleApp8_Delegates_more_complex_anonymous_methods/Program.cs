using System;
using System.Collections.Generic;

namespace ConsoleApp8_Delegates_more_complex_anonymous_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alice", "John", "Bobby", "Kyle", "Scott", "Tod", "Sharon", "Armin", "George" };

            Func<string[], Func<string, bool>> extractStrings = (array, filter) =>
            {
                List<string> result = new List<string>();
                foreach (var item in array)
                {
                    if (filter(item))
                    {
                        result.Add(item);
                    }
                }

                return result;
            };

            Func<string, bool> lessThanFive = x => x.Length < 5;
            Func<string, bool> moreThanFive = x => x.Length > 5;


            List<string> namesLessThanFiveChars = extractStrings(names, lessThanFive);
            Console.WriteLine(string.Join(", ", namesLessThanFiveChars));

            List<string> namesMoreThanFiveChars = extractStrings(names, moreThanFive);
            Console.WriteLine(string.Join(", ", namesMoreThanFiveChars));

        }
    }
}
