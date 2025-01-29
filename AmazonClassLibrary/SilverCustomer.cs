namespace AmazonClassLibrary;

public class SilverCustomer
{
    public int Id { get; set; } 
    public string Name { get; set; } 

    public void Promote()
    {
        //note that inside same assembly/class library named AmazonClassLibrary we can access the internal class RateCalculator !!!!!
        //so from outside, like in Program.cs this class RateCalculator will not be accesible !
        var calculator = new RateCalculator();
        var rating = calculator.Calculate(this);

        Console.WriteLine("Promotion logic changed again here.");
    }

}