using System;
using System.Collections.Generic;

namespace Lists3
{
    class Program
    {
        static void Main(string[] args)
        {

            var angka = new List<int>();

            while (angka.Count < 5)                
            { 
            Console.Write("Masukan Angka : ");
                var no = Convert.ToInt32(Console.ReadLine());
                if(angka.Contains(no))
                {
                    Console.WriteLine("Anda sudah masuk sebelumnya" + no);
                    continue;
                }
                angka.Add(no);
            }

            angka.Sort();
            foreach (var no in angka)
                Console.WriteLine(no);

            Console.ReadKey();
        }
    }
}
