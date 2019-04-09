using System;

namespace Classes
{
    public class Person
    {
        public string NamaDepan;
        public string NamaBelakang;

        public void Introduce()
        {
            Console.WriteLine("Nama Saya Adalah {0} {1} ", NamaDepan, NamaBelakang);
        }
    }
}
