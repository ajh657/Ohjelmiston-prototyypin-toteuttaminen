using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7T
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("How many items to add?");
            int items = int.Parse(Console.ReadLine());
            int i = 0;

            float[] ProductPrice;
            ProductPrice = new float[items];

            int[] productCount;
            productCount = new int[items];

            string[] productName;
            productName = new string[items];

            while (i <= items)
            {
                int num = i+1;
                Console.WriteLine("Give " + num + ". items name");
                productName[i] = Console.ReadLine();

                Console.WriteLine("Give " + num + ". items price");
                ProductPrice[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Give " + num + ". items count");
                productCount[i] = int.Parse(Console.ReadLine());

                i++;
            }

            i = 0;
            Console.WriteLine();

            while (i <= items)
            {
                float totalprice;
                totalprice = productCount[i] * ProductPrice[i];
                Console.WriteLine(productName + "total price is" + totalprice + "€");
                Console.WriteLine();

                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
