namespace ConsoleApp2_Generic_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //e.g. of generic class that we always used so far and we did not know it: class "List" is a generic class that has methods, props and works of any type


            //here we create an instance of our own generic class MyList - IN HERE I USED my own list of int elements
            MyList<int> firstIntList = new MyList<int>();
            Console.WriteLine(firstIntList.Capacity);
            Console.WriteLine(firstIntList.Count);
            
            firstIntList.Add(5);
            firstIntList.Add(1);
            firstIntList.Add(1); //<-- here the capacity is doubled
            Console.WriteLine("capacity and count of list1 are: ");
            Console.WriteLine(firstIntList.Capacity);
            Console.WriteLine(firstIntList.Count);

            firstIntList.Add(1);
            firstIntList.Add(1); //<-- here the capacity is doubled
            Console.WriteLine("capacity and count updated of list1 are: ");
            Console.WriteLine(firstIntList.Capacity);
            Console.WriteLine(firstIntList.Count);

            //Console.WriteLine(myIntList[0]); //cannot access the lements on position 0,1,2,.... because it gives an error: cannot apply [0] to an expression of type MyList<int>
            //Solution: we need a way to index the elements of the list ==>> we need to omplement an INDEXER
            //Console.WriteLine(firstIntList[0]); //now we can access the elements of the list by their index

            //here are other data needed for using the methods to overload mathematical operations
            MyList<int> secondIntList = new MyList<int>();
            secondIntList.Add(1);
            secondIntList.Add(1);
            secondIntList.Add(1);
            secondIntList.Add(1);
            secondIntList.Add(1);
            Console.WriteLine("capacity and count of list2 are: ");
            Console.WriteLine(secondIntList.Capacity);
            Console.WriteLine(secondIntList.Count);

            MyList<int> result = firstIntList + secondIntList; //initially here gives an error, because C# does not know how to add the 2 lists
                                                               //after we define the + operator method in our class MyList, the error will disappear
            Console.WriteLine("elements of array result (addition) are: ");
            Console.WriteLine(result.ToString()); //will print in colsole all elements of the list result
            /*
             NOTE: result printed will be: 6,2,2,2,2,0,0,0 because each list has 5 elements in it which are added, the last 3 zeroes represent the last 3 elements of array which are empty positions
            */

            /*
             NOTE: after i wrote a more nicer way to print elements of the list with method ToString() , the zeroes will not be printed anymore
            */
            //NOTE: result printed will be: 6,2,2,2,2



            //here we create an instance of our own generic class MyList - IN HERE I USED my own list of string elements
            MyList<string> firstStrList = new MyList<string>();
            firstStrList.Add("6");
            firstStrList.Add("1");
            firstStrList.Add("1");

            MyList<string> secondStrList = new MyList<string>();
            secondStrList.Add("1");
            secondStrList.Add("1");
            secondStrList.Add("1");

            MyList<string> resultStr = firstStrList + secondStrList; //note that here "5" added with "1" will be "51" because we add strings
            Console.WriteLine("elements of array result (addition) are: ");
            Console.WriteLine(resultStr.ToString());
            //NOTE: result printed will be: 51,11,11
        }
    }
}
