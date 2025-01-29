namespace ConsoleApp51_Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();


            //^^^ LINQ Extension Methods ^^^:

            //because the argument of Where() takes a delegate Func() with predicate, we can use lambda expressions
            //also no we can chain multiple queries one after the other with "."
            var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title); //IMPORTANT: the Where() returns a list of Books with IEnumerable
                                   //here we are filtering by Price
                                                           //here we are sorting by Title
                                                                                  //here we are selecting only the string Title of each Book, thus we are converting
                                                                                  //the initial List<Book> into a List<string> with all the Title of books
            
            //the writing convention is each query below the other like this: because all the chain can get very long and hard to read
            var cheapBooks2 = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            foreach (var item in cheapBooks)
            {
                Console.WriteLine(item);
            }


            //^^^ LINQ Query Operators ^^^:
            var cheaperBooks = 
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;


            //More code examples with ^^^ LINQ Extension Methods ^^^

            //if you want a single object Book in the result of the query we need to use Single(), and not the Where()

            //the Single() <<<--- expects to be one object and one alone in your collection that satisfies the condition given, if there is none it throws an exception
            var book = books.Single(b => b.Title == "ASP.NET MVC");

            //the SingleOrDefault() <<<--- if you are not sure that object exists or not in your collection we use the SingleOrDefault()
            //because if there is no object found, than the default value for the object will be returned, in this case is null, so there will not be an exception thrown
            var book2 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC and others");

            //the First() <<<-- is used to get the first object in a collection
            var book3 = books.First(); //we don't need to give a lambda exp here
            var book4 = books.First(b => b.Title == "C# Advanced Topics"); //optionally we can give a lambda exp to act like a filter
                                                                           //it will find 2 books with this title, but it will return only the first book

            //the FirstOrDefault() <<<--- if there are no objects that satisfy the condition, it will return the default value instead of throwing an exception
            var book5 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");

            //the Last()

            //the LastOrDefault()

            //the Skip() and Take() - with Skip() we skip x elements in the collection, with Take() we return the y elements in the collection
            var book6 = books.Skip(2).Take(3); //it returns an IEnumerable<Book> , so it's a list of Book

            //the Count()
            var count = books.Count(); //it counts the total number of elements in the list books

            //the Max() - return the max of the elements in the list of Book, but we need to define what Max means
            var maxPrice = books.Max(b => b.Price); //so here it return the max price of the books inside the list

            //the Min()
            var minPrice = books.Min(b => b.Price); //so here it return the min price of the books inside the list

            //the Sum()
            var totalPrices = books.Sum(b => b.Price);






            Console.WriteLine(book.Title);
            
            foreach (var elem in book6)
            {
                Console.WriteLine(book.Title);
            }








        }
    }
}
