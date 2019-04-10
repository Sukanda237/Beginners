using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new int[] {1,4,6,8,9,53,98,76,5 };

            //menuntukan panjang array
            //Length
            Console.WriteLine(number.Length);

            //mencari index
            //IndexOf
            var index = Array.IndexOf(number, 9);
            Console.WriteLine(index);

            //clear
            Array.Clear(number, 5, 4);
            Console.WriteLine("Nilai yangterhapus ");
            foreach (var n in number)
                Console.WriteLine(n);

            //copy
            var number2 = new int[5];
            Array.Copy(number, number2, 5);
            Console.WriteLine("Nilai yang ke Copy ");
            foreach (var n in number2)
                Console.WriteLine(n);

            //sort
            Array.Sort(number);
            Console.WriteLine("Sort");
            foreach (var n in number)
                Console.WriteLine(n);

            //Reverse
            Array.Reverse(number);
            Console.WriteLine("Reverse");
            foreach (var n in number)
                Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
