using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxW = 100;
            int CurrentW = 0;
            int addidiveW;

            while (true)
            {
                addidiveW = int.Parse(Console.ReadLine());

                CurrentW = CurrentW + addidiveW;
                    
                if (CurrentW >= maxW)
                {
                    Console.WriteLine("max Weight exeeded");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Too Heavy");
                    

                }
            }
        }
    }
}
