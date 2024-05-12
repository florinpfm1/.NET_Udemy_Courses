using CSharp1Exercises.ControlFlow;

namespace ConsoleApp8_ConditionalStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            //IF ELSE statement
            /*
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }
            */

            //Conditional operator a?b:c
            bool isGoldCustomer = true;


            //is replaced by conditional statement below
            /*
            float price;

            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }
            */

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);

            //SWITCH statement
            var season = Season.Autumn;

            /*
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and is a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect because is summer");
                    break;
                default:
                    Console.WriteLine("I don't knw what season it is.");
                    break;
            }
            */

            //e.g. when we have same statement to execute for 2 different cases
            /*
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got a promotion.");
                    break;
                default:
                    Console.WriteLine("I don't knw what season it is.");
                    break;
            }
            */

            // ----- Exercise1 -----
            //Conditionals.Exercise1();

            // ----- Exercise2 -----
            //Conditionals.Exercise2();

            // ----- Exercise3 -----
            Conditionals.Exercise3();

            // ----- Exercise3 -----
            Conditionals.Exercise4();


        }
    }
}
