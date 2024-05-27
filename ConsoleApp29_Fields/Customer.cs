namespace ConsoleApp29_Fields;

public class Customer
{
    public int Id;
    public string Name;
    public readonly List<Order> Orders = new List<Order>();

    public Customer(int id)
    {
        this.Id = id;
    }

    public Customer(int id, string name)
        : this(id)
    {
        this.Name = name;
    }

    public void Promote()
    {
        //Orders = new List<Order>(); //by mistake let's say i initialize again the field Orders (was initialized in the field definition)
                                      //TO PREVENT THAT: we make the field Orders to be read-only
        // ....
    }
}