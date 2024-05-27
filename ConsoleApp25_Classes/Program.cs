namespace ConsoleApp25_Classes
{
    public class Person
    {
        public string _name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi, {0} I am {1}", to, _name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person._name = str;

            return person;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating instances of class (objects)
            Person person = new Person();
            var person2 = new Person();

            //Accessing class instance members: we initialize the field with a value, we call the method Introduce()
            person._name = "John";
            person.Introduce("Mosh");

            //Accessing class static members: we call the static method Parse(), 
            var person3 = Person.Parse("John");
            person3.Introduce("Mosh");

        }
    }
}
