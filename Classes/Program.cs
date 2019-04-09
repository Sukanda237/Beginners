using Classes.Math;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {

            var Joni = new Person();
            Joni.NamaDepan = "Joni";
            Joni.NamaBelakang = "Mundur";
            Joni.Introduce();


            Calculator calculator = new Calculator();

            var result = calculator.Add(1, 2);
            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
