using System.Threading.Tasks;
using System;

namespace ConsoleApp4_AsyncProgramming_keywords_async_await
{
    internal class Program
    {
        //THIS IS FOR TASK THAT EXECUTES A METHOD ASYNC THAT RETURNS A STRING (the method is defined to return a string)
        static void Main(string[] args)
        {
            //----- SECOND WAY to define and initialize a Task -----
            //the Task needs an Action delegate without input arguments or output arguments
            //BUT to be able to pass arguments to the ConcatenateNumbers method, we need to use a lambda expression
            //this lambda expression is a generic function that takes no arguments and returns void

            int count = 200000;
            char charToConcatenate = '1';

            Task<string> t = ConcatenateChars(charToConcatenate, count);
            

            Console.WriteLine("In Progress");
            //t.Wait(); <<== because we use "await" inside the async method, we DON'T need to use Wait() here anymore, we can still use it but we don;t have to
            Console.WriteLine("Completed");
            Console.WriteLine("The length of the result is " + t.Result.Length);

            /*
             DIFFERENCE between CASE 1:
                t.Wait();
                Console.WriteLine("Completed");
                Console.WriteLine("The length of the result is " + t.Result.Length);

             and CASE 2:
                //t.Wait();
                Console.WriteLine("Completed");
                Console.WriteLine("The length of the result is " + t.Result.Length);

             is that:
                CASE 1: -because i wrote "t.Wait();" -->>> the program 
                        WILL WAIT until the task is completed 
                        and then it will print "Completed" 
                        and then it will print the length of the result taken from the result of the completed task
                CASE 2: -the program will print "Completed" 
                        and then when it reaches the line of code where we first try to access the result of the task (which is t.Result.Length) IT WILL WAIT until the task is completed
                        and then it will print the length of the result taken from the result of the completed task 
            */

        }

        //A method that concatenates 200,000 characters to a string it takes some time to complete (usually string builder is better for this)
        //The method is marked with "async" keyword: it automatically start executing as asynchronously and it will stop and wait for the method to finish
        //   its job on the first line where we try to access its result
        public async static Task<string> ConcatenateChars(char charToConcatenate, int count)
        {
            Task<string> t = Task<string>.Factory.StartNew(() =>
            {
                string concatenatedString = string.Empty;
                for (int i = 0; i < count; i++)
                {
                    concatenatedString += charToConcatenate;
                }
                return concatenatedString;
            });

            //here i use "await" for the return because there is nothing else i want inside the body to wait for, all i want to wait for is the result itself
            return await t; //the return of the method is marked with "await" keyword, it will wait until the execution is done in background thread and then return here the output of that operation

            //if you want to do something else after the result is ready, you want to execute some other code before you return it -->> you can extract
            //this await on another line like this (is basically CASE 1 from above explained)

            /*
            string result = await t;
            Console.WriteLine("Completed");  <<-- if we do this way, then above on line 24 we need to delete: Console.WriteLine("Completed");
            return result;
            */

        }
    }
}
