using System;
using System.IO;

namespace FileInfos
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Sukanda\source\repos\Beginners\IMG_99822.jpg";

            File.Copy(@"C:\Users\Sukanda\source\repos\Beginners\IMG_99822.jpg", @"G:\campuran\IMG_99822.jpg", true);
            File.Delete(path);
            if(File.Exists(path))
            {

            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }

            Console.ReadKey();
        }
    }
}
