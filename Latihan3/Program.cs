using System;

namespace Latihan3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan Lebar Foto");
            var leb = Console.ReadLine();
            var lebar = Convert.ToInt32(leb);

            Console.WriteLine("Masukan Tinggi Foto");
            var ting = Console.ReadLine();
            var tinggi = Convert.ToInt32(ting);

            if(lebar > tinggi)
            {
                Console.WriteLine("Ini Gambar landscape");
            }
            else
            {
                Console.WriteLine("Ini Gambar portrait");
            }

            Console.ReadKey();
        }
    }
}
