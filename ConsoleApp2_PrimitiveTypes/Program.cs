namespace ConsoleApp2_PrimitiveTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //---------- Demo: Variables and Constants ----------
            /*
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;

            var number2 = 2;
            var count2 = 10;
            var totalPrice2 = 20.95f;
            var character2 = 'A';
            var firstName2 = "Mosh";
            var isWorking2 = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //these are constants from structure "byte"

            const float P1 = 3.14f;
            */

            //---------- Demo: Type Conversion ----------
            //implicit conversion - with success
            /*
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            */

            //implicit conversion - that gives error
            /*
            int i = 1;
            byte b = i;
            */

            //explicit conversion or CAST - with success because the int i value is small enough to be stored in a byte
            /*
            int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b); //this evaluates at runtime at value 1, so there is no data lost in this example !!!
                                  //NOTE: in this case developer knows for sure that this conversion will NOT have any data lost 
            */

            //explicit conversion or CAST - that gives an error because the int value is too big to be stored in a byte
            /*
            int i = 1000;
            byte b = (byte)i;
            Console.WriteLine(b); //this evaluates at runtime to value 232, because the first 3 bytes of the int 1000 were lost when casting it to a byte
                                  //NOTE: C# does NOT give any error if we have data lost during excplicit cast !!!!!!
                                  //NOTE2: is the responsability of developer to make sure the conversion is done correctly in this case !!!!!!
            */

            //non-compatible types conversion - that gives error
            /*
            string number = "1234";
            int i = (int)number; //this gives error, because types are not compatible
            */

            //non-compatible types conversion - with success by using Convert class
            /*
            string number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i); //evaluates to 1234
                                  //NOTE: value 1234 is small enough to be stored on 4 bytes of the int data type
            */

            //non-compatible types conversion - that gives error by using Convert class
            /*
            string number = "1234";
            byte b = Convert.ToByte(number);
            Console.WriteLine(b); //evaluates to: Unhandled Exception: System.OverflowException
                                  //the application will stop  !!!!
                                  //NOTE: the value 1234 is too big to be stored in 1 byte of byte data-type
            */

            //non-compatible types conversion - that gives error by using Convert class, and we handle the Exception
            /*
            try
            {
                string number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
            //this will make the application to display the friendly message to the user
            //and the application will continue to run !!!!!
            */

            //non-compatible types conversion - with success
            /*
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to a boolean.");
            }
            */

            //---------- Demo: Operators ----------
            //Arithmetic Operators
            /*
            var a = 10;
            var b = 3;
            Console.WriteLine(a+b);

            // -a- Division of integer numbers
            var c = 10;
            var d = 3;
            Console.WriteLine(c / d); // result is 3 because 10 / 3 = 3 remainder 1
                                      //NOTE: because both c and d variables are integers, the result of division is also integer

            // -b- Division of real numbers (e.g. like floating point numbers)
            var e = 10;
            var f = 3;
            Console.WriteLine((float)e / (float)f); // result is 3.33333 because 10 / 3 = 3.33333
                                      //NOTE: because both e and f variables were cast to be float, the result is also a float
            */

            //Precedance of Operators
            /*
            //when *, / are performed before +, -
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine(a + b * c); //evaluates to 7

            //when we want to change the precedance by using paranthesis
            var c = 1;
            var d = 2;
            var e = 3;
            Console.WriteLine((c + d) * e); //evaluates to 9
            */

            //Comparison Operators
            /*
            var a = 1;
            var b = 2;
            Console.WriteLine(a > b); // false

            var c = 1;
            var d = 2;
            Console.WriteLine(c == d); // false

            var e = 1;
            var f = 2;
            Console.WriteLine(e != f); // true

            var g = 1;
            var h = 2;
            Console.WriteLine(!(a != b)); //here we have 2 negative, which is actually 1 positive
                                          //DO NOT WRITE double negations because they are hard to follow and understand
                                          //use this instead: Console.WriteLine(a == b)
            */

            //Logical Operators
            /*
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine(c > b && c > a); // true && true --->>> true

            var d = 1;
            var e = 2;
            var f = 3;
            Console.WriteLine(f > e && f == d); // true && false --->>> false

            var h = 1;
            var i = 2;
            var j = 3;
            Console.WriteLine(j > i || j == h); // true || false --->>> true

            var k = 1;
            var l = 2;
            var m = 3;
            Console.WriteLine(!(m > l || m == k)); // !(true || false) --->>> !true --->>> false
            */




        }
    }
}
