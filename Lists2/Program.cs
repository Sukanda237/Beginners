using System;

namespace Lists2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Siapa Nama Kamu : ");
            var nama = Console.ReadLine();

            var array = new char[nama.Length];
            for (var i = nama.Length; i > 0; i--)
                array[nama.Length - i] = nama[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Revesed Nama {0}", reversed);
            Console.ReadKey();
        }
    }
}
