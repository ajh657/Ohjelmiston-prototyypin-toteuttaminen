using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what age are you");
            int age = int.Parse(Console.ReadLine());
                
            Console.WriteLine();
            Console.WriteLine("What Gender are you [(M)an/(W)oman]");

            string gender = Console.ReadLine();

            if (gender == "M" || gender == "m")
            {
                ageM(age);
            }
            else if (gender == "W" || gender == "w")
            {
                ageW(age);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        static void ageM(int ageint)
        {
            if (ageint < 13)
            {
                Console.WriteLine("Mitä poitsu");
                return;
            }

            if (ageint < 14 && ageint > 25)
            {
                Console.WriteLine("Mitä nuorimies");
                return;
            }

            if (ageint < 26 && ageint > 56)
            {
                Console.WriteLine("Olet mies parhaassa iässä");
                return;
            }

            if (ageint > 56)
            {
                Console.WriteLine("Hei hei");
                return;
            }
        }

        static void ageW(int ageint)
        {
            if (ageint < 13)
            {
                Console.WriteLine("Mitä tyttö");
                return;
            }

            if (ageint < 14 && ageint > 25)
            {
                Console.WriteLine("Mitä nuorinainen");
                return;
            }

            if (ageint < 26 && ageint > 56)
            {
                Console.WriteLine("Olet parhaassa muodossa");
                return;
            }

            if (ageint > 56)
            {
                Console.WriteLine("Hei hei");
                return;
            }
        }
    }
}
