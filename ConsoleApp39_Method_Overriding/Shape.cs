namespace ConsoleApp39_Method_Overriding;

public class Circle : Shape
{
    public override void Draw()
    {
        // any code specific to the circle class
        //base.Draw(); //base is a reference to the parent class; this line is written automatically by C#

        Console.WriteLine("Draw a circle.");

    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a circle.");

    }
}

//Advantage of Polymorphism and Method Overriding: if tomorrow we decide to add support for a new shape, like Triangle
//we don't have to change the anything in class Shape, we just need to create a new derived class Triangle from base class Shape !!!!!!
//also we did not have to change anything in existing derived classes Circle and Rectangle

public class Triangle : Shape //so when we added this class no need to change the class Shape !!!
{
    public override void Draw()
    {
        Console.WriteLine("Draw a triangle.");
    }
}

public class Shape //this class Shape knows nothing of derived class Triangle (as it should be to be loosely coupled)
{
    public int Width { get; set; }
    public int Height { get; set; }
    //public Position Position { get; set; }

    public virtual void Draw() //this method was intentionally left empty, because it is just a placeholder for a method name that will
                               //have a different implementation in every derived class Circle, Rectangle, Triangle, ....
    {

    }
    
}