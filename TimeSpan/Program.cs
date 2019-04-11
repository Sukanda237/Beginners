using System;

namespace TimeSpans
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating
            var timespan = new TimeSpan(1,2,3);

            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration " + duration);


            //Properties
            Console.WriteLine("Minutes " + timespan.Minutes);
            Console.WriteLine("Total Minutes " + timespan.TotalMinutes);


            //Add
            Console.WriteLine("Add Example " + timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example "+timespan.Subtract(TimeSpan.FromMinutes(2)));

            //toString
            Console.WriteLine("ToString " + timespan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

            Console.ReadKey();
        }
    }
}
