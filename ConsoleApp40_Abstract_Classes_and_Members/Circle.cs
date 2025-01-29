namespace ConsoleApp40_Abstract_Classes_and_Members;

public class Circle : Shape
{
    public override void Draw() //method implementation is here in derived class (not in base class Shape)
    {
        Console.WriteLine("Draw a circle"); //here is the method implementation, here we can define it, because we know circle and we know how to draw a circle
    }
}