namespace ConsoleApp39_Method_Overriding
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle()); //here to the list of Shape, we can add a Shape or a derived class from Shape which is a Circle
            shapes.Add(new Rectangle()); //here is the same, we added a derived class Rectangle

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
