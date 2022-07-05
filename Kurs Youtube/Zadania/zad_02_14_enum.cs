using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_02_14_enum
    {
        public static void EnumRead()
        {
            Console.WriteLine("Whar is your gender? 1-Male, 2-Female");
            string userInput = Console.ReadLine();
            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput);

            switch (userGender)
            {
                case Gender.Male:
                    Console.WriteLine("Jesteś chłopcem");
                    break;
                case Gender.Female:
                    Console.WriteLine("Jesteś dziewczynką");
                    break;
            }
        }
    }
}
