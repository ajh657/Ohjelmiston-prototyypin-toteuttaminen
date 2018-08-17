using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name;
            name = new string[1];

            string output = "";

            int i = 0;
            int t = 0;

            char[] test = new char[1];

            test[0] = '\u0041';

            bool found = false;

            Console.WriteLine("Please input your name");
            name[0] = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(name[0]);
            Console.WriteLine();

            while (i < name[0].Length)
            {
                output += name[0][i];
                output += " ";

                if (i == name[0].Length) break;

                i++;
            }


            Console.WriteLine(output);
            Console.WriteLine();

            output = "";

            i--;

            while (i != 0)
            {
                output += name[0][i];
                output += " ";

                if (i == 1)
                {
                    output += name[0][i - 1];
                    break;
                }
                

                i--;
            }

            Console.WriteLine(output);
            Console.WriteLine();

            while (t > name[0].Length && found == false)
            {
                if (name[0][t] == test[0]) found = true;

                if (t == name[0].Length)
                {
                    break;
                }

                t++;
            }


            string a = "a";
            if (name[0].Contains(a))
            {
                t++;
                Console.WriteLine("Character a found. it is the " + t + ". character");
            }
            else
            {
                Console.WriteLine("Character a not found");
            }

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit");
            Console.ReadKey();
        }
    }
}
