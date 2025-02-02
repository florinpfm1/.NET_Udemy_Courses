namespace ConsoleApp5_AsyncProgramming_last_refactoring
{
    internal class Program
    {
        //HERE WE WANT to be able to run the method ConcatenateChars both synchronous and asynchronous - thus we can choose to use what we want !!!!!!!
        //NOTE: a Task can be run in 2 ways: synchronous and asynchronous

        //THIS IS FOR TASK THAT EXECUTES A METHOD ASYNC THAT RETURNS A STRING (the method is defined to return a string)
        static void Main(string[] args)
        {
            //----- SECOND WAY to define and initialize a Task -----
            //the Task needs an Action delegate without input arguments or output arguments
            //BUT to be able to pass arguments to the ConcatenateNumbers method, we need to use a lambda expression
            //this lambda expression is a generic function that takes no arguments and returns void

            int count = 200000;
            char charToConcatenate = '1';

            //@@@ here we run the method in an async way
            Task<string> t = ConcatenateCharsAsync(charToConcatenate, count);
            Console.WriteLine("In Progress");
            Console.WriteLine("The length of the result is " + t.Result.Length);

            //@@@ here we run the method in a normal (old-school) sync way
            ConcatenateChars(charToConcatenate, count);

        }

        public static string ConcatenateChars(char charToConcatenate, int count)
        {
            string concatenatedString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                concatenatedString += charToConcatenate;
            }
            return concatenatedString;
        }

        //A method that concatenates 200,000 characters to a string it takes some time to complete (usually string builder is better for this)
        //The method is marked with "async" keyword: it automatically start executing as asynchronously and it will stop and wait for the method to finish
        //   its job on the first line where we try to access its result
        public async static Task<string> ConcatenateCharsAsync(char charToConcatenate, int count)
        {
            Task<string> t = Task<string>.Factory.StartNew(() =>
            {
                return ConcatenateChars(charToConcatenate, count);
            });


            //if you want to do something else after the result is ready, you want to execute some other code before you return it -->> you can extract
            //this await on another line like this (is basically CASE 1 from above explained)

            string result = await t;
            Console.WriteLine("Completed");
            return result;

            /*
             IMPORTANT CONVENTION:
                an async method must have its name ending with "...Async" - this is a convention that helps the developer to know that the method is async
            */


            /*
             OBSERVATION 2: if we want to await and return the Task outcome directly in this method's body (we don;t want to execute any more code that does
                does something and depends on the t.Result.... ), then we can simplify even more the entire body code written like this:

                --------------
                return await Task<string>.Factory.StartNew(() =>
                {
                    return ConcatenateChars(charToConcatenate, count);
                });
                --------------
            */
        }
    }
}
