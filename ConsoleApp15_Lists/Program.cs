using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp15_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo Lists
            var numbers = new List<int>() { 1, 2, 3, 4 };

            //Methods of class List
            numbers.Add(1); //we add one more object to the List, and that object is 1
            numbers.AddRange(new int[3] {5, 6, 7}); //with AddRange() we can add another List or an Array to our original List

            foreach (var number in numbers)
            {
                Console.WriteLine(number); //it prints: 1 2 3 4 1 5 6 7 as all its elements printed one by one 
            }

            Console.WriteLine();
            Console.WriteLine("Index of 1 is: " + numbers.IndexOf(1)); //prints: 0 because it searches for only first element 1 in the List
            Console.WriteLine("Last Index of 1 is: " + numbers.LastIndexOf(1)); //prints: 4 because it searches for only last element 1 in the List

            //Properties of clas List
            Console.WriteLine("Count: " + numbers.Count); //prints: 8

            //Methods of class List
            numbers.Remove(1);

            foreach (var number in numbers)
            {
                Console.WriteLine(number); //it prints: 2 3 4 1 5 6 7 only the first elem 1 is gone now
            }

            // EXCEPTION APPEARS HERE:
            //if we want to remove all elements that are 1 from the List, we can use a foreach loop:
            /*
            foreach (var number in numbers)
            {
                if (number == 1)
                    numbers.Remove(number); // THIS GIVES AN EXCEPTION ERROR !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                            // because in C# you are not allowed to modify a collection List inside a foreach loop !!!!!!!!!!!!!!!!!!!!!!!!
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number); //it prints: nothing because it has an Exception thrown
            }
            */

            // SOLUTION for Exception above is to use a normal for loop when we modify a collection List
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number); //it prints: 2 3 4 5 6 7 so all elements that are 1 were removed from the List
            }

            numbers.Clear(); //this method removes all elements in a List
            Console.WriteLine("Count: " + numbers.Count); //prints: 0 because the List contains no elements now

        }
    }
}
