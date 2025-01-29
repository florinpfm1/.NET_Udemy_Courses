namespace ConsoleApp44_Interfaces_and_Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel()); //this will make channel Mail to be used for sending message to user that encodes the video
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());  //this will make channel Sms to be used for sending message to user that encodes the video
            encoder.Encode(new Video()); //when the method Encode(new Video()) is called we have achieved polymorhic behavior <= see explanations inside class VideoEncoder.cs !!!!!

            //NOTE: in case you are wondering but how are the Mail channel, Sms channel and Send() all tied together so that we have polymorphic behavior at run-time ?
            //Answer: both classes SmsNotificationChannel and MailNotificationChannel implement interface INotificationChannel
            //in this interface we have a contract saying that method Send() will be used and defined in each of the 2 classes that implement the interface 

        }
    }
}
