namespace ConsoleApp35_Access_Modifiers_in_more_details;

public class GoldCustomer : Customer  //is a derived class from base class Customer
{
    public void OfferVoucher()
    {
        var rating = this.ProtectedCalculateRating(excludeOrders: true); //inside the derived class the members "protected" from base class are accessible
    }
}