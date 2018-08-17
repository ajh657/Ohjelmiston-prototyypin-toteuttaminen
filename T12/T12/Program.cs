using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i;
                int o;

                i = int.Parse(Console.ReadLine());
                o = int.Parse(Console.ReadLine());

                Console.WriteLine(i/o);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("error: Tried divided by zero");
            }
            finally
            {
                Console.WriteLine("Hei Hei");
                Console.WriteLine();
                Console.WriteLine("Please press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
