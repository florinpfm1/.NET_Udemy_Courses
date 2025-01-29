namespace ConsoleApp52_Nullable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = null;    //will not compile because DateTime is value type so it cannot be null
            Nullable<DateTime> date = null;  //Solution: we use a nullable 
            DateTime? date2 = null;          //is the same thing as above but written shorter

            //these 3 members of a nullable type we will use most of the time:
            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());  //will return the default value for the data type if it has no value (so when it's null)
                                                                                  //this is the preferred way to get the value so that it throws no exception when the value is not set yet (so when is null)
            Console.WriteLine("HasValue: " + date.HasValue);  //is a boolean: true when it has a value, false when it is null
            Console.WriteLine("Value: " + date.Value);  //returns the value. IMPORTANT: throws an exception if it has no value (so when is null)


            //Converting from nullable DateTime -> DateTime
            DateTime? date3 = new DateTime(2014, 1, 1);
            //DateTime date4 = date3; //will not compile because we try to put a nullable DateTime into a DateTime
            DateTime date4 = date3.GetValueOrDefault(); //Solution: we use the method GetValueOrDefault(), now it will compile

            //Converting from DateTime -> nullable DateTime
            DateTime date5 = new DateTime(2015, 5, 5);
            DateTime? date6 = date5; //it converts without problems this way

            //Operator null coalescing operator: "??"     <<<< is a bit similar to tthe tertiary operator
            DateTime? date7 = null;
            DateTime date8;

            /*
            if (date7 != null)
                date8 = date.GetValueOrDefault();
            else
                date8 = DateTime.Today;
            */

            //we can rewrite the code commented above much shorter:
            DateTime? date9 = null;
            DateTime date10 = date9 ?? DateTime.Today; //how we read this code: if date9 has a value use it, if not just use DateTime.Today

            DateTime date11 = (date9 != null) ? date9.GetValueOrDefault() : DateTime.Today; //same code but written with tertiary operator "?"



        }
    }
}
