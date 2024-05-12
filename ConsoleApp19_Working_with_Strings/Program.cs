namespace ConsoleApp19_Working_with_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trimming whitespaces
            var fullName = "Mosh Hamedami ";
            Console.WriteLine("Trim() usage: '{0}'", fullName.Trim());

            //Method ToUpper()
            Console.WriteLine("Trim() usage: '{0}'", fullName.Trim().ToUpper());

            //Splitting strings
            //a)
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            //b)
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            //Method Replace()
            var str1 = fullName.Replace("Mosh", "Moshfegh");
            var str2 = fullName.Replace('o', 'O');
            var str3 = fullName.Replace(' ', '!');
            Console.WriteLine(str1);

            //Checking that user has inserted a number in his input in FE
            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(""))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            //Converting strings to numbers
            var str = "25";
            //a) using Convert class and To... method
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            //Converting numbers to strings
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));



        }
    }
}
