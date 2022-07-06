using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_06_02_plikitxt
    {
        public static void Program()
        {
            ReadFiles();
        }
        static void ReadFiles()
        {
            var document1 = File.ReadAllText(@"C:\Users\dawid.szczurkowski\source\repos\Nauka_CSharp\Kurs_Youtube\Zadania\PlikiTekstowe\dokument1.txt");
            var document2 = File.ReadAllLines(@"C:\Users\dawid.szczurkowski\source\repos\Nauka_CSharp\Kurs_Youtube\Zadania\PlikiTekstowe\dokument2.txt");

            Console.WriteLine("Document1");
            Console.WriteLine(document2);

            Console.WriteLine("Document2");
            Console.WriteLine(document2);
        }
    }
}
