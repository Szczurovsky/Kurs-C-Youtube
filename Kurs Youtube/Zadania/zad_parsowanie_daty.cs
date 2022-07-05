using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_parsowanie_daty
    {
        public static void Parsowanie_daty()
        {


            Console.WriteLine("Podaj swoj rok urodzenia");
            int Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj miesiąc urodzenia");
            int Month = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj dzien urodzenia");
            int Day = int.Parse(Console.ReadLine());
            DateTime birth = new DateTime(Year, Month, Day, 10, 3, 1);
            TimeSpan timeSpan = DateTime.Now - birth;

            Console.WriteLine((int)timeSpan.TotalDays);
        }
    }
}
