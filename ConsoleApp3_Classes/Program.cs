using ConsoleApp3_Classes.Math;

namespace ConsoleApp3_Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john._firstName = "John";
            john._lastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result); //NOTE: here we call the method "WriteLine" directly from the class "Console"
                                       //this means the method "WriteLine" is a static method in class "Console"
            
        }
    }
}
