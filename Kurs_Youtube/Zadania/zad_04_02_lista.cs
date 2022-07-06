using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_04_02_lista
    {
        public static void DisplayElements(List<int> list)
        {
            Console.WriteLine("Listaaaaa");
                foreach(int i in list)
            {
                Console.Write($"{i}, ");
            }
        }
        public static void Listy()
        {
            List<int> intList = new List<int>() { 6, 1, 20, 3, 45, 60, 200, 2 };
            DisplayElements(intList);
            Console.WriteLine("New element");
            string userInput = Console.ReadLine();
            int intValue = int.Parse(userInput);
            intList.Add(intValue);
            DisplayElements(intList);
            Console.WriteLine("Remove range");
            intList.RemoveRange(1, 2);
            DisplayElements(intList);
            Console.WriteLine();
            intList.Sort();
            DisplayElements(intList);
        }
    }
}
