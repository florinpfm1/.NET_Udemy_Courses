namespace ConsoleApp29_Fields
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            //here we add two orders insite the field Orders (so the Count property will say it is 2)
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote(); //by mistake when we call this method we re-initialize the field Order to an empty List
                                //after executing this method all data saved until now in field Orders (the 2 orders) are lost
                                //and Count says 0, so all the orders in the list were deleted
                                //TO PREVENT THAT: we use the readonly modifier !!!!!!!!!!!!!!!

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
