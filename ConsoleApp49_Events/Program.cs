using System.Reflection;

namespace ConsoleApp49_Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //is publisher
            var mailService = new MailService(); //is subscriber
            var messageService = new MessageService(); //is another subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;   //here we do the subscription for mailService!!!!!!
                                                                       //on the publisherthe videoEncoder. will have in drop-down a lightning symbol, that is the event "VideoEncoded" we need
                                                                       //the += operator is used to register a handler for that event "VideoEncoded"
                                                                       //the handler is method "OnVideoEncoded" in subscriber mailService
                                                                       //

            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //here we do the subscription for messageService !!!!!

            videoEncoder.Encode(video);




        }

        private static void VideoEncoder_VideoEncoded(object source, EventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
