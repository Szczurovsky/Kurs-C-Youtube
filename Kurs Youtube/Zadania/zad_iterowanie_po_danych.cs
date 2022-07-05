using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_iterowanie_po_danych
    {
        public static void IterowanieDanych()
        {
            int[] tabliczka = new int[400];
            int liczba;
            int i = 1;
            int suma = 0;
            int maxVal;
            Console.WriteLine("Podaj jakąś liczbę. Podanie cyfry 0 zakończy działanie programu!");
            do
            {

                liczba = int.Parse(Console.ReadLine());
                tabliczka[i] = liczba;
                if (liczba == 0)
                {
                    for (int j = 0; j < tabliczka.Length; j++)
                    {

                        suma = suma + tabliczka[j];
                    }
                    Console.WriteLine($"Największy numer w tabeli to {tabliczka.Max()}");
                    Console.WriteLine($"Suma podanych liczb wynosi: {suma}");
                    break;
                }
                i++;
            } while (true);
        }
    }
}
