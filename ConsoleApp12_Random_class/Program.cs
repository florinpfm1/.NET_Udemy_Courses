namespace ConsoleApp12_Random_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generate integer random numbers between 1 and 10
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

            //generate a random string of characters as letters (e.g. like for passwords)
            Console.WriteLine((int)'a'); //97, is the ASCII code in decimal format for letter a
                                         //122, is the decimal code for letter z

            var random2 = new Random();
            for (int i = 0;i < 10;i++)
                Console.Write((char)random2.Next(97, 122));
            Console.WriteLine();

            //improvement 1
            var random3 = new Random();
            for (int i = 0; i < 10; i++)
                Console.Write((char)('a' + random3.Next(0, 26))); //because there are 26 letters in english alphabeth
            Console.WriteLine();

            //improvement 2
            var random4 = new Random();
            var buffer = new char[10];

            for (int i = 0; i < 10; i++)
                buffer[i] = ((char)('a' + random4.Next(0, 26))); //because there are 26 letters in english alphabeth

            var password = new string(buffer);
            Console.WriteLine(password);

            //improvement 3
            var random5 = new Random();
            const int passwordLength = 10;
            var buffer2 = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
                buffer2[i] = ((char)('a' + random5.Next(0, 26))); //because there are 26 letters in english alphabeth

            var password2 = new string(buffer2);
            Console.WriteLine(password);
        }
    }
}
