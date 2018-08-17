using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit;
            fruit = new string[3];

            fruit[0] = "apple";
            fruit[1] = "orange";
            fruit[2] = "chokecherry";

            Console.WriteLine("How many fruits to show?");
            int arraytest = int.Parse(Console.ReadLine());
            int i = 0;

            while (i < arraytest)
            {
                Console.WriteLine(fruit[i]);
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit");
            Console.ReadKey();
        }
    }
}
