namespace ConsoleApp22_Working_with_Files_and_Directories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class File
            var path = @"c:\somefile.jpg";
            File.Copy("c:\\temp\\myfile.jpg", "d:\\temp\\myfile.jpg", true);
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //......
            }

            var content = File.ReadAllText(path);

            //class FileInfo
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists) //is a Property
            {
                //............
            }

            //class Directory
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var files2 = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files2)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("....");

            //class DirectoryInfo
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            //class Path
            var path2 = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";
            Console.WriteLine("Extension is: " + Path.GetExtension(path2));
            Console.WriteLine("File Name is: " + Path.GetFileName(path2));
            Console.WriteLine("File Name withoutExtension is: " + Path.GetFileNameWithoutExtension(path2));
            Console.WriteLine("Directory is: " + Path.GetDirectoryName(path2));



        }
    }
}
