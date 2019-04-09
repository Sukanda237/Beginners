using System;

namespace IfElseandSwitchCase
{

    class Program
    {
        public static void Kondisi(int hour)
        {
            

             if(hour > 0 && hour< 12)
            {
                Console.WriteLine("Selamat Pagi.");
            }
            else if (hour >=12 && hour<18)
            {
                Console.WriteLine("Selamat Sore");
            }
            else
            {
                Console.WriteLine("Selamat Malam");
            }
            Console.ReadKey();
        }

        public static void Price(float price)
        {
            bool isGoldCustomer = true;
            price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
        }

        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beatiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect to go beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that Season.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
