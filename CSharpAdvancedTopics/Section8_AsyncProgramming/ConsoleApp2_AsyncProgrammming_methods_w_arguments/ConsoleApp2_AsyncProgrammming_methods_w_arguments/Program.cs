using System.Threading.Tasks;
using System;

namespace ConsoleApp2_AsyncProgrammming_methods_w_arguments
{
    internal class Program
    {
        //THIS IS FOR TASK THAT EXECUTES A METHOD ASYNC THAT DOES NOT HAVE ANY RETURN VALUE (the method is void)
        static void Main(string[] args)
        {
            //----- SECOND WAY to define and initialize a Task -----
            //the Task needs an Action delegate without input arguments or output arguments
            //BUT to be able to pass arguments to the ConcatenateNumbers method, we need to use a lambda expression
            //this lambda expression is a generic function that takes no arguments and returns void

            int count = 200000;
            char charToConcatenate = '1';

            Task t = Task.Factory.StartNew(() => 
            {
                ConcatenateNumbers(charToConcatenate, count);
            });

            Console.WriteLine("In Progress");
            t.Wait();
            Console.WriteLine("Completed");

            

        }

        //a method that concatenates 200,000 characters to a string it takes some time to complete (usually string builder is better for this)
        public static void ConcatenateNumbers(char charToConcatenate, int count)
        {
            string concatenatedString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                concatenatedString += charToConcatenate;
            }
        }


    }
}
