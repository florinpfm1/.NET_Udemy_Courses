namespace ConsoleApp11_DO_WHILE_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo WHILE loop
            //e.g.1
            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }

            // Demo BREAK keyword
            //e.g.2 - simple echo program, whatever the user types in console the console will display it
            //if the user types in console nothing then the program must shut down
            //if the user types any string, the program must echo that string in the console and to continue to run asking for another string to echo
            while (true) //here we set the condition to be "true" so the loop will go on forever
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break; //here we put the condition to get out of the loop and to shut down the program (if user enters no characters in Console)

                Console.WriteLine("@Echo: " + input);
            }

            // Demo CONTINUE keyword
            while (true) //here we set the condition to be "true" so the loop will go on forever
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; //here will arrive program execution only when user types some characters in the console
                              //when it reaches this "continue", it will jump to the next iteration of the loop
                              // ( so it will not go down to the "break" and shut down the program )
                }

                break;  //here we set the condition to get out of the loop
                        //if user types nothing in the console program execution will arrive here and will get out of the loop and shut down the program
            }


        }
    }
}
