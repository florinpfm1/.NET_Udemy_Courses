namespace ConsoleApp26_Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "John");
            Console.WriteLine(customer._id);
            Console.WriteLine(customer._name);

            var customer2 = new Customer();
            customer2._id = 2;
            customer2._name = "Steve";

            var order = new Order();
            customer.Orders.Add(order); //Error Null Reference Exception - because we tried to Add(order) to a List Orders
                                        //which was not initialized, so it was null. We cannot apply Add() to a null !!!!!
                                        //and we must avoid this at all times
        }
    }
}
