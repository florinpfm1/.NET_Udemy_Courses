namespace ConsoleApp33_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100; //property Width is inherited in derived Text class from base PresentationObject class 
                              //we can access property Width in any instance of derived class Text
            text.Copy(); //method Copy() is inherited in derived Text class from base PresentationObject class 
                         //we can use method Copy() in any instance of derived class Text
        }
    }
}
