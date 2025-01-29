using System.Collections;

namespace ConsoleApp38_Boxing_and_Unboxing
{
    public class Program
    {
        static void Main(string[] args)
        {
            //--- Disadvantage of ArrayList ---: is does not have type safety, we can store in the list any kind of value, later when we retrieve it and try to convert it we may cave InvalidCastException if the conversion fails
            var list = new ArrayList();
            //Note: the Add() method takes an argument of type object, so if we add int 1 it will automatically box value 1 by saving it to Heap and creating an object reference to it in Stack
            list.Add(1); //if we send as param a value type here, boxing will happen automatically
            list.Add("Mosh"); //here string is a reference type, so boxing does not happen
            list.Add(DateTime.Today); //here DateTime is a struct, so boxing will happen

            var myNumber = (int)list[0]; //when we retrieve the value here, unboxing will happen
            var number = (int)list[1]; //at runtime we will get InvalidCastException because a string cannot be converted to an int


            //--- A better way is to use generic list ---: which has type safety, it ensures all members are of type what we put inside <...> when we define the generic list
            var anotherList = new List<int>();
            //Note: the Add() method takes an argument of type int, like we imposed above when we created the generic list
            anotherList.Add(23); //here NO BOXING will happen, the list stores all elements int on Stack

            var names = new List<string>();
            //Note: the Add() method takes an argument of type string, like we imposed above when we created the generic list
            names.Add("Mary"); //here NO BOXING will happen, the list stores all elements string on Heap

            


        }
    }
}
