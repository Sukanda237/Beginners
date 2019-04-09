using System;

namespace ReferenceTypesandValueType2
{
    public class Person
    {
        public int age;
    }

    class Program
    {
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
        }

        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { age = 20 };
            MakeOld(person);
            Console.WriteLine(person.age);

            Console.ReadKey();
        }
    }
}
