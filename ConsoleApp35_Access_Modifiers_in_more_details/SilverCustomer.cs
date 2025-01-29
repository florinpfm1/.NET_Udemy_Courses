namespace ConsoleApp35_Access_Modifiers_in_more_details;

public class SilverCustomer
{
    public int Id { get; set; } //this property should be visible outside of the class to the user
    public string Name { get; set; } //this property should be visible outside of the class to the user

    public void Promote() //this method should be visible outside of the class to the user
    {
        var rating = PrivateCalculateRating(excludeOrders: true);
        if (rating == 0)
        {
            Console.WriteLine("Promoted to Level 1");
        }
        else
        {
            Console.WriteLine("Promoted to Level 2");
        }
    }

    //this next method is about the implementation details, it should not be visible outside of the class to the user
    //it should only be visible to the Promote() method which uses it to calculate something
    private int PrivateCalculateRating(bool excludeOrders) 
    {
        return 0;
    }

    protected int ProtectedCalculateRating(bool excludeOrders)
    {
        return 0;
    }
}