using System;

namespace Coba_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            var fullName = "Ujang Sugandi";

            Console.WriteLine("Trim: '{0}'",fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());


            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: ", firstName);
            Console.WriteLine("LatName: ", lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: ", names[0]);
            Console.WriteLine("LatName: ", names[1]);

            Console.WriteLine(fullName.Replace("Ujang","Santoso"));

            if(String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("InValid");
            }

            var str = "21";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.ReadKey();
        }
    }
}
