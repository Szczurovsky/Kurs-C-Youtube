using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_02_06
    {
        public static void isLegal()
        {
            Console.WriteLine("Podaj swój wiek");
            string userInput = Console.ReadLine();

            int yearOfBirth = int.Parse(userInput);
            bool isLegal = DateTime.Now.Year - yearOfBirth > 18;
            if (isLegal)
            {
                Console.WriteLine("Jesteś git");
            }
            else
            {
                Console.WriteLine("Uciekaj stąd");
            }

            Console.WriteLine("bye");

        }
    }
}
