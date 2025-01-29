namespace ConsoleApp54_Exception_Handling
{
    public class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null; //this StreamReader for unamanaged resources needs to be declared outside of try to be able to close this resource in finally block
            
            try
            {
                //here we try to divide 5 to 0 and we get an exception
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);

                //e.g. of an unamaged resource: a stream reader instance to read a file on the hard disk
                streamReader = new StreamReader(@"c:\file.zip"); //we define this to be able to read a file on hard disk

                //here we actually try to use the stream reader
                var content = streamReader.ReadToEnd(); //here we try to oepn and read the file on c:\ drive

                //we can manually throw an exception here like this:
                throw new Exception("Ooops, we have problems.......");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            catch (ArithmeticException ex)
            {

            }
            catch (Exception ex)
            {
                //here we have to options:
                //-1)- we can recover from the error and prevent application from crashing
                //-2)- we can rethrow the error back to the caller of this code

                Console.WriteLine("Sorry, an unexpected error occured.");
            }
            finally //is used mainly for unamanaged resources, in case anything goes wrong with them
            {
                if (streamReader != null)
                    streamReader.Dispose(); //in the case anything goes wrong in the try block while reading the file
                                        //we want to make the stream to the file on hard disk would be closed
                                        //if we don't do this we would have problems like: keeping files opened on hard disk, or keeping network connections opened,or db connections opened
                                        //and this poses security risks or eats up from memory/cpu resources of the machine our app is running on !!!!! and the machine could run out of resources and
                                        //it will just shut down, which is the worst that could happen to a back-end system !!!!!
                //Dispose() method comes from interface IDispose which is expected to be implemented by StreamReader class that manages unmanaged resources (meaning files)
                
            }
        }
    }
}
