namespace ConsoleApp56_Exception_Handling_create_and_throw_new_custom_exceptions
{
    public class YouTubeException : Exception //my custom exception class must derive from parent class Exception for all exceptions in .NET
    {
        public YouTubeException(string message, Exception innerException) : base(message, innerException)
        {
            //this constructor will have a custom message defined by me for this custom exception, and
            //will pass the custom message together with the innerException (which is the actual low level exception has occured) --->>> to 
            //the base class Exception

        }
    }
}
