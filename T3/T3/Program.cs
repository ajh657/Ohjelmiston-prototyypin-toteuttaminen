using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plase insert value in euros");
            string workstring = Console.ReadLine();
            float euro = float.Parse(workstring);
            Console.WriteLine("");
            String currency;

            while (true)
            {
                Console.WriteLine("witch currency do you want to user [(P)ounds/(D)ollars]");
                currency = Console.ReadLine();
                if (currency == "P" || currency =="D" || currency == "p" || currency == "d")
                {
                    Console.WriteLine("");
                    break;
                }

            }

            

            if (currency == "D" || currency == "d")
            {
                float dollar = euro * 1.14611f;
                Console.WriteLine(dollar);
            }
            else if (currency == "P" || currency == "p")
            {
                float pound = euro * 0.896366934f;
                Console.WriteLine(pound);
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
