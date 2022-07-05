using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_02_08_rzut
    {
        public static void Rzuty()
        {
            byte byteValue = 100;
            int intValue = byteValue;


            byte byteValue2 = (byte)intValue;



            string userInput = Console.ReadLine();
            int yearOfBirth;
            int.TryParse(userInput, out yearOfBirth);
            int age = DateTime.Now.Year - yearOfBirth;
            Console.WriteLine("You are " + age);
        }
    }
}
