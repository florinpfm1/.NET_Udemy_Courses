namespace ConsoleApp56_Exception_Handling_create_and_throw_new_custom_exceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Situation: you are creating a website and you need to build an api that retrieves the videos of a youtube user and display them on the webpage

			try //this is out global exception handler for our app
			{
				var api = new YouTubeApi();  //creating an instance of TouTubeApi class
				var videos = api.GetVideos("Mosh_user_of_youtube");  //we call the method GetVideos()
			}
			catch (Exception ex)  //here an exception caught "ex", would be really my custom YouTubeException having my custom message
                                  //inside the property "Message", and also inside the property "InnerException" we will have the original
                                  //message of the LOW LEVEL exception "Oops some low level Youtube exception has occured..."

            {

                Console.WriteLine(ex.Message);  //and here we print in console the custom exception message :)
                                                
                     
                //NOTE: -----
                //this kind of catching low level exception inside my generic custom exception and having access to both my custom message and low level original message
                //is done when working with Entity and doing queries to the db
                //we always look inside the innerException to see the actual reason why the query to the db failed
            }
        }
    }
}
