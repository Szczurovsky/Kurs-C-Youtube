using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_06_03_using
    {
        public static void Program()
        {
            var readFileStream = new FileStream("C:/PlikiTekstowe/document1.txt", FileMode.Open);
            readFileStream.Close();
            var writeFileStream = new FileStream("C:/PlikiTekstowe/document1.txt", FileMode.Open);
            writeFileStream.Close();

        }
    }
}
