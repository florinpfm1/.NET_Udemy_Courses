namespace ConsoleApp47_Delegates
{
    
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo); //this delegate is a pointer to a group of methods that
                                                              //have this signature: void Xxxxx(Photo photo)
                                                              //so they are void and have a param of type Photo

        //changed method that also receives a delegate
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo); //so this means that this Process() method receives a filterHandler
                                   //and does not know what filter will be applied
                                  //It is the responsability of the consumer of this code, they will define the filters they want to be applied on the photo
                                  //here the consumer would be the developer that write code in Program.cs, because from there he will call all these


            photo.Save();
        }



        //original method without delegate
        /*
        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
        */
    }
}
