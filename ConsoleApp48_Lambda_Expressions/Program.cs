using System.Reflection;

namespace ConsoleApp48_Lambda_Expressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //clasic way when we use a predicate method which is defined below low
            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars); //FindAll() method has a predicate as argument

            //**** new way, same thing but written with lambda expression ****
            var cheapBooks = books.FindAll(b => b.Price < 10); //b comes for book, is the name of the argument in lambda expression

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title); ;
            }
        }

        static bool IsCheaperThan10Dollars(Book book)  //this is a predicate method, will return the Book only is the condition is satisfied
        {
            return book.Price < 10;
        }


    }
}
