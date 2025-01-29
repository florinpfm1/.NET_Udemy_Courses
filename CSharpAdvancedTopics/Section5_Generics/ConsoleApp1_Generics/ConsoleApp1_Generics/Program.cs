using System.Collections;

namespace ConsoleApp1_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calling the method to compare, and passing 2 int values that will be compared to each other
            Console.WriteLine(AreEqualInt(1,2));

            //calling the method to compare, and passing 2 objects that will be compared to each other (object can be: int or string or Person, ....)
            Console.WriteLine(AreEqualObj(1, 2));

            //calling generic method AreEqualGen
            Console.WriteLine(AreEqualGen("efg", "abc"));

            //some data for Sort Generic Method on arrays of different ypes
            int[] intArray = new int[] { 3,4,2,1,5,6,7,8,9,2,2,2,1,23,3 };
            char[] charArray = new char[] { 'a', 'f', 'c', 'd', 'b', 'z', 'g' };
            string[] stringArray = new string[] { "Tod", "Strawberry", "Cherry", "Coffee", "String", "Alphabet" };

            int[] sortedIntArray = SortGenericForArray(intArray);
            string[] sortedStrArray = SortGenericForArray(stringArray);
            Console.WriteLine(string.Join(", ", sortedIntArray));
            Console.WriteLine(string.Join(", ", sortedStrArray));

            //some data for implementing IComparable interface in a Class Person
            Person p1 = new Person() { Age=10 };
            Person p2 = new Person() { Age=15 };

            Console.WriteLine("Person1 equal to Person2: " + AreEqualGen(p1, p2));



        }

        //method that compares 2 int values
        public static bool AreEqualInt(int num1, int num2)
        {
            return (num1 == num2);
        }

        //method that compares 2 any types - this would be a generic method that accepts as arguments 2 any types
        public static bool AreEqualObj(object num1, object num2)  //<<-- this is working as expected :(, is difficult to compare 2 objects like this ........
        {
            return (num1 == num2);
        }

        //Note: instead of T we can write any type like "MyTypeAny" , it is just a convention to use T which means T can be any type int, string, bool, Dog, Cat, ...
        public static bool AreEqualGen<T>(T num1, T num2) where T:IComparable<T>  //<<-- we give as arguments the generic type T, notice that num1 and num2 must both be of same type 
        {
            //return (num1 == num2); //if we use operator "==" will give an error, because C# does not have a the operator "==" defined for the generic type T, so it does not know how to compare them

            //return num1.Equals(num2); //<<-- we use the method Equals() to compare the 2 objects, this method is defined for all objects in C#

            //the method CompareTo in implemented by IComparable interface, so we can use it to compare 2 objects
            return num1.CompareTo(num2) == 0;
        }

        //generic method that can Sort an array of any type - AS LONG AS T implements IComparable<T> interface
        public static T[] SortGenericForArray<T>(T[] array) where T:IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        









    }
}
