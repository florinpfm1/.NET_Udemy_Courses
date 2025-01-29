using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Generic_classes
{
    //here we create our own generic class for a list
    public class MyList<T>
    {
        //fields
        private T[] items; //here are kept all elements of my list inside a T[] array
        private int count;
        private int capacity;
        //props
        public int Count { get { return this.count; } private set { this.count = value; } }
        public int Capacity { get { return this.capacity; } private set { this.capacity = value; } }
        public T this[int index] //<<-- here we add an indexer to our class, so we can access the elements of the list by their index
                                 //we add it as a property because it has a getter and a setter 
        {
            get
            {
                return this.items[index];
            }
            set
            {
                this.items[index] = value;
            }
        }
        
        //CTOR - will initialize my list with a capacity of 2 and no elements in the list (an empty list)
        public MyList()
        {
            this.items = new T[2]; //here we initialize the list with 2 elements, both are null, because we did not add any elements to the list yet
            this.count = 0;
            this.capacity = 2;
        }

        //methods
        public void Add(T item) //will add element T item on position 0 of my list, then next on position1, ... and so on
        {
            //first we check if the capacity of my list is equal to the count of elements in my list
            //when condition is true ==>> we need to increase the capacity of my list (we will double it each time)
            if (this.capacity == this.count)
            {
                T[] clone = (T[])items.Clone(); //we create a clone of the existing elemnts in my list , with the purpose to temporarily save them here and
                                                //later when the new bigger array is created we will copy all elements from this clone array to the new bigger array
                this.capacity *= 2; //we double the capacity of my list
                this.items = new T[this.capacity]; //we initialize a new bigger array of items with the new capacity doubled
                Array.Copy(clone, 0, this.items, 0, clone.Length); //we copy all elements from the temporary clone array to the new bigger array
            }
            this.items[this.count] = item; //this.count is the index of the item that we add to our own list - here it starts from items[0]
            this.count++; //next we increment count, it is saved in field count, and next time we add an item to our list it will be placed on the next available index of my list
        }

        //methods to overload mathematical operators: addition
        //how to add 2 lists OF THE SAME LENGTH
        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> result = new MyList<T>();
            if (list1.count != list2.count)
            {
                throw new InvalidOperationException("Cannot add lists of different lengths");
            }
            else
            {
                for (int i = 0; i < list1.count; i++)
                {
                    result.Add((dynamic)list1[i] + (dynamic)list2[i]); //because elements in list1 and list2 are generictype T, we need to cast them to dynamic type so that C# compiler knows that we want to use the overloaded + operator for the elements of the list
                }
                return result;
            }
        }

        //method to override the ToString method to be able to print in console more easily the elements of the list
        public override string ToString()
        {
            string tempString = string.Empty;
            for (int  i = 0;  i < this.count;  i++)
            {
                if(i<this.count - 1)
                {
                    tempString += this.items[i] + ", ";
                }
                else
                {
                    tempString += this.items[i];
                }
            }

            //return string.Join(", ", this.items);
            return tempString;
        }





    }
}
