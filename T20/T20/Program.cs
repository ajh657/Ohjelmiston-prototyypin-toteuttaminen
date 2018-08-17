using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T20
{
    class Program
    {
        static void Main(string[] args)
        {

            string tobid;
            int cBid;
            int nBid;
            Console.WriteLine("Item to bid");
            tobid = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please make a bid");
            cBid = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please make a bid");
                nBid = int.Parse(Console.ReadLine());

                if (cBid > nBid) break;
                cBid = nBid;
            }

            Console.WriteLine();

            Console.WriteLine("The bid " + cBid + " Won");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
