using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_ExtensionMethods
{
    public static class Extensions
    {
        //HERE WE DEFINE THE EXTENSION METHOD: must be defined in a static class !!!


        //the Extension Method Sort that sorts an array - is defined with "this" keyword - will be available only for type "array of integers"
        //"this" keyword imposes it to be an extension method
        //"this" keyword also defines on which type the extension method will be available to use on

        //we have 2 overloads for method Sort2Ext (same method name used, but different signatures) - one with argument "reverse" and one without
        public static void Sort2Ext(this int[] array)
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

        public static void Sort2Ext(this int[] array, bool reverse = false) //here argument "reverse" is optional, if not provided it defaults to "false"
        {
            array.Sort2Ext(); //calling the Sort2Ext method from above

            if (reverse)
            {
                Array.Reverse(array);
            }
        }

        public static void ReverseExt(this int[] array)
        {
            Array.Reverse(array);
        }




        public static Distance DistanceTo(this Point p1, Point p2)  //here "this" keyword is extending Point p1, the class Point !
                                                                    //also argument Point p2 is an argument needed for the method DistanceTo
                                                                    //when calling method DistanceTo on an instance of class Point: we will have to give argument p2
        {
            Console.WriteLine($"The distance between P1 and P2 is:" +
                $"\n{p2.X - p1.X} units in X direction" +
                $"\n{p2.Y - p1.Y} units in the Y direction");

            //this next 3 lines can all be written after the return in much shorter way, it does the same thing :
            // Distance.distance = new Distance();
            // distance.XDistance = p2.X - p1.X;
            // distance.YDistance = p2.Y - p1.Y;

            return new Distance() { XDistance = p2.X - p1.X, YDistance = p2.Y - p1.Y }; 
        }
    }
}
