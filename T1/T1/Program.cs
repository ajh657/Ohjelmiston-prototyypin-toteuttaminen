using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {

            string workstring;

            int worknum;

            while (true)
            {
                workstring = Console.ReadLine();

                worknum = int.Parse(workstring);

              if (worknum <= 10)
                {
                    break;
                }
            }

            int i = 1;

            int resultmulti;
            int resultdiv;
            int resultpro;

            while (i <= 10)
            {
                resultmulti = i * worknum;
                resultdiv = i / worknum;
                resultpro = i % worknum;
                string print = i + " * " + worknum + " = " + resultmulti + " " + i + " / " + worknum + " = " + resultdiv + " " + i + " % " + worknum + " = " + resultpro;
                Console.WriteLine(print);
                i++;
            }

            Console.WriteLine("Press any key to exit");

            Console.ReadKey();
        }
    }
}
