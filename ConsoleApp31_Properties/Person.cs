using System.Reflection;

namespace ConsoleApp31_Properties;

public class Person
{
    //IMPORTANT: code snippet for auto-properties is: prop

    
    //auto-implemented property --->>> is read-only because of "private set"
    public DateTime Birthdate { get; private set; } //when we make the setter as private, it will be accessible only from inside the class
                                                      //so any instance of this class through property Birthdate will NOT be able to set a value to this field
                                                      //we did this to enforce in property Birthdate to put a value only once, and then to not be able to modify it
                                                      //BUT how do we set the value for this property ??? A: we use the Constructor

    //property with getter --->>> it is read-only because has no setter defined
    public int Age   //this property calculates the age value based on another property
    {
        get
        {
            var timeSpan = DateTime.Today - Birthdate;
            var years = timeSpan.Days / 365;

            return years;
        }
    }

    //Constructor
    public Person(DateTime birthdate)
    {
        Birthdate = birthdate;   //whatever input param value we receive from outside when we create the instance of the class
                                 //will be used to set the value of property Birthdate
                                 //after the instance of class is created, property Birthdate is set at that value
                                 //through "instance of class".Birthdate we CANNOT change the value of property since is defined as "private set" !!!!!!!!!!
    }

}