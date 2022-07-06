using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class transformacjaWartosciString
    {
        public static void Program()
        {
            Console.WriteLine("Insert kebab cased variable name");
            string kebabCased = Console.ReadLine(); 

            Console.WriteLine(KebabToCamelCase(kebabCased));
        }
        static string KebabToCamelCase(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if(currentChar != '-')
                {
                    sb.Append(currentChar);
                }
                else
                {
                    char nextChar = input[i + 1];
                    sb.Append(char.ToUpper(nextChar));
                    i++;
                }
            }
            return sb.ToString();
        }
        static string CamelToKebabCase(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char currentChar in input)
            {
                if (char.IsUpper(currentChar))
                {
                    sb.Append("-");
                    sb.Append(char.ToLower(currentChar));
                }
                else
                {
                    sb.Append(currentChar);
                }
            }
            return sb.ToString();
        }
    }
}
