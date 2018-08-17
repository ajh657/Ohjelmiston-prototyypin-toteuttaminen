using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iA1 = new int[5];
            int[] iA2 = new int[5];
            int sum = 0;

            Random rnd = new Random();


            for (int i = 0; i < 5; i++)
            {
                iA1[i] = rnd.Next(1, 7);
                iA2[i] = rnd.Next(1, 7);
            }

            sum += iA1.Sum();
            sum += iA2.Sum();

            Console.WriteLine(sum);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
