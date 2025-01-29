namespace ConsoleApp1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I love cats";
            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

            // loop through, apply condition, when condition is met add item to new list
            List<int> newNumbersBelowFive = new List<int>();
            foreach (var number in numbers)
            {
                if (number < 5)
                {
                    newNumbersBelowFive.Add(number);
                }
            }
            Console.WriteLine(string.Join(", ", newNumbersBelowFive));

            // all the above can be executed the same with fewer code using LINQ queries
            var getTheNumbersBelowFive = from number in numbers
                                where number < 5
                                select number;
            Console.WriteLine(string.Join(", ", getTheNumbersBelowFive));  //<<-- the LINQ query is executed only in this line where
                                                                  //the var getTheNumbers is actually used for something

            // 








        }
    }
}
