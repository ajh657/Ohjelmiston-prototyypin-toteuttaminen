using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8
{
    class Program
    {
        enum TimesofYear
        {
            talvi,
            kevät,
            kesä,
            syksy,
        }

        enum Months
        {
            Tammikuu,
            Helmikuu,
            Maaliskuu,
            Huhtikuu,
            Toukokuu,
            Kesäkuu,
            Heinäkuu,
            Elokuu,
            Syyskuu,
            Lokakuu,
            Marraskuu,
            Joulukuu
        }
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int nowMonth = now.Month;
            int currentMonth = nowMonth - 1;
		
            Console.WriteLine(Enum.GetName(typeof(Months), currentMonth));
            Console.WriteLine(Enum.GetName(typeof(TimesOfYear), currentMonth));

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
