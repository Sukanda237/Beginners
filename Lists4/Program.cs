using System;
using System.Collections.Generic;

namespace Lists4
{
    class Program
    {
        static void Main(string[] args)
        {

            var angka = new List<int>();

            while(true)
            {
                Console.Write("Masukkan nomor (atau 'Berhenti' untuk keluar):");
                var input = Console.ReadLine();

                if (input.ToLower() == "berhenti")
                    break;

                angka.Add(Convert.ToInt32(input));

            }

            var uniques = new List<int>();
            foreach (var no in angka)
            {
                if (!uniques.Contains(no))
                    uniques.Add(no);
            }
                Console.WriteLine("Angka Unik");
            foreach (var no in uniques)
                Console.WriteLine(no);

            Console.ReadKey();
        }
    }
}
