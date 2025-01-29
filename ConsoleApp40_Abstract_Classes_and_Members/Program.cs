namespace ConsoleApp40_Abstract_Classes_and_Members
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

            //Rules for abstract members:
            //var shape = new Shape(); //cannot instanciate n abstract class, it will not compile


        }
    }
}
