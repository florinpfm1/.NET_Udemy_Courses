namespace ConsoleApp47a_Delegates_with_predefined_from_.NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Problem: there are 3 filters used in class PhotoProcessor, but if a new developer wants to use another filter
            //then i need to create it in the PhotoFilters class and apply it in PhotoProcessor, and all needs to be recompiled and redeployed
            //so the code is not extensible

            //Solution: with Delegates such a new developer can create their own filter and apply it without the need to change PhotoProcessor.cs and PhotoFilters.cs
            //so the code is extensible (we don't need to recompile and redeploy)

            //Solution2: same problem can be solved by interfaces using some kind of polymorphism


            var processor = new PhotoProcessor(); //instantiate the photo processor

            var filters = new PhotoFilters(); //instantiate the photo filters

            Action<Photo> filterHandler = filters.ApplyBrightness;  //create a delegate and we point it to the filter ApplyBrightness

            filterHandler += filters.ApplyContrast; //here we apply another filter named ApplyContrast

            filterHandler += RemoveRedEyeFilter; //and here i apply the custom new created filter RemoveRedEye
                                                 //i can do this because i defined method RemoveRedEyeFilter() as static, so i can call it from anywhere i want :) !!!
                                                 //NOTE: here i was able to add a new custom filter and the class PhotoProcessor was unchanged !!!!!

            processor.Process("photo.jpg", filterHandler); //and in our Process() method we pass the photo path and the filterHandler
                                                           //If i execute the code, here the filter ApplyBrightness is applied
                                                           //and also ApplyContrast filer

            //so far both these filters were released in class PhotoFilters, so they existed
            //next i will create a new custom filter that was not released in PhotoFilters class


        }

        //here i define the new custom filter not originally released in class PhotoFilters as a method in it
        static void RemoveRedEyeFilter(Photo photo) //defined as static because i want to call it from anywhere
        {
            Console.WriteLine("Apply Remove Red Eye...");
        }
    }
}
