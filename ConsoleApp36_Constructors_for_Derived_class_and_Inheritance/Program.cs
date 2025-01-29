namespace ConsoleApp36_Constructors_for_Derived_class_and_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            //we create an instance of the derived class, ctor of derived class will also use the ctor of base class for this
            var car = new Car("XYZ123");
            //when the instance car is created the constructor of base class is executed first and then the constructor of derived class is executed second


        }
    }
}
