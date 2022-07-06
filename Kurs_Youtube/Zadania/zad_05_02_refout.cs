using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_05_02_refout
    {
        static bool isDivisible(int value, int factor, out int reminder) 
        {
            reminder = value % factor;
            return reminder == 0;
        }
        public static void Double(ref int value)
        {
            value = 2 * value;
            Console.WriteLine("Zdublowana wartosc ref "+value);
        }
        public static void DoubleWithoutRef( int value)
        {
            value = 2 * value;
            Console.WriteLine("Zdublowana wartosc " + value);
        }
        public static void Program()
        {
            int value = 5;
            int factor = 2;
            int reminder;
            int someVal = 5;
            DoubleWithoutRef(someVal);
            Console.WriteLine("Double val " + someVal);
            Double(ref someVal);
            Console.WriteLine("Double val " + someVal);
            DoubleWithoutRef(someVal);
            Console.WriteLine("Double val "+ someVal);

            if(isDivisible(value, factor, out reminder))
            {
                Console.WriteLine($"{value} jest podzielna przez {factor}");

            }
            else
            {
                Console.WriteLine($"{value} nie jest podzielne przez {factor}. Reszta z dzielenia wynosi: {reminder}");
            }
        }
    }
}
