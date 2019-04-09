using System;

namespace CobaEnum
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegistereAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodeId = 3;
            Console.WriteLine((ShippingMethod)methodeId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            Console.ReadKey();
        }
    }
}
