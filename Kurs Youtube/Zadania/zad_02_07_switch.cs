using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_02_07_switch
    {
        public static void Switch()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It's Monday");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("Hurra");
                    break;
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("The weekend");
                    break;

                default:
                    Console.WriteLine("The middle of the week");
                    break;
            }
        }
    }
}
