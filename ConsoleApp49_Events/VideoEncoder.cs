namespace ConsoleApp49_Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //PROCEDURE A: 1.a) and 2)
        //1 - Define a delegate
        //a) - when we create our custom delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); //by convention delegate name should be: name of task + EventHandler

        //2 - Define an event based on that delegate
        //public event VideoEncodedEventHandler VideoEncoded;

        //OR
        //PROCEDURE B: which is step 1.b) and 2) combined

        //1.b) + 2 - or when we use the .NET predefined delegate type called EventHandler or EventHandler<T>  <<<--- this means we don't need to create the delegate ourselves, just use the existing one from .NET
        //public event EventHandler VideoEncoded   //this is the normal predefined EventHanlder
        //or
        public event EventHandler<VideoEventArgs> VideoEncoded;   //this is the generic predefined EventHandler<> 
                                                                    //any of these 2 is ok to use



        //3 - Raise an event
        protected virtual void OnVideoEncoded(Video video) //by convention this should be "protected", "void" and name starts with "On" + name of task
        {
            if (VideoEncoded != null) //here it checks if we have actually any subscribers
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video}); //here .Empty is a property we use when we want to send an instance of EventArgs that is empty
                                                                           //or we can send an instance of VideoEventArgs which is a derived class from EventArgs, and will contain the video that was encoded
            }
        }




        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000); //this delays the operation for 3 seconds

            OnVideoEncoded(video); //after video finished encoding, this calls the delegate to start the process of notification for the user
                                   //by convention this method should start with "On" and then the name of the task
                                   //here when we encode the video we also send the video as param, because we need it to create a reference of it to be send to user to know which video was encoded, this will be included in VideoEventArgs
        }
    }
}
