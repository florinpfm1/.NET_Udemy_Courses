namespace ConsoleApp3_Delegates_chaining_methods
{
    internal class Program
    {
        //define the delegate (needs to have same signature as the method Print below)
        public delegate void Printer(string message);

        static void Main(string[] args)
        {
            Printer p = Print; //here we assign the method Print to the delegate p
                               //and we save it in the "p" delegate variable

            //here we call the delegate p and pass the message to the method Print, the method Print is executed
            p("The sun is shining");
            Console.WriteLine("------------------------------------------------------------------------------------------");

            //IMPORTANT: we can have (chain) multiple methods to a given delegate variable like this:
            //basically we are adding more methods to the delegate variable p
            //we are creating a list of methods that will be executed when the delegate is called
            p += Print; //here we add (chain) again same method Print to the methods that were inside delegate variable p, so now we have 2 methods Print inside the delegate variable p
            p += Print; //now we have 3 methods Print inside the delegate variable p
            p += Print; //now we have 4 methods Print inside the delegate variable p

            //here we call the delegate p, the method Print will be executed 4 times
            p("The sun is shining");
            Console.WriteLine("------------------------------------------------------------------------------------------");

            //IMPORTANT: we can have (chain) multiple methods to a given delegate variable like this:
            p += PrintTwice; //here we add (chain) another method PrintTwice to the delegate variable p
            p += Print;      ///here we add (chain) again same method Print to the delegate variable p
            p += PrintTwice; //here we add (chain) again same method PrintTwice to the delegate variable p

            //here we call the delegate p, the method Print will be executed 5 times, the method PrintTwice will be executed 2 times
            p("The sun is shining");
            Console.WriteLine("------------------------------------------------------------------------------------------");

            //IMPORTANT: we can remove (unchain) multiple methods to a given delegate variable like this:
            p -= PrintTwice; //when we subtract a method from delegate, we will remove the last instance added of that method

            p("The sun is shining");
            Console.WriteLine("------------------------------------------------------------------------------------------");

            //to check what methods are chained inside the delegate:
            //-1-
            foreach (var del in p.GetInvocationList())
            {
                Console.WriteLine(del.Method);
            }

            //-2-
            Delegate[] delegates = p.GetInvocationList();
            //in each element of the array we have the name of method that is chained to the delegate

        }

        //method that has same signature as the defined delegate above
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintTwice(string message)
        {
            Console.WriteLine(message + " and that makes me happy");
            Console.WriteLine(message + " and that makes me happy");
        }

    }
}
