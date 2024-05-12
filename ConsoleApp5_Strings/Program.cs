namespace ConsoleApp5_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating types with C# keywords or with .NET equivalent structs/classes
            /*
            byte a = 5;
            Byte a1 = 5;

            short b = 10;
            Int16 b1 = 10;

            int c = 1000;
            Int32 c1 = 1000;

            long d = 5000;
            Int64 d1 = 5000;

            float e = 1.2f;
            Single e1 = 1.2f;

            double g = 1.3;
            Double g1 = 1.3;

            decimal h = 1.9m;
            Decimal h1 = 1.9m;

            char x = 'a';
            Char x1 = 'a';

            bool y = false;
            Boolean y1 = false;

            string name = "Tom";
            String name1 = "Tom";
            */

            //Demo: strings
            string firstName = "Mosh";
            var myName = "Florin";
            String lastName = "Hamedami";

            //Creating strings with String Literal
            string myString = "Yellow";

            //Creating strings with concatenation
            var fullName = firstName + " " + lastName;

            //Creating strings with String Format
            var fullName1 = string.Format("My name is {0} {1}", firstName, lastName);

            //Creating strings with String Join
            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            //Verbatim Strings
            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            
            var text2 = @"Hi John
                       Look into the following paths
                       c:\folder1\folder2
                       c:\folder3\folder4";
            Console.WriteLine(text2);
        }
    }
}
