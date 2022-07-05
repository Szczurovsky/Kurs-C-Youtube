using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodatkowe_cwiczenia.Zadania
{
    internal class Zad_1_3
    {
        public static void Zad_13()
        {
            Samochod s1 = new Samochod("Diesel","Hatchback");
            s1.Moc_silnika = "100 km";
            s1.Zuzycie_paliwa();
        }

class Pojazd
        {
            
            private string _moc_silnika, _marka, _model, _rodzaj_paliwa;
            private int _zuzycie_100;

            public string Marka { get; set; }
            public string Moc_silnika { get; set; }
            public string Model { get; set; }
            public string Rodzaj_paliwa { get; set; }
            public int Zuzycie_100 { get; set; }
        }
        class Samochod : Pojazd
        {
            private string? _typ_nadwozia;
            private int _ilosc_drzwi, _ilosc_przejechanych_km;
            public string? Typ_nadwozia { get; set; }
            public int Ilosc_drzwi { get; set; }
            public int Ilosc_przejechanych_km { get; set; }
            public Samochod(string Rodzaj_Paliwa, string Typ_Nadwozia)
            {
                Rodzaj_paliwa = Rodzaj_Paliwa;
                this._typ_nadwozia = Typ_Nadwozia;
            }
            
            public void Zuzycie_paliwa()
            {
                Console.WriteLine($"Samochód zużył łącznie {(int)Zuzycie_100*Ilosc_przejechanych_km/100} litrów paliwa");
                Console.WriteLine("Moc silnika" + Moc_silnika);
                Console.WriteLine("Model samochodu" + Model);
                Console.WriteLine("Rodzaj spalanego paliwa " + Rodzaj_paliwa);
                Console.WriteLine("Typ Nadwozia" + Typ_nadwozia);

            }
        }


    }
}

