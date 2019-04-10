using System;
using System.Collections.Generic;

namespace Lists1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new List<string>();
            
            while(true)
            {
                Console.Write("Ketikkan nama (atau tekan ENTER untuk keluar): ");

                var input = Console.ReadLine();
                if(String.IsNullOrWhiteSpace(input))
                {
                    break;  
                }
                name.Add(input);
            }

            if(name.Count > 2)
            {
                Console.WriteLine("{0}, {1} dan {2} lainnya menyukai posting Anda", name[0], name[1], name.Count -2);
            }
            else if (name.Count == 2 )
            {
                Console.WriteLine("{0}, dan {1} menyukai posting Anda", name[0], name[1]);
            }
            else if (name.Count == 1)
            {
                Console.WriteLine("{0}  menyukai posting Anda", name[0]);
            }
            else { Console.WriteLine("tidak ada yang munyukai postingan anda"); }

            Console.ReadKey();

        }
    }
}
