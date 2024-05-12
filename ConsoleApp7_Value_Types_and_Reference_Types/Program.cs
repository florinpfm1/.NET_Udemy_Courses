using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp7_Value_Types_and_Reference_Types
{
    public class Person
    {
        public int Age;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Demo for VALUE TYPES (e.g. for int)
            int a = 10;
            int b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            // a is 10; b is 11
            // because int is value type, the value of original variable a does not change when we change the value of copied variable b
            // when you copy a value type to a different variable, the value is copied and the 2 variables remain independant from one another

            //DEMO for REFERENCE TYPES (e.g. for array)
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("aaray1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
            // first elem of array1 is 0, first elem of array2 is also 0
            // because array is reference type, the value of original variable is the same with the value of copied variable
            // when you copy a reference type to a different variable, the reference is copied, both original
            // and copied variables have the same reference (link) to the data value in Heap memory, so when we change something in the data value
            // on the Heap, both variables original and old will see the same changed data value. The 2 variables are NOT independent from one another

            //Demo 3 - e.g. for a value type
            var number = 1; //variable of value type created with the scope of Main() method, only here it exists
                            //this WILL NOT BE AFFECTED by Increment() method below !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Increment(number); //since number is a variable of value type when we pass it to the Increment() method it will make a copy of its value
                               //NOW a copy of value 1 is made in a different memory location and that represent the parameter number
                               //given to the Increment() method 
                               //BUT Increment() method returns void, so actually inside this method the copy of value of var number is passed
                               //then inside the method the number is incremented with 10
                               //and after that it is destroyed, because the method does not return anything, the incrementation of
                               //the copy value of var number has the scope only in method Increment()
                               //which is a different memory location from var number defined in Main() method
                               
            Console.WriteLine(number); // is 1
                                       //this is why when we try to see in Main() method what is the value of var number it will be 1
                                       //because the incrementation inside method Increment() has scope only inside method Increment()
                                       //and NOT scope inside method Main() <<-- WE DEFINED method Increment() to return nothing
                                       //so nothing is returned to the outside of where we called method Increment() which is method Main()

            //Demo 3 - e.g. for reference type
            var person = new Person() { Age = 20 }; //variable of reference type created with the scope of Main() method, it exists here
                                                    //this WILL BE AFFECTED by MakeOld() method below !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            MakeOld(person); //since "person" parameter is a variable of reference type when we pass it to the MakeOld() method it will pass
                             //the reference only. Which means both var person defined in Main() method and the parameter "person" will be pointing
                             //to the same data-value in Heap memory where the instance person is of Age 20
                             //BUT MakeOld() method returns void, still the parameter passed var person points in Heap memory to the instance
                             //data-value, and the method will increment that data-value with 10 as we defined it. Then it will not return anything
                             //from the scope of MakeOld() to the scope outside towards Main() method.
            Console.WriteLine(person.Age); //is 30
                                           //this is when we try to see in Main() method what is the data-value instance of var person of
                                           //reference type, BECAUSE the MakeOld() method incremented the data-value instance in Heap memory by 
                                           //10, even if the MakeOld() method does not return anything outside towards the Main() method scope
        }

        //Demo 3
        public static void Increment(int number)  //we defined as static because we want to call this method directly without creating an instance of the class
        {
            number += 10;
        }

        public static void MakeOld(Person person) //we defined as static because we want to call this method directly without creating an instance of the class
        {
            person.Age += 10;
        }
    }
}
