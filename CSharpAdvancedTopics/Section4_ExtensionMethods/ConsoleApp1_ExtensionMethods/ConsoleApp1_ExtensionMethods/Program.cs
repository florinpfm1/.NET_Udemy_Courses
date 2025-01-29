using System.Drawing;
using System.Drawing;

namespace ConsoleApp1_ExtensionMethods
{
    internal static class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 5, 3, 1, 2, 3, 9, 100 };
            
            //using a method to sort the array
            Sort1(array);
            Console.WriteLine(string.Join(", ", array));

            //e.g. of built-in methods for arrays in C#: .Clone, .CopyTo, .Equals, .GetLength, .GetLowerBound, .GetUpperBound, .GetValue, .IndexOf, .Reverse, .SetValue, .Sort, .ToString
            Array.Sort(array); //this is a built-in method "Sort" on the type "Array" to sort arrays

            //HERE WE CALL THE EXTENSION METHOD : Sort2Ext <<<--- is has 2 overloads (2 signatures)
            //but we want to use an Extension Method to sort the array, this will be a new method called like this: array.Sort();
            //this method will be available to all our arrays that we create
            //it will have "(extension)" in from of description for us to recognize it is an extension method
            array.Sort2Ext();
            Console.WriteLine(string.Join(", ", array));

            array.Sort2Ext(true);
            Console.WriteLine(string.Join(", ", array));

            array.Sort2Ext(false);
            Console.WriteLine(string.Join(", ", array));

            //HERE WE CALL THE EXTENSION METHOD: ReverseExt
            array.ReverseExt();
            Console.WriteLine(string.Join(", ", array));

            //HERE WE CALL TO EXTEND a CLASS that we cannot modify (e.g. System.String which is locked by Microsoft)
            //e.g. if we don't have access to modify the class (e.g. libraries from other 3rd party companies), we cannot add a new method for that class
            //      ===>>> Solution: we can extend instead that class with a new extension method

            Point pointOne = new Point(20, 30);
            Point pointTwo = new Point(10, 15);

            Distance distance = pointOne.DistanceTo(pointTwo); //extension method DistanceTo was added to not modifiable class Point from Microsoft !!!
            Console.WriteLine(distance.XDistance);
            Console.WriteLine(distance.YDistance);



        }

        //the Sort algorithm that sorts arrays - here is defined like a static method
        public static void Sort1(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        



    }
}
