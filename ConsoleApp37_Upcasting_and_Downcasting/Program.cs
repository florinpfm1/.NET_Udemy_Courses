using System.Collections;

namespace ConsoleApp37_Upcasting_and_Downcasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();

            //--- UPCASTING ---
            Shape shape = text; //no conversion is required, we can implicitly convert object text to its base class reference shape
            //NOTE: both text and shape objects have same reference to the object in Heap memory, but they have different views
            //and i mean text. and shape. will open the menu and see props and methods they have access to

            //text.  <<-- here we have the properties FontSize and FontName
            //shape.  <<-- here we don't have the properties FontSize and FontName
            //even is both text and shape point to the same object in Heap memory !!!!!!!!!!!, so shape will be more limited than what text has access to

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width); //it will print 100 in console, because both text and shape reference the same object in Heap memory

            //When will we use Upcasting ? A: in polymorphism


            //^^^Real world example 1:
            StreamReader reader = new StreamReader(new MemoryStream()); //when instantiating StreamReader we need a parameter of type Stream in the constructor
                                                                        //we write new MemoryStream() and C# does implicit upcasting to Stream
                                                                        //or we can use new FileStream() and C# does implicit upcasting to Stream
                                                                        //Note: both FileStream and MemoryStream are classes derived from class Stream
                                                                        //so this is a real world e.g. when Upcasting is used to convert from derived class to its base class reference

                                                                        
            //^^^Real world example 2: <= this is not recommended because it is not a type safety kind of list, inside the ArrayList we can store any kind of object
            //so we might have errors when we try to convert elements of this list to another type like integers for e.g., if an element in ArrayList is a Text object it cannot be converted to integer
            var list = new ArrayList();
            list.Add("Mosh"); //the Add() method needs a parameter of type Object
                              //so we can pass any item here string, int, bool, Car, Vehicle, ... and C# will do implicit upcasting to Object base class
                              //we can do this because base class Object is the top class for all classes in C#
            list.Add(555);
            list.Add(new Text());

            //^^^Real world example 2: <= this generic list has type safety, we can impose that all elements in this generic list to be int for e.g.
            //or every element in generic list to be of type Shape (or derived class from Shape class)
            var anotherList = new List<int>();
            var anotherList2 = new List<Shape>(); //IMPORTANT: actually in this generic list we can store Shape objects, or any object from a derived class from Shape !!!!


            //--- DOWNCASTING ---
            Shape shape2 = new Text(); //at compile-time the type of our object will be Shape
                                       //but at run-time the type will become Text
            
            //shape.  <<-- we will have a limited view of members to access from Shape class (we will not see the properties defined in Text class)
            //and this is why we need to downcast the shape object to be a text object
            Text text2 = (Text)shape2;
            //text2.  <<-- now we will have access to all members from Text class here

            //^^^Real world example 1: please open next project 38 Real_World_Eg_Downcasting




        }
    }
}
