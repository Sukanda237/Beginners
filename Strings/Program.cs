using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var namaDepan = "Dudung";
            string namaBelajang = "SuDudung";

            var fullname = namaDepan + " " + namaBelajang;

            var myFullName = string.Format("Nama saya {0} {1}", namaDepan, namaBelajang);

            var names = new string[3] { "AAF", "AAN", "EEN" };
            var formattedNames = string.Join(" ", names);

            Console.WriteLine(formattedNames);


            var text = "Hai Dudung\nLook into the following paths\nc:\\folder1\\folder2\nc:folder2\\folder3 ";
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
