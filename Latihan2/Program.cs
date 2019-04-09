using System;

namespace Latihan2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukakan Angka 1");
            var nomor1 = Console.ReadLine();
            var angka1 = Convert.ToInt32(nomor1);

            Console.WriteLine("Masukakan Angka 2");
            var nomor2 = Console.ReadLine();
            var angka2 = Convert.ToInt32(nomor2);

            if (angka1 > angka2)
            {
                Console.WriteLine("MAX {0}",angka1);
            }
            else
            {
                Console.WriteLine("MAX {0}", angka2);
            }

            Console.ReadKey();
        }
    }
}
