namespace ConsoleApp36_Constructors_for_Derived_class_and_Inheritance;

public class Car : Vehicle
{
    //default parameter less constructor
    //so note: when we create an instance of this class, first the default ctor param less of base class is executed, 
    //then this ctor param less of the derived class is executed

    //IMPORTANT: if the base class does not have a ctor param less and we did not use ": base(...)" here then this ctor here will have errors !!!!!!!!
    public Car(string registrationNumber) : base(registrationNumber) //the input param "registrationNumber" is received in ctor of derived class and passed to the ctor of base class
    {
        Console.WriteLine("Car is being initialized. {0}", registrationNumber);
    }


}