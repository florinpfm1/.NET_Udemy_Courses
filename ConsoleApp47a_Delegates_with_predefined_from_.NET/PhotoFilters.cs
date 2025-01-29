namespace ConsoleApp47a_Delegates_with_predefined_from_.NET
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness...");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast...");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo...");
        }
    }
}
