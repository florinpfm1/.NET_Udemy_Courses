namespace ConsoleApp40_Abstract_Classes_and_Members;

public abstract class Shape //defined as abstract class
{
    public int Width { get; set; }
    public int Height { get; set; }

    public abstract void Draw(); //defined as abstract method
                                 //is too general the concept to define implementation of a shape here, we cannot do it
                                 //this is why we declare the method as abstract and we don't give any implementation here, body of method is missing
                                 //but all derived classes from class Shape, will have the Draw() method defined with "override" and inside will be
                                 //the implementation of the method that applies to that derived class !!!

    public void Copy() //we can also have non-abstract methods in an abstract class
    {
        Console.WriteLine("Copy shape into clipboard.");
    }

    public void Select()
    {
        Console.WriteLine("Select the shape.");
    }
}