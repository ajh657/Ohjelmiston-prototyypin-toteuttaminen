using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13
{
    class Program
    {
        enum days
        {
            maanantai,
            tiistai,
            keskiviikko,
            torstai,
            perjantai,
            lauantai,
            sunnuntai,
        }

        public enum grades
        {
            HuonoArvosana,
            VälttäväArvosana,
            TyydyttäväArvosana,
            HyväArvosana,
            KiitettäväArvosana,
            ErinomainenArvosana

        }

        static void Main(string[] args)
        {
            int day;
            int grades;
            string input;
            bool daytest;
            bool gradetest;
            while (true)
            {
                Console.WriteLine("Please input number 1-7");
                input = Console.ReadLine();
                daytest = int.TryParse(input, out day);
                if (daytest && day <= 7)
                {
                    day = day - 1;
                    switch (day)
                    {
                        case 0:
                            Console.WriteLine(Enum.GetName(typeof(days), day));
                            break;

                        case 1:
                            Console.WriteLine(Enum.GetName(typeof(days), day));
                            break;

                        case 2:
                            Console.WriteLine(Enum.GetName(typeof(days), day));
                            break;

                        case 3:
                            Console.WriteLine(Enum.GetName(typeof(days), day));
                            break;

                        case 4:
                            Console.WriteLine(Enum.GetName(typeof(days), day));
                            break;

                        case 5:
                            Console.WriteLine(Enum.GetName(typeof(days), day));
                            break;

                        case 6:
                            Console.WriteLine(Enum.GetName(typeof(days), day));
                            break;

                        default:
                            continue;
                    }
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please input number 5- 10");
                input = Console.ReadLine();
                gradetest = int.TryParse(input, out grades);
                if (gradetest && grades <= 10 && grades >= 5)
                {
                    grades = grades - 5;
                    switch (grades)
                    {
                        case 0:
                            Console.WriteLine(Enum.GetName(typeof(grades), grades));
                            break;

                        case 1:
                            Console.WriteLine(Enum.GetName(typeof(grades), grades));
                            break;

                        case 2:
                            Console.WriteLine(Enum.GetName(typeof(grades), grades));
                            break;

                        case 3:
                            Console.WriteLine(Enum.GetName(typeof(grades), grades));
                            break;

                        case 4:
                            Console.WriteLine(Enum.GetName(typeof(grades), grades));
                            break;

                        case 5:
                            Console.WriteLine(Enum.GetName(typeof(grades), grades));
                            break;

                        case 6:
                            Console.WriteLine(Enum.GetName(typeof(grades), grades));
                            break;

                        default:
                            continue;
                    }
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Plase press any key to exit");
            Console.ReadKey();
        }
    }
}
