using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new List<int> { 1, 2, 3, 4, };

            number.Add(1);
            number.AddRange(new int[] { 5, 7 });

            foreach (var n in number)
                Console.WriteLine(n);

            Console.WriteLine();
            Console.WriteLine("index pertama {0}", number.IndexOf(1));
            Console.WriteLine("index terakhir {0}", number.LastIndexOf(1));
            Console.WriteLine("Count = {0}", number.Count);


            number.Remove(1);
            Console.ReadKey();

            for (var i = 0; i <= number.Count; i++)
            {
                if (number[i] == 1)
             number.Remove(number[i]);

            }
            foreach (var n in number)            
                Console.WriteLine(n);

            number.Clear();
            Console.WriteLine("Count = {0}", number.Count);
        }
    }
}
