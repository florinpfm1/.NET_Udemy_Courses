namespace ConsoleApp30_Access_Modifiers
{
    public class Person
    {
        private DateTime _birthdate;

        //2 methods for setting/getting the value of field _birthdate (which is private)
        //in real world applications, we won't do like this, we will declare properties for the class !!!!!
        public void SetBirthdate(DateTime birthdate)
        {
            //when we have a Setter method we can validation if needed to make sure the input value received from outside is valid
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());
            

        }
    }
}
