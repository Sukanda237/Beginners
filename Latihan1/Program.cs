using System;

namespace Latihan1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Masukan Angka Dari 1 sampai 10");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

                if (number >= 1 && number <= 10)
                {
                    Console.WriteLine("Angka Valid");
                }
                else
                {
                    Console.WriteLine("Angka tidak Valid");
                }


            Console.ReadKey();
        }
    }
}
