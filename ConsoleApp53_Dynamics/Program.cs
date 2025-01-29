namespace ConsoleApp53_Dynamics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dynamic language behavior by using keyword "dynamic" to define variables in C#

            //static language C# behavior: the method ToString() is checked that it exists in instance of class obj
            object obj = "Florin";
            obj.ToString(); //here it is checked that method ToString() exists in instance of class obj

            //dynamic language C# behavior: the method Optiomize() is not checked it exists in instance of class excelObject
            dynamic excelObject = "Florin";
            excelObject.Optimize(); //the instance of class does not have the method Optimize(), and we have no errors because now this is
                                    //not checked at compile-time, will be checked at run-time when the app actually runs 


            dynamic myDynamic = 5;
            dynamic myDynamic2 = "abc";
            myDynamic = myDynamic2;
            myDynamic = 100;


            dynamic name = "Florin";
            name = 10; //var name becomes here of type dynamic int at run-time, before was dynamic string


            dynamic a = 10;
            dynamic b = 5;
            var c = a + b; //var c is of type dynamic int at run-time


            int myInt = 33;
            dynamic d = myInt; //conversion is implicit
            long mylong = d; //conversion is also implicit because we can save an int in a long :)

        }
    }
}
