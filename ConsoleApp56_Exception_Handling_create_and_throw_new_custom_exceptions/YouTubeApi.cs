namespace ConsoleApp56_Exception_Handling_create_and_throw_new_custom_exceptions
{
    public class YouTubeApi //has all the logic to retrieve youtube videos of a youtube user based on his youtube username
    {
        public List<Video> GetVideos(string username)
        {
            try
            {
                //LOGIC:
                //access youtube web service: open a network stream
                //read the data as an xml
                //parsing, create a list of video objects


                //Here we manually simulated something going wrong when fetching videos from youtube, by throwing this new exception:
                //this is often a LOW LEVEL exception like network stream, parsing exception, ...
                throw new Exception("Oops some low level Youtube exception has occured...");

            }
            catch (Exception ex) //*** here we catch the LOW LEVEL exception with not so nice message "Oops some low level Youtube exception has occured...", is of type Exception because that is what we have thrown
            {
                // Log the exception caugth

                //here i do not want to expose LOWER LEVEL exceptions, to the HIGHER LEVELS of my application
                //this is why i create here a CUSTOM EXCEPTION named YouTubeException and i handle it differently, like for e.g. when recovering from that exception
                //maybe i want to display a list of default videos instead of youtube videos of user
                //*** so here i caught the LOW LEVEL exception, and i throw a new custom exception (that wraps the original LOW LEVEL exception inside it as an innerException)
                throw new YouTubeException("Could not fetch the videos from Youtube.", ex);  //<<<--- so here i wrap the low level exception inside a more
                                                                                             //meaningful exception with a custom message chosen by me
                                                                                             //SO : all the low level exceptions no matter what they are will
                                                                                             //have then have been transformed into an exception with my custom message
                                                                                             //plus having also an innerException with the details of the actual
                                                                                             //low level exception that occured

                                                                                             //we do this because mu custom message is more nice to have than
                                                                                             //just the low level message like "Socket connection timeout ..."
                                                                                             //which is harder to understand

                                                                                             //the second argument "ex" represents the innerException (low level exeption)
                                                                                             //that is wrapped inside my custom exception => so in my custom exception
                                                                                             //i will be able to see a property innerException that holds all the details
                                                                                             //of the actual problem (we do this for troubleshooting the problem, to also
                                                                                             //have access if we want in the higher levels of the app to the actual 
                                                                                             //low level exception that occured)
                                                                                             


            }

            return new List<Video>();
        }
    }
}
