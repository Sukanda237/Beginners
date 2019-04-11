using System;
using System.Collections.Generic;

namespace Coba_String2
{
     public class Program
    {
        static void Main(string[] args)
        {

            var sentence = "This is going to be a realy realy realy realy long text";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);

            Console.ReadKey();
        }

     
    }
}
