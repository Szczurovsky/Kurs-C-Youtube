using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_04_01_kolekcje
    {
        public static void Kolekcja()
        {
            List<int> intList = new List<int>();
            intList.Add(6);
            intList.Add(7); 
            foreach(int i in intList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
