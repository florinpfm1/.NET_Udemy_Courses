namespace ConsoleApp27_Object_Initializers
{
    public class Person
    {
        public int _id;
        public string _firstName;  
        public string _lastName;
        public DateTime _birthDate;

        //No need to create Constructor because we will use object initializer to give initial values to an instance of class Person
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Person personJohn = new Person()
            {
                _firstName = "Mosh",
                _lastName = "Hamedami",
                _birthDate = DateTime.Now
            };
        }
    }
}
