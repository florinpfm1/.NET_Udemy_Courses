namespace ConsoleApp36_Constructors_for_Derived_class_and_Inheritance;

public class Vehicle
{
    private readonly string _registrationNumber;

    //default parameter less constructor

    //public Vehicle()
    //{
    //    Console.WriteLine("Vehicle has been initialized.");
    //}

    //constructor w 1 param of type string
    public Vehicle(string registrationNumber)
    {
        _registrationNumber = registrationNumber;

        Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
    }
}