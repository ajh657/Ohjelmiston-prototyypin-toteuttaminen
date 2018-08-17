using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num;
            num = new int[5];

            string test;
            bool parse;
            int arrayLength = num.Length;
            int i = 0;
            int display;
            while (i < arrayLength)
            {
                display = i + 1;
                Console.WriteLine("Please input " + display + ". " + "number");
                test = Console.ReadLine();
                parse = int.TryParse(test, out num[i]);
                if (!parse)
                {
                    Console.WriteLine("error: input must be numbers or smaller than 2 147 483 647");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    i++;
                }
            }

            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Here are the numbers");

            foreach (int item in num)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit");
            Console.ReadKey();
        }
    }
}
