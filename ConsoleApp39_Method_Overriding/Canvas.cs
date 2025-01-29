namespace ConsoleApp39_Method_Overriding;

public class Canvas
{
    public void DrawShapes(List<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
           shape.Draw(); //when we can the Draw() method on elements of list shapes, the first element actually is a derived class Circle
                         //and because we defined the Draw() method as virtual in class Shape and Draw() method as override in derived class Circle
                         //the method used at runtime will be the one from the derived class Circle
                         //same applies to the second element of the list, which is from derived class Rectangle

                         //advantage of Polymorfhism and Method Overriding: if tomorrow we decide to add support for a new shape, like a Triangle
                         //we don't have to change anything in this Canvas class
                         //this is what loosely coupled applications should be, we add new implementations and we don't need to change the existing classes, recompile and redeploy !!!
        }
    }
}