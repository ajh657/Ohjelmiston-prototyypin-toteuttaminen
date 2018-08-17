using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("What is your name");

            string username = Console.ReadLine();

            Console.WriteLine("Hello: " + username + ".");

            Console.WriteLine("Press any key to exit");

            Console.Read();

        }
    }
}
