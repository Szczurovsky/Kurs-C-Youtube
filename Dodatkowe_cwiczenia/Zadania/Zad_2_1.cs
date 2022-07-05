using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodatkowe_cwiczenia.Zadania
{
    internal class Zad_2_1
    {
        public static void Zad2_1()
        {
            Energy[] tab = new Energy[2];
            tab[0] = new Energy(3231, 1, 333, "ul. YZX");
            tab[1] = new Energy(551, 5, 323, "ul. YZX");
            foreach (Energy e in tab)
            {
                e.WyswietlDane();
                e.ObliczanieZuzycia();
            }
        }
    }
    class Energy
    {
        private double _numer_licznika, _poczatkowy_stan, _biezacy_stan;
        public double Numer_licznika { get { return _numer_licznika; } set { _numer_licznika = value; } }
        public double Poczatkowy_stan { get { return _poczatkowy_stan; } set { _poczatkowy_stan = value; } }
        public double Biezacy_stan { get { return _biezacy_stan; } set { _biezacy_stan = value; } }
        private string _dane_mieszkania;
        public string Dane_mieszkania { get { return _dane_mieszkania; } set { _dane_mieszkania = value; } }

        public Energy(double nL, double pS, double bS, string dM)
        {
            Numer_licznika = nL;
            Poczatkowy_stan = pS;
            Biezacy_stan = bS;
            Dane_mieszkania = dM;
        }
        public void ObliczanieZuzycia()
        {
            double zuzycie;
            zuzycie = _biezacy_stan - _poczatkowy_stan;
            Console.WriteLine("Zuzycie energii wynosi: " + zuzycie);
        }
        public void WyswietlDane()
        {
            _numer_licznika.ToString();
            Console.WriteLine($"Numer licznika: {_numer_licznika}, początkowy stan licznika: {_poczatkowy_stan}, bieżący stan licznika: {_biezacy_stan}, dane mieszkania: {_dane_mieszkania}");
        }
    }
}
