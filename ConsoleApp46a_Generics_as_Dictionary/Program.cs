namespace ConsoleApp46a_Generics_as_Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
            dictionary.Add("1235", book);


        }
    }
}
