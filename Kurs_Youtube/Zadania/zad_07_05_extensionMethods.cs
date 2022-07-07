using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_07_05_extensionMethods
    {
        public static void Program()
        {
            DateTime now = DateTime.Now;
            DateTime before = now.Subtract(new TimeSpan(7, 0, 0, 0));
            DateTime after = now.AddDays(7);
            Utils.IsDateBetween(now,before,after);


            bool isDateBetween2=  now.IsBetween(before, after);
            int value = 2;
            value.Squared();
        }
        
    }
    public static class Utils
    {
        public static bool IsDateBetween(DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;
        }  
        public static bool IsBetween(this DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;
        }
        public static int Squared(this int value)
        {
            return value * value;
        }

    }
}
