namespace ConsoleApp6_Enums
{
    //Declaring Enum - here all values are by default like this: first RegularAirMail will be 0, then next 1, then next 2, ... so it is incremented by 1 for each name-value pair of the enum
    public enum ShippingSpeed
    {
        RegularSpeed,
        RegisteredSpeed,
        ExpressSpeed
    }

    //Declaring Enum and Initialize - usually here these values 1005, 1006, 1007 are somewhere in database defined
    public enum ShippingMethod
    {
        RegularAirMail = 1005,
        RegisteredAirMail = 1006,
        Express = 1007
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //CONVERTING AN ENUM TO AND FROM AN INTEGER BY CASTING:
            //When we receive the name Express from a 3rd party and we need to 
            //convert it to its value from the Enum name-value pair: we use casting to integer
            var bestMethod = ShippingMethod.Express; //IMPORTANT: in here we have only the name from the name-value pair, so Express
            int bestMethodAsValue = (int)bestMethod; //IMPORTANT: when we cast to integer we obtain the value of the name-value pair, so 1007
            Console.WriteLine("The name of name-value pair is: " + bestMethod); //Express
            Console.WriteLine("The value of name-value pair is: " + bestMethodAsValue); //1007

            //When we receive the value 1007 from a 3rd party and we need to
            //convert it to its name from Enum name-value pair:
            var methodId = 1007;
            ShippingMethod methodIdAsName = (ShippingMethod)methodId;
            Console.WriteLine("The value of name-value pair is: " + methodId); //1007
            Console.WriteLine("The name of name-value pair is: " + methodIdAsName); //Express

            //CONVERTING AN ENUM FROM A STRING BY CASTING:
            var worstMethod = ShippingMethod.RegularAirMail;
            string worstMethodString = worstMethod.ToString(); //HERE: we apply the ToString() method
            Console.WriteLine(worstMethod); //1005
            Console.WriteLine(worstMethodString); //RegularAirMail

            //CONVERTING AN ENUM FROM A STRING BY PARSING+CASTING TO ENUM TYPE:
            //in this case we parse the string "Express" to the type ShippingMethod which is an Enum
            var myMethod = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), myMethod);
            
        }
    }
}
