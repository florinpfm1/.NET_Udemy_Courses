namespace ConsoleApp50_ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Problem: i want to create a new custom method that works on strings, so it needs to work on instances of String class. But i cannot add
            //methods to the sealed class String by using derived classes

            //Solution: i create and use an extension method to the class String

            string post = "This is a very long post here bla bla ....";
            var shortenedPost = post.Shorten(5);  //so here the entire post i want to keep only the first 5 words from it

            Console.WriteLine(shortenedPost);
        }
    }
}
