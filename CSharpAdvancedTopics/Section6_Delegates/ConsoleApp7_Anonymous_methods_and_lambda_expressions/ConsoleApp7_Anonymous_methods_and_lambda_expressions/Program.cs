using System;

namespace ConsoleApp7_Anonymous_methods_and_lambda_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //here we have an input of type integer, and output of type bool
            Func<int, bool> checkIntegers = i => i < 8;
            Console.WriteLine(checkIntegers(5));

            //here we have 2 inputs of type integer, and output of type bool
            Func<int, int, bool> checkIntegers2 = (i, j) => i < 8 + j;
            Console.WriteLine(checkIntegers2(1,2));

            //we don't have any input types here
            Action printSomething = () => Console.WriteLine("The basll is red");

            printSomething();

            //ANONYMOUS METHODS - written inline
            Action<int, int> sumOfTwoNumbers = (i, j) =>
            {
                Console.WriteLine("The i number is: " + i);
                Console.WriteLine("The j number is: " + j);
                Console.WriteLine("The sum of i + j is: " + (i + j));
            };

            sumOfTwoNumbers(1, 2);

        }
    }
}
