namespace ConsoleApp1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ queries applied on array of integer and strings
            string sentence = "I love cats";
            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

            // loop through, apply condition, when condition is met add item to new list  <<<=== ALL THIS CAN BE DONE WITH LINQ !! ***
            List<int> newNumbersBelowFive = new List<int>();
            foreach (var number in numbers)
            {
                if (number < 5)
                {
                    newNumbersBelowFive.Add(number);
                }
            }
            Console.WriteLine(string.Join(", ", newNumbersBelowFive));

            // all the above can be executed the same with fewer code using LINQ queries
            var getTheNumbersBelowFive = from number in numbers
                                         where number < 5
                                         select number;
            Console.WriteLine(string.Join(", ", getTheNumbersBelowFive));  //<<-- the LINQ query is executed only in this line where
                                                                           //the var getTheNumbers is actually used for something

            var getTheNumbersBelowFive2 = from number in numbers
                                          where number > 5 && number < 10 // we can have multiple filtering conditions
                                          orderby number
                                          select number;
            Console.WriteLine(string.Join(", ", newNumbersBelowFive));


            // to filter cat names containing letter "a" and length greater than 4
            var catsWithA = from cat in catNames
                            where cat.Contains("a") && (cat.Length > 4)
                            orderby cat // by default sorts "ascending", no need to use ascending here
                            select cat;
            Console.WriteLine(string.Join(", ", catsWithA));

            var catsWithA2 = from cat in catNames
                             where cat.Contains("a")  // we can have multiple filtering conditions
                             where cat.Length > 4     // we can have multiple filtering conditions
                             orderby cat descending
                             select cat;
            Console.WriteLine(string.Join(", ", catsWithA2));

            // LINQ queries applied on objects
            List<Person> people = new List<Person>
            {
                new Person("Tod", 180, 70, Gender.Male),
                new Person("John", 170, 88, Gender.Male),
                new Person("Anna", 150, 48, Gender.Female),
                new Person("Kyle", 164, 77, Gender.Male),
                new Person("Anna", 164, 77, Gender.Male),
                new Person("Maria", 160, 55, Gender.Female),
                new Person("John", 160, 55, Gender.Female)
            };

            var fourCharPeople = from p in people
                                 where (p.Name.Length == 4)
                                 orderby p.Weight
                                 select p;
            foreach (var item in fourCharPeople)
            {
                Console.WriteLine($"Name: {item.Name}, Weight: {item.Weight}");
            }

            var fourCharPeople2 = from p in people
                                 where (p.Name.Length == 4)
                                 orderby p.Name
                                 select p.Name;
            foreach (var item in fourCharPeople2)
            {
                Console.WriteLine($"Name: {item}");
            }

            var fourCharPeople3 = from p in people
                                 where (p.Name.Length == 4)
                                 orderby p.Name descending, p.Height // <<<--- we can have multiple orderby conditions
                                                          // first orders by Name, then all with the same name are ordered by Height
                                  select p;
            foreach (var item in fourCharPeople3)
            {
                Console.WriteLine($"Name: {item.Name}, Height: {item.Height}");
            }




        }

        internal class Person
        {
            //fields
            private string name;
            private int height;
            private int weight;
            private Gender gender;

            //props
            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Height
            {
                get { return this.height; }
                set { this.height = value; }
            }
            public int Weight
            {
                get { return this.weight; }
                set { this.weight = value; }
            }

            public Gender Gender
            {
                get;
                set;
            }

            //CTOR
            public Person(string name, int height, int weight, Gender gender)
            {
                this.Name = name;
                this.Height = height;
                this.Weight = weight;
                this.Gender = gender;
            }
        }

        internal enum Gender
        {
            Male,
            Female
        }
    }
}
