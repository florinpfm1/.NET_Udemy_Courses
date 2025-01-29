namespace ConsoleApp46_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var a = System.Collections.Generic.;  //after point Intelisesnse shows all generic classes available in .NET framework


            //Next we want to use class GenericList of elements <T> to create a list of elements int, and then another list of elements Book

            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            var numbers = new GenericList<int>(); //we used class GenericList to create a list of int
            numbers.Add(15);
            numbers.Add(16);

            var books = new GenericList<Book>(); //we used class Generic List to create a list of Book
            books.Add(new Book());
            books.Add(book);

        }
    }
}
