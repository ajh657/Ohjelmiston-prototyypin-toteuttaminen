using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please press any key");

            ConsoleKeyInfo test = Console.ReadKey();
            char Ctest = test.KeyChar;

            Console.Clear();

            if (Ctest == '\u0020')
            {
                Console.WriteLine("Empty");
            } else
            {
                Console.WriteLine(Ctest);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
