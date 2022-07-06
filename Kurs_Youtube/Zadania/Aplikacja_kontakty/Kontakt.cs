using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania.Aplikacja_kontakty
{
    public class Kontakt
    {
        public Kontakt(string nazwa,int numerTelefonu)
        {
            Nazwa = nazwa;
            Numer_telefonu = numerTelefonu;
        }
        private string _nazwa;
        private int _numer_telefonu;
        public string Nazwa { get { return _nazwa; } set { _nazwa = value; } }
        public int Numer_telefonu { get { return _numer_telefonu; } set { _numer_telefonu = value; } }

        
    }
}
