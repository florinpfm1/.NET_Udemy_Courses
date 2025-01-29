using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Generics
{
    public class Person : IComparable<Person>
    {
        public int Age { get; set; }

        //here we define the implementation of CompareTo and how this method will compare 2 objects of type Person
        public int CompareTo(Person? other)
        {
            //as seen below it uses the property Age to compare 2 objects of type Person
            if (this.Age < other.Age)  //this represents the instance of Person on which we are calling the "CompareTo" method; other is an argument given to the method when is called
            {
                return -1;
            }
            else if (this.Age == other.Age)
            {
                return 0;
            }
            else
            {
                return 1;
            }


        }
    }
}
