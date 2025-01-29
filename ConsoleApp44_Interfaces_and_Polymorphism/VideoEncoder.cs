using System.Net.WebSockets;

namespace ConsoleApp44_Interfaces_and_Polymorphism;

public class VideoEncoder
{
    private readonly IList<INotificationChannel> _notificationChannels;
    
    public VideoEncoder()
    {
        _notificationChannels = new List<INotificationChannel>(); //here we just initialize the notificationChannels to be as an empty List
    }
    public void Encode(Video video)
    {
        //Video encoding logic .....
        //...

        foreach (var channel in _notificationChannels)
        {
            channel.Send(new Message()); //the polymorphic behavior is here: at runtime when the Send() method is called on each element of this list _notificationChannels
                                         // a different Send() method will be used
                                         // if is a Mail object then Send() from class MailNotificationChannel will be used
                                         // if is an Sms object then Send() from class SmsNotification will be used
        }
    }

    public void RegisterNotificationChannel(INotificationChannel channel)
    {
        _notificationChannels.Add(channel); //here whenever we call this method from Program.cs we will add a new channel (mail or sms or whatever we decide later to use)
                                            //to the notificationChannels List
                                            //the notificationChannels List has now all the channels we wanted saved in it
                                            //and we use method Encode(Video video) and we iterate to each element in the List to send message to user by each channel
    }
}