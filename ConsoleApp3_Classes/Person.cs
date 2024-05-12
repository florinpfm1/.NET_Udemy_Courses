namespace ConsoleApp3_Classes;

public class Person
{
    public string _firstName;
    public string _lastName;

    public void Introduce()
    {
        Console.WriteLine("My name is " + _firstName + " " + _lastName);
    }
}