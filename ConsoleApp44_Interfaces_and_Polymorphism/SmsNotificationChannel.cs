namespace ConsoleApp44_Interfaces_and_Polymorphism;

public class SmsNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("Sending SMS ...");
    }
}