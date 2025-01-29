namespace ConsoleApp49_Events
{
    public class MailService //this class will send an email to user once the video has finished encoding
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email ..." + e.Video.Title);
        }
    }
}
