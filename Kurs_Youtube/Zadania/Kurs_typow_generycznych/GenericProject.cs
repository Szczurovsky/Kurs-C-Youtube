using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania.Kurs_typow_generycznych
{
    internal class GenericProject
    {
        public delegate void Display(string value);
        public static void Program()
        {
            void WriteWithComa(string value)
            {
                Console.WriteLine(value + ", ");
            }

            Display display = (string value) => Console.Write(value + ", ");
            display("Test");

            var numbers= new int[] {10,20,30};
            var count = Count(numbers);
            Console.WriteLine(count);
            DisplayNumber(numbers, display);
            //var restaurants = new List<Restaurant>();
            //var result = new PaginatedResult<Restaurant>();

            //result.Results = restaurants;
            ////var stringRepository = new Repository<string>();
            ////stringRepository.AddElement("some value");
            ////string firstElement = stringRepository.GetElement(0);

            //var userRepository = new Repository<string, User>();

            //userRepository.AddElement("Bill", new User() { Name = "Bill" });
            //User bill = userRepository.GetElement("Bill");
            //Console.WriteLine(bill.Name);
            //int[] intArray = new[] { 1, 3, 5 };
            //Utils.Swap<int>(ref intArray[0], ref intArray[2]);

            //Console.WriteLine(string.Join(" ", intArray));

        }
        static void DisplayNumber(IEnumerable<int> numbers, Display display)
        {
            foreach (int number in numbers)
            {
                display(number.ToString());
            }
        }
        static int Count(IEnumerable<int> numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number > 15)
                {
                    count++;
                }
            }
            return count;
        }
    }

}
