namespace ConsoleApp9_FOR_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo FOR loops
            //display only even numbers in ascending order
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //display only even numbers in descending order
            for (var i = 10; i >= 1; i--)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
