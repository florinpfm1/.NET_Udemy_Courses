namespace ConsoleApp1_AsyncProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----- FIRST WAY to define and initialize a Task -----
            //we define a Task that will execute async the ConcatenateChars method
            Task t = new Task(ConcatenateNumbers);
            //we initialize the Task by using Start()- we call the method that takes a lot of time to complete, we use async programming with Task
            t.Start();

            //we want to print to console a message saying that the method execution is in progress (so that end user knows the application is not frozen)
            Console.WriteLine("In Progress");
            //we need to tell the task where to wait for the result of method ConcatenateChars, if we don't do this the task is executed somewhere in the background and in thread of of Program.cs the code execution advances to next line of code 
            t.Wait();
            //we print to console when the method has completed its execution
            Console.WriteLine("Completed");

            //----- SECOND WAY to define and initialize a Task -----
            Task t2 = Task.Factory.StartNew(ConcatenateChars);
            Console.WriteLine("In Progress");
            t2.Wait();
            Console.WriteLine("Completed");

            //----- THIRD WAY to define and initialize a Task -----
            Task t3 = Task.Run(new Action(ConcatenateZeros));
            Console.WriteLine("In Progress");
            t3.Wait();
            Console.WriteLine("Completed");

        }

        //a method that concatenates 200,000 characters to a string it takes some time to complete (usually string builder is better for this)
        public static void ConcatenateNumbers()
        {
            string concatenatedString = string.Empty;
            for (int i = 0; i < 200000; i++)
            {
                concatenatedString += "1";
            }
        }

        public static void ConcatenateChars()
        {
            string concatenatedString = string.Empty;
            for (int i = 0; i < 200000; i++)
            {
                concatenatedString += "a";
            }
        }

        public static void ConcatenateZeros()
        {
            string concatenatedString = string.Empty;
            for (int i = 0; i < 200000; i++)
            {
                concatenatedString += "0";
            }
        }
    }
}
