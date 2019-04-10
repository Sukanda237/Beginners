using System;
using System.Collections.Generic;

namespace Lists5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements;

            while(true)
            {
                Console.WriteLine("Masukkan daftar nomor yang dipisahkan koma:");
                var input = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("List Tidak Valid");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while(smallests.Count < 3)
            {
                var min = numbers[0];
                foreach (var number in numbers)
                { 
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("3 angka terkecil adalah: ");
            foreach(var number in elements)
            Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
