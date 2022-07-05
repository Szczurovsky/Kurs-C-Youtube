using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_04_07_yield
    {
        public static IEnumerable<int> GetYieldedData()
        {
            for (int i = 0; i < 9; i++)
            {
                yield return i;
            }
        }
        public static void Kluczowe()
        {
            //iterator to ibiekt ktorym mozemy sie poslugiwac
            IEnumerable<int> yieldedData = GetYieldedData();
            foreach(int i in yieldedData)
            {
                Console.WriteLine(i);
            }
        }
    }
}
