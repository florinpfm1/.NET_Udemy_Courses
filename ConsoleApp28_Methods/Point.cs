namespace ConsoleApp28_Methods;

public class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(Point newLocation)
    {
        if (newLocation is null)
            throw new ArgumentNullException("newLocation"); //the "newLocation" is just the name of parameter that cannot be null !!!
                                                                     //this technique when checking input for null and throwing exception
                                                                     //is called Defensive Programming
                                                                     //like this the execution of code will not reach next line, so
                                                                     //our instance of class Point will not become invalid
                                                                     //
                                                                     //NOTE: without this we would have a NullReferenceException with generic message to user (harder to understand)
                                                                     //but with it, we get an ArgumentNulException with a more clear message to user
        Move(newLocation.X, newLocation.Y);
    }
}