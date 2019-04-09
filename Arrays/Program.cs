using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = new int[3];
            num[0] = 1;
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var nama = new string[3] { "AAF", "AAN", "EEN" };

            Console.ReadKey();
        }
    }
}
