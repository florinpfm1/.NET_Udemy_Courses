using System.Net.Http.Headers;

namespace ConsoleApp14_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo: for Arrays
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Property Length
            Console.WriteLine("Length is: " + numbers.Length); //6

            //Method IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of elem 9 is: " + index); //2

            //Method Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear() method:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number); //will print in console: 0 0 9 2 14 6
                                           //first 2 elements were cleared, so because elements are int they are put to default 0
                                           //if this were an array of booleans, with Clear() we put elements to the default "false"
                                           //if this were an array of strings, because string is reference type, with Clear() we put elements to "null"
            }

            //Method Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy() method:");
            foreach (var item in another)
            {
                Console.WriteLine(item); //will print in console: 0 0 9
                                         //so we copied the first 3 elements to the second array
            }

            //Method Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort() method:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number); //will print: 0 0 2 6 9 14
                                           //all elements are sorted ascending (for integer values they rise up in value)   
            }

            //Method Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse() method:"); 
            foreach (var number in numbers)
            {
                Console.WriteLine(number); //will print: 14 9 6 2 0 0
                //the elements in array reverse their position inside the array   
            }


        }
    }
}
