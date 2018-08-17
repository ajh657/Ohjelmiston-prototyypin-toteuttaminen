using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plase insert height in cm.");
            string workstring = Console.ReadLine();
            float worknum = int.Parse(workstring);

            float inch = worknum * 0.39370f;
            float meter = worknum * 0.01f;
            float yard = worknum * 0.010936133f;
            float miles = worknum * 0.000006213711922f;

            Console.WriteLine();
            Console.WriteLine("Inches: " + inch);
            Console.WriteLine("Meters: " + meter);
            Console.WriteLine("Yards: " + yard);
            Console.WriteLine("Miles: " + miles);

            Console.WriteLine();
            Console.WriteLine("Plase press any key to exit");
            Console.ReadKey();
        }
    }
}
