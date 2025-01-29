namespace ConsoleApp55_Exception_Handling_w_using_for_unamanged_resources
{
	public class Program
	{
		static void Main(string[] args)
		{
			try
			{
				//The preffered way to close unmanaged resources - it does a finally block in the background where it uses Dispose()
				using (var streamReader = new StreamReader(@"c:\file.zip")) //here we define the class to use and we give input data to initialize
				{
					var content = streamReader.ReadToEnd(); //here we actually use the class to do something
				}

				//it will close the connection to open file after the code is executed in try block <<<--- so less code for us to write, since we don't need to write the finally block anymore
			}
			catch (DivideByZeroException ex)
			{

			}
			catch (ArithmeticException ex)
			{

			}
			catch (Exception ex)
			{
				
				
			}
		}
	}
}
