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
            // ReadFiles();
            //GenerateDocuments();
            ScanAndAppend();
        }
        static void GenerateDocuments()
        {
            Console.WriteLine("Insert name");
            var name = Console.ReadLine();

            Console.WriteLine("Insert orderNumber");
            var orderNumber = Console.ReadLine();

            var template = File.ReadAllText(@"C:\PlikiTekstowe\Template\template.txt");
            var document = template.Replace("{name}", name)
                .Replace("{orderNumber}", orderNumber)
                .Replace("{dateTime}", DateTime.Now.ToString());

            File.WriteAllText($"C:\\PlikiTekstowe\\document_{name}.txt", document);
           
        }
        static void ReadFiles()
        {
            var document1 = File.ReadAllText(@"C:\PlikiTekstowe\document1.txt");
            var document2 = File.ReadAllLines(@"C:\PlikiTekstowe\document1.txt");
            var document2String = string.Join(Environment.NewLine, document2);

            Console.WriteLine("Document1");
            Console.WriteLine(document1);

            Console.WriteLine("Document2");
            Console.WriteLine(document2String);
        }
        static void ScanAndAppend()
        {
            var files = Directory.GetFiles("C:/PlikiTekstowe/", "*.txt", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                File.AppendAllText(file, "\nAll rights reserved");
            }
        }
    }
}
