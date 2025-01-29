namespace ConsoleApp40_Abstract_Classes_and_Members;

public class Rectangle : Shape
{
    public override void Draw() //method implementation is here in derived class (not in base class Shape)
    {
        Console.WriteLine("Draw a rectangle."); //here is the method implementation, here we can define it, because we know rectangle and we know how to draw a rectangle
    }
}