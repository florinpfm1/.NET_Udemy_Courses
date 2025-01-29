using System;

namespace ConsoleApp46b_GenericList_with_constraint_to_an_Interface
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max<T>(T a, T b) 
            where T : IComparable, new()  //here we applied "where" for constraint to an interface "IComparable"
                                          //this interface has a method CompareTo that we need in order to compare 2 generics
                                          //in our case a and b are both generics

                                          //here we applied constraint to have a default constructor
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

    }

}
