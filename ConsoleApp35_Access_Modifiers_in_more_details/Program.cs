using AmazonClassLibrary;

namespace ConsoleApp35_Access_Modifiers_in_more_details
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            //--- Access Modifier: Public ---
            //these next form the public interface of Customer class, these members are accessible from anywhere
            var myId = customer.Id; //i created this public property
            var myName = customer.Name; //i created this public property
            customer.Promote(); //i created this public method
            //customer.Equals(); //method is inherited from Object main class
            customer.GetHashCode(); //method is inherited from Object main class
            customer.GetType(); //method is inherited from Object main class
            customer.ToString(); //method is inherited from Object main class

            //--- Access Modifier: Private
            //the method CalculateRating() is not accessible outside of its class, so it will not compile the next line of code:
            //var rating = customer.CalculateRating();

            //--- Access Modifier: Internal ---
            var silvCust = new SilverCustomer();
            //since class RateCalculator is internal, it is only accessible inside the assembly/class library named AmazonClassLibrary
            //AmazonClassLibrary.RateCalculator calculator = new RateCalculator(); //so this will have errors, we cannot compile it


        }
    }
}
