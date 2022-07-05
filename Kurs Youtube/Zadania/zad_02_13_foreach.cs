using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_02_13_foreach
    {
        public static void Foreach()
        {
            string[] cars = { "volvo", "bmw", "mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
