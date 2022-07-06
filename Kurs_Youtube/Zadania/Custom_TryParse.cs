using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class Custom_TryParse
    {
        public static void Program()
        {
            int Negative_number;
            bool negative = IsItMinus("1", out Negative_number);
            Console.WriteLine($"Sprawdzana liczba to liczba ujemna? {negative}, i wynosi {Negative_number}");
        }
        // rozwiazanie z ref - public static bool IsItMinus(string negative_string, ref int negative_number)
        public static bool IsItMinus(string negative_string, out int negative_number)
        {
            int Negative_number = int.Parse(negative_string);
            if(int.TryParse(negative_string,out negative_number))
            {
                if (negative_number < 0) 
                {
                    negative_number = Negative_number;
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else 
            {
                negative_number = default;
                return false; 
            }
        }

    }
}
