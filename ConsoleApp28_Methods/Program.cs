namespace ConsoleApp28_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc"); //this throws exception FormatException because Parse() cannot cast a string into a number
            int number;
            var result = int.TryParse("abc", out number); //the output of TryParse() is a boolean to indicate whether the conversion was with success or failed !!!!!!!!!!!
                                                                 //if we use TryParse() the advantage is that it does not throw an exception
                                                                 //but a friendly message "Conversion failed"
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }

        //e.g. for modifier params - with a varying number of input parameters for a method
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
            //Console.WriteLine(calculator.Add(new int[]{1, 2, 3, 4, 5}));
        }

        //e.g. for method overloads
        static void usePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                point.Move(null); //because we passed null to Move() method is throwing exception because it cannot do null.X and null.Y

                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured."); //here is basically a General Error Handler
                // it will catch any error and not crash the program
                //and just display in console the message "An unexpected ..." we set :)
            }
        }
    }
}
