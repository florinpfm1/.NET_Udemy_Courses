namespace ConsoleApp26_Constructors;

public class Customer
{
    //fields
    public int _id;
    public string _name;
    public List<Order> Orders; //is a List of generic objects, and <Order> tells us that the object type will be Order
                               //RULE: make sure this List is always initialized to an empty list in the Constructor to avoid errors in main Program

    //constructor with overloads
    public Customer() //this is a ctor without parameters, default constructor, it does nothing except to put default values for fields in the class
    {
        Orders = new List<Order>(); //if we do not initialize here to an empty list, we will have
                                    //to do it every time we make an instance of Customer class in main Program
                                    //but it is not the responsability of main Program to initialize the List<Order> from Customer class !!!!!
    }

    public Customer(int id)
        : this() //means when this CTOR overload is called, it will execute the CTOR without parameters (from above)
    {
        this._id = id;
    }

    public Customer(int id, string name)
    : this(id) //means when this CTOR overload is called, it will execute the CTOR with 1 parameter int (from above)
    {
        //this._id = id;   //it not needed anymore because it is included in CTOR overload with 1 param int (from above)
        this._name = name;
    }
}